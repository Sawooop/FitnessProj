using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProj
{
    public class FitnessType
    {

        public string name;

        public string unitName;

        public int numberOfUnits;

        public int unitWorth;

        public FitnessType(string Name, string UnitName, int UnitWorth, int NumberOfUnits)
        {
            name = Name;
            unitName = UnitName;
            unitWorth = UnitWorth;
            numberOfUnits = NumberOfUnits;
        }
        
        public FitnessType()
        {

        }
        public int TotalWorth()
        {
            return unitWorth * numberOfUnits;
        }
    }
}
