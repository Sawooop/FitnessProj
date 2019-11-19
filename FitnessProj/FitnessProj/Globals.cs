using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProj
{
    public static class Globals
    {
        public static int Progress = 0;
        public static int level = 1;
        public static List<FitnessType> fList = new List<FitnessType>();
        public static bool isDarkMode = false;
        public static int requiredProgress = Convert.ToInt32((level + 99) * 1.2);
    }
}
