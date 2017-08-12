using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMate.ClassTime
{
    class HebrewDay
    {
        public static string IntDayToString(int day)
        {
            switch (day)
            {
                case 0:
                    return "ראשון";
                case 1:
                    return "שני";
                case 2:
                    return "שלישי";
                case 3:
                    return "רביעי";
                case 4:
                    return "חמישי";
                case 5:
                    return "שישי";
            }
            return "";
        }

        public static int StringDayToInt(string day)
        {
            switch (day)
            {
                case "ראשון":
                    return 0;
                case "שני":
                    return 1;
                case "שלישי":
                    return 2;
                case "רביעי":
                    return 3;
                case "חמישי":
                    return 4;
                case "שישי":
                    return 5;
            }
            return -1;
        }
    }
}
