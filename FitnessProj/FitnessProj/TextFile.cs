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
using System.IO;


namespace FitnessProj
{
    class TextFile
    {
        public static void writeAccount(List<Account> writeList)
        {
            List<string> listLines = new List<string>();
            foreach (Account a in writeList)
            {
                listLines.Add(a.userName + "*" + a.password + "*" + a.index.ToString() + "*");
            }

            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "AccountList.txt")))
            {
                foreach (string line in listLines)
                    outputFile.WriteLine(line);
            }
        }
        public static void readAccount(List<Account> aList)
        {
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamReader sr = new StreamReader(Path.Combine(docPath, "AccountList.txt")))
            {
                String line = sr.ReadToEnd();
                string[] converterArray = line.Split('*');
                List<string> converterList = converterArray.ToList();
                int mulitple = converterList.Count() / 3;
                for (int i = 0; i < mulitple; i++)
                {
                    Account newAccount = new Account();
                    newAccount.userName = converterList[0];
                    newAccount.password = converterList[1];
                    newAccount.index = Convert.ToInt32(converterList[2]);
                    aList.Add(newAccount);
                    for (int ie = 0; ie < 3; ie++)
                    {
                        converterList.Remove(converterList[0]);
                    }

                }
            }
        }
        public static void write(List<FitnessType> writeList)
        {
            List<string> listLines = new List<string>();
            foreach (FitnessType f in writeList)
            {
                listLines.Add(f.name + "*" + f.unitName + "*" + f.unitWorth.ToString() + "*" + f.numberOfUnits.ToString() + "*" + f.time.ToString() + "*");
            }

            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, Globals.index + ".txt")))
            {
                foreach (string line in listLines)
                    outputFile.WriteLine(line);
            }
        }

        public static void Read(List<FitnessType> fList)
        {
           string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamReader sr = new StreamReader(Path.Combine(docPath, Globals.index + ".txt")))
            {
                String line = sr.ReadToEnd();
                string[] converterArray = line.Split('*');
                List<string> converterList = converterArray.ToList();
                int mulitple = converterList.Count() / 5;
                for (int i = 0; i < mulitple; i++)
                {
                    FitnessType newItem = new FitnessType();
                    newItem.name = converterList[0];
                    newItem.unitName = converterList[1];
                    newItem.unitWorth = Convert.ToInt32(converterList[2]);
                    newItem.numberOfUnits = Convert.ToInt32(converterList[3]);
                    newItem.time = Convert.ToDateTime(converterList[4]);
                    Globals.Progress += newItem.unitWorth;
                    fList.Add(newItem);
                    for (int ie = 0; ie < 5; ie++)
                    {
                    converterList.Remove(converterList[0]);
                    }

                }




            }
          
        }
    }
}
