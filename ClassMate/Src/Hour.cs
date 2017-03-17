using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMate.Src
{
    class Hour
    {
        private const int MINUTES = 1, HOURS = 0;
        private int[] hour_time = new int[2];
        public Hour(string hour_time_in)
        {
            // try
            // {
            var hours_minutes_pair = hour_time_in.Split(':');
            hour_time[HOURS] = int.Parse(hours_minutes_pair[HOURS]);
            hour_time[MINUTES] = int.Parse(hours_minutes_pair[MINUTES]);
            // } catch (Exception e)
            // {

            // }

        }

        public Hour(int hour, int mins)
        {
            hour_time[HOURS] = hour;
            hour_time[MINUTES] = mins;
        }

        public int getMinutes()
        {
            return hour_time[MINUTES];
        }

        public int getHours()
        {
            return hour_time[HOURS];
        }

        public override bool Equals(Object other)
        {
            if (other == null) return false;

            Hour other_hour = other as Hour;
            if ((System.Object)other_hour == null) { return false; }

            if (this.getHours() == other_hour.getHours() &&
                this.getMinutes() == other_hour.getMinutes())
                return true;
            return false;
        }

        public static Hour operator -(Hour higher_hour, Hour lower_hour)
        {

            int hour_delta = higher_hour.getHours() -
                                lower_hour.getHours();
            int mins_delta = 0;
            if (higher_hour.getMinutes() >
                lower_hour.getMinutes())
                mins_delta = higher_hour.getMinutes() -
                                lower_hour.getMinutes();
            if (higher_hour.getMinutes() <
              lower_hour.getMinutes())
            {
                hour_delta--;
                mins_delta = 60 + higher_hour.getMinutes() -
                               lower_hour.getMinutes();
            }
            return new Hour(hour_delta, mins_delta);
        }

        public static bool operator <(Hour hour1, Hour hour2)
        {
            if (hour1.getHours() == hour2.getHours() &&
                hour1.getMinutes() == hour2.getMinutes())
                return false;

            if (hour1.getHours() > hour2.getHours())
                return false;

            if (hour1.getHours() < hour2.getHours())
                return true;

            if (hour1.getMinutes() < hour2.getMinutes()) //hour1.getHour() == hour2.getHour()
                return true;
            return false;
        }

        public static bool operator >(Hour hour1, Hour hour2)
        {
            if (!(hour1 == hour2) && !(hour1 < hour2))
                return true;
            return false;
        }

        public static bool operator >=(Hour hour1, Hour hour2)
        {
            if ((hour1 == hour2) || (hour1 > hour2))
                return true;
            return false;
        }

        public static bool operator <=(Hour hour1, Hour hour2)
        {
            if ((hour1 == hour2) || (hour1 < hour2))
                return true;
            return false;
        }

        public override string ToString()
        {
            string mins = getMinutes() < 10 ? getMinutes().ToString() + "0" : getMinutes().ToString();
            return getHours() + ":" + mins;
        }
    }

}
