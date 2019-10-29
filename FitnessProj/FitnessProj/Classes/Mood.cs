using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProj
{
    public class Mood
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

        public int ProgressToNextLvl()
        {
            return (Convert.ToInt32(totalPoints / need.PointsToBeHappy()) - moodLvl) * 100;
        }

        private static Mood _currentMood;

        public static Mood currentMood {
            get {
                if (_currentMood == null) {
                    _currentMood = new Mood();
                }
                return _currentMood;
            }
        }
    }
}
