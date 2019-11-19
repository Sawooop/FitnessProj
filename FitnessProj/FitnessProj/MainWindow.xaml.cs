using FitnessProj.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace FitnessProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextFile.Read(Globals.fList);
            main.Content = new MainMenu();
            if(Globals.isDarkMode == true)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var backgroundColor = (Brush)converter.ConvertFromString("#FF252526");
                var textColor = (Brush)converter.ConvertFromString("#FFF1F1F1");
                Background = backgroundColor;
                MainMenu.Foreground = textColor;
                //Color textColor = (Color)ColorConverter.ConvertFromString(); 
            }
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new MainMenu();
        }

        private void AddMenu_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new AddMenu();
        }

        private void SettingsMenu_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new SettingsMenu();
        }

        private void LogBook_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new LogBook();
        }

        private void Test4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Test5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Test6_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
