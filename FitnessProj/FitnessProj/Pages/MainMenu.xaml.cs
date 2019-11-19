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

namespace FitnessProj
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            while (Globals.Progress >= 4000)
            {
                Globals.Progress -= 4000;
                Globals.level += 1;

            }
            LevelBar.Value = Globals.Progress / 40;
            textBlockLevel.Text = "Level: " + Globals.level;
            textBlockProgress.Text = "Progress to next level: " + Globals.level + " / " + Globals.requiredProgress;

        }

        private void TempDisplay_Click(object sender, RoutedEventArgs e)
        {
            foreach(FitnessType f in Globals.fList)
            {
                MessageBox.Show("Exercise name: "+f.name + System.Environment.NewLine + "Exercise Name: " + f.unitName + Environment.NewLine + "Number of Times Done: " + f.numberOfUnits.ToString());
            }
        }
    }
}
