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
            Globals.updateProgress();
            //something here
            while (Globals.Progress >= Globals.requiredProgress)
            {
                Globals.Progress -= Globals.requiredProgress;
                Globals.level += 1;
                Globals.updateProgress();

            }
            LevelBar.Maximum = Globals.requiredProgress;
            LevelBar.Value = Globals.Progress;
             
            textBlockLevel.Text = "Level: " + Globals.level;
            textBlockProgress.Text = "Progress to next level: " + Globals.Progress + " / " + Globals.requiredProgress;
        }
    }
}
