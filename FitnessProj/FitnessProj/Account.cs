using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProj
{
    public class Account
    {
        public string userName;
        public string password;
        public int index;

        public Account(string UserName, string Password, int Index)
        {
            userName = UserName;
            password = Password;
            index = Index;
        }

        public Account()
        {

        }
    }
}
