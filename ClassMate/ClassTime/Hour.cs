using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMate.Parsers
{
    class Hour
    {
        private const int MINUTES = 1, HOURS = 0;
        private int[] hourTime = new int[2];

        public int Minutes
        {
            get
            {
                return hourTime[MINUTES];
            }
        }

        public int Hours
        {
            get
            {
                return hourTime[HOURS];
            }
        }

        public Hour(string hourTimeIn)
        {
            // try
            // {
            var hoursMinutesPair = hourTimeIn.Split(':');
            hourTime[HOURS] = int.Parse(hoursMinutesPair[HOURS]);
            hourTime[MINUTES] = int.Parse(hoursMinutesPair[MINUTES]);
            // } catch (Exception e)
            // {

            // }

        }

        public Hour(int hour, int mins)
        {
            hourTime[HOURS] = hour;
            hourTime[MINUTES] = mins;
        }

        public override bool Equals(Object other)
        {
            if (other == null) return false;

            Hour other_hour = other as Hour;
            if ((System.Object)other_hour == null) { return false; }

            if (this.Hours == other_hour.Hours &&
                this.Minutes == other_hour.Minutes)
                return true;
            return false;
        }

        public static Hour operator -(Hour higher_hour, Hour lower_hour)
        {

            int hour_delta = higher_hour.Hours -
                                lower_hour.Hours;
            int mins_delta = 0;
            if (higher_hour.Minutes >
                lower_hour.Minutes)
                mins_delta = higher_hour.Minutes -
                                lower_hour.Minutes;

            else if (higher_hour.Minutes <
              lower_hour.Minutes)
            {
                hour_delta--;
                mins_delta = 60 + higher_hour.Minutes -
                               lower_hour.Minutes;
            }
            return new Hour(hour_delta, mins_delta);
        }

        public static bool operator <(Hour hour1, Hour hour2)
        {
            if (hour1.Hours < hour2.Hours)
                return true;

            if (hour1.Hours == hour2.Hours &&
                hour1.Minutes < hour2.Minutes) 
                return true;

            return false;
        }

        public static bool operator >(Hour hour1, Hour hour2)
        {
            if ((!hour1.Equals(hour2)) && !(hour1 < hour2))
                return true;
            return false;
        }

        public static bool operator >=(Hour hour1, Hour hour2)
        {
            if ((hour1.Equals(hour2)) || (hour1 > hour2))
                return true;
            return false;
        }

        public static bool operator <=(Hour hour1, Hour hour2)
        {
            if ((hour1.Equals(hour2)) || (hour1 < hour2))
                return true;
            return false;
        }

        public override string ToString()
        {
            string mins = Minutes < 10 ? "0" + Minutes.ToString() : Minutes.ToString();
            return Minutes + ":" + mins;
        }


        public static Hour Now() 
        {
            return new Hour(DateTime.Now.ToString("HH:mm"));
        }


    }

}
