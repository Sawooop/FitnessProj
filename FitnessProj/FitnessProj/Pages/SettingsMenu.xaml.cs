using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FitnessProj.Pages
{
    /// <summary>
    /// Interaction logic for SettingsMenu.xaml
    /// </summary>
    public partial class SettingsMenu : Page
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void DarkModeButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            if(Globals.isDarkMode == false)
            {

                    var converter = new System.Windows.Media.BrushConverter();
                    var backgroundColor = (Brush)converter.ConvertFromString("#FF252526");
                    var textColor = (Brush)converter.ConvertFromString("#FFF1F1F1");
                    Background = backgroundColor;
                //Globals.fList[Globals.fList.Count - 1].name
                //Color textColor = (Color)ColorConverter.ConvertFromString(); 
                //Globals.isDarkMode = true;
            } else
            {
                Globals.isDarkMode = false;
                if (Globals.isDarkMode == false)
                {
                    var converter = new System.Windows.Media.BrushConverter();
                    var backgroundColor = (Brush)converter.ConvertFromString("#FF252526");
                    var textColor = (Brush)converter.ConvertFromString("#FFF1F1F1");
                    Background = backgroundColor;
                    //MainMenu.Foreground = textColor;
                    //Color textColor = (Color)ColorConverter.ConvertFromString(); 
                }
            }
            */
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            foreach (Account a in Globals.aList)
            {
                if(a.index == Globals.index)
                {
                    Globals.aList.Remove(a);
                    TextFile.Delete();
                    return;
                }
            }
        }
    }
}
