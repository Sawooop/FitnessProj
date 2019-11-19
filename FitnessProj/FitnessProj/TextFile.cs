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
        public static void write(List<FitnessType> writeList)
        {
            List<string> listLines = new List<string>();
            foreach (FitnessType f in writeList)
            {
                listLines.Add(f.name + "*" + f.unitName + "*" + f.unitWorth.ToString() + "*" + f.numberOfUnits.ToString() + "*");
            }

            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                foreach (string line in listLines)
                    outputFile.WriteLine(line);
            }
        }

        public static void Read(List<FitnessType> fList)
        {
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamReader sr = new StreamReader(Path.Combine(docPath, "WriteLines.txt")))
            {
                String line = sr.ReadToEnd();
                string[] converterArray = line.Split('*');
                List<string> converterList = converterArray.ToList();
                int mulitple = converterList.Count() / 4;
                for (int i = 0; i < mulitple; i++)
                {
                    FitnessType newItem = new FitnessType();
                    newItem.name = converterList[0];
                    newItem.unitName = converterList[1];
                    newItem.unitWorth = Convert.ToInt32(converterList[2]);
                    newItem.numberOfUnits = Convert.ToInt32(converterList[3]);
                    Globals.Progress += newItem.unitWorth;
                    fList.Add(newItem);
                    for (int ie = 0; ie < 4; ie++)
                    {
                    converterList.Remove(converterList[0]);
                    }

                }




            }
          
        }
    }
}
