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
    /// Interaction logic for LogBook.xaml
    /// </summary>
    public partial class LogBook : Page
    {
        public LogBook()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            FitnessType newTest = new FitnessType();
            newTest.name = "bruh";
            newTest.unitName = "bruhtest";
            newTest.numberOfUnits = 5;
            fitnessDataGrid.Items.Add(newTest);
            //foreach(FitnessType f in Globals.fList)
            //{
              //  fitnessDataGrid.Items.Add(f);
            //}
        }

        private void FitnessDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
