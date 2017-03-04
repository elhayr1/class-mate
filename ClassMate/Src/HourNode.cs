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
        private int [] hour_time= new int[2];
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

            if (this.getHours().Equals(other_hour.getHours()) &&
                this.getMinutes().Equals(other_hour.getMinutes()))
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
    }

    class HourNode
    {
        public const int UPPER_HOUR = 1, LOWER_HOUR = 0;
        public string [] hour_window_;
        public Hour upper_hour, lower_hour;
        public HourNode next, prev;

        public HourNode(string hour_window)
        {
            hour_window_ = new string[2];
            hour_window_ = hour_window.Split('-');
            lower_hour = new Hour(hour_window_[LOWER_HOUR]);
            upper_hour = new Hour(hour_window_[UPPER_HOUR]);
            prev = next = null;
        }

        public override bool Equals(object other)
        {
            if (other == null) return false;

            HourNode other_hour_node = other as HourNode;
            if ((System.Object)other_hour_node == null) { return false; }

            if (this.upper_hour.Equals(other_hour_node.upper_hour) &&
                this.lower_hour.Equals(other_hour_node.lower_hour))
                return true;
            return false;
        }

        public static bool operator <(HourNode hour_node1, HourNode hour_node2)
        {
            if (hour_node1.upper_hour < hour_node2.lower_hour)
                return true;
            return false;
        }

        public static bool operator >(HourNode hour_node1, HourNode hour_node2)
        {
            if (!(hour_node1.Equals(hour_node2)) && 
                !(hour_node1 < hour_node2))
                return true;
            return false;
        }

    }
}
