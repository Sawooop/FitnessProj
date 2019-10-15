using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProj
{
    class Mood
    {
        int moodLvl;
        int totalPoints;
        PointsNeeded need = new PointsNeeded();
        FitnessType totalPointsInTotal = new FitnessType();
        public int TotalPoints()
        {
            totalPoints = totalPointsInTotal.TotalWorth();
            return totalPoints;
        }

        public int MoodLevel()
        {
            moodLvl = totalPoints / need.PointsToBeHappy();
            return moodLvl;
        }
        public double ProgressToNextLvl()
        {
            return (Convert.ToDouble(totalPoints / need.PointsToBeHappy()) - moodLvl) * 100;
        }
    }
}
