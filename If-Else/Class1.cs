using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{

    static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {

            if(speed >= 0 && speed <= 4)
            {
                return 0.100;

            } else if( speed >= 5 && speed <= 8)
            {
                return 0.90;
            } else if(speed == 9)
            {
                return 0.80;
            }else
            {
                return 0.77;
            }
            
        }

        public static double ProductionRatePerHour(int speed)
        {
            double d = SuccessRate(speed);
            double result = speed * 221;
            return d * result;

        }

        public static int WorkingItemsPerMinute(int speed)
        {
            return (int)(ProductionRatePerHour(speed) / 60);
        }
    }

}
