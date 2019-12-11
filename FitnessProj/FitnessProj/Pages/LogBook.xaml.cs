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
            DataColumn timeDone = new DataColumn("Time Logged", typeof(DateTime));

            log.Columns.Add(name);
            log.Columns.Add(unitName);
            log.Columns.Add(numberOfUnits);
            log.Columns.Add(timeDone);

            foreach(FitnessType f in Globals.fList)
            {
                DataRow newRow = log.NewRow();
                newRow[0] = f.name;
                newRow[1] = f.unitName;
                newRow[2] = f.numberOfUnits;
                newRow[3] = f.time;
                log.Rows.Add(newRow);
            }
            dataGridLogBook.ItemsSource = log.DefaultView;
        }

        private void DataGridLogBook_Loaded(object sender, RoutedEventArgs e)
        {
            this.fillingDataGridUsingDataTable();
        }

        private void DataGridLogBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView rowSelected = gd.SelectedItem as DataRowView;
            if(rowSelected != null)
            {
                foreach (FitnessType f in Globals.fList)
                {
                    if(rowSelected["Name"].ToString() == f.name && rowSelected["Unit Name"].ToString() == f.unitName)
                    {
                        Globals.fList.Remove(f);
                        this.fillingDataGridUsingDataTable();
                        TextFile.write(Globals.fList);
                        return;
                    }
                }
            }

        }
    }
}
