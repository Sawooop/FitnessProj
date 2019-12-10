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
    /// Interaction logic for LoginMenu.xaml
    /// </summary>
    public partial class LoginMenu : Page
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, RoutedEventArgs e)
        {
            bool verify = false;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            TextFile.readAccount(Globals.aList);
            int index = Globals.aList.Count();
            if (Globals.aList.Count() > 0)
            {

                foreach (Account a in Globals.aList)
                {
                    if (username.ToLower() == a.userName.ToLower() && password.ToLower() == a.password.ToLower())
                    {
                        verify = true;
                        Globals.index = a.index;
                        MessageBox.Show("connected to account");
                        TextFile.Read(Globals.fList);
                        return;
                    }

                }
                if(verify == false)
                {
                    Account newAccount = new Account(username, password, index);
                    Globals.aList.Add(newAccount);
                    Globals.index = index;
                    TextFile.writeAccount(Globals.aList);
                    MessageBox.Show("could not connect");
                    MessageBox.Show("created new account");
                }
                verify = false;
            }
            else
            {
                Account newAccount = new Account(username, password, index);
                Globals.aList.Add(newAccount);
                Globals.index = index;
                TextFile.writeAccount(Globals.aList);
                MessageBox.Show("could not connect");
                MessageBox.Show("created new account");
            }
        }
    }
}
