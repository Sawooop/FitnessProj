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
        bool isHappy;
        int totalPoints;
        PointsNeeded need = new PointsNeeded();
        FitnessType totalPointsInTotal = new FitnessType();
        public int TotalPoints()
        {
            totalPoints = totalPointsInTotal.TotalWorth();
            return totalPoints;
        }
        public bool IsAvatarHappy()
        {
            if (totalPoints > need.PointsToBeHappy())
            {
                isHappy = true;
            }
            else
            {
                isHappy = false;
            }

            return isHappy;
        }
        public int MoodLevel()
        {
            moodLvl = totalPoints / need.PointsToLevelUp();
            return moodLvl;
        }
        public double ProgressToNextLvl()
        {
            return (Convert.ToDouble(totalPoints / need.PointsToBeHappy()) - moodLvl) * 100;
        }
    }
}
