using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Data;

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
        void fillingDataGridUsingDataTable()
        {
            DataTable log = new DataTable();
            DataColumn name = new DataColumn("Name", typeof(string));
            DataColumn unitName = new DataColumn("Unit Name", typeof(string));
            DataColumn numberOfUnits = new DataColumn("Number Of Units", typeof(int));

            log.Columns.Add(name);
            log.Columns.Add(unitName);
            log.Columns.Add(numberOfUnits);

            foreach(FitnessType f in Globals.fList)
            {
                DataRow newRow = log.NewRow();
                newRow[0] = f.name;
                newRow[1] = f.unitName;
                newRow[2] = f.numberOfUnits;
                log.Rows.Add(newRow);
            }
            dataGridLogBook.ItemsSource = log.DefaultView;
        }

        private void DataGridLogBook_Loaded(object sender, RoutedEventArgs e)
        {
            this.fillingDataGridUsingDataTable();
        }
    }
}
