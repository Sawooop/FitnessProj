﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProj
{
    class FitnessType
    {
        public string name;
        public string unitName;
        public int unitWorth;
        public int numberOfUnits;

        public FitnessType(string Name, string UnitName, int UnitWorth)
        {
            name = Name;
            unitName = UnitName;
            unitWorth = UnitWorth;
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
