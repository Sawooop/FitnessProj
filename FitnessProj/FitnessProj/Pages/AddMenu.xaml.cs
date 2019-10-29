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
    /// Interaction logic for AddMenu.xaml
    /// </summary>
    public partial class AddMenu : Page
    {
        public AddMenu()
        {
            InitializeComponent();
        }

        List<FitnessType> fList = new List<FitnessType>();

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            FitnessType newFitnessType = new FitnessType(textBoxExerciseType.Text, textBoxUnitName.Text, Convert.ToInt32(textBoxUnitValue.Text), Convert.ToInt32(textBoxUnitNumber.Text));
            fList.Add(newFitnessType);
            MessageBox.Show(newFitnessType.name);
            MessageBox.Show(newFitnessType.unitName);
            MessageBox.Show(Convert.ToString(newFitnessType.unitWorth));
            MessageBox.Show(Convert.ToString(newFitnessType.numberOfUnits));
            Globals.Progress = Mood.currentMood.ProgressToNextLvl();
        }
    }
}
