using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMate.Parsers
{
    class HourNode
    {
        private const int UPPER_HOUR = 1, LOWER_HOUR = 0;
        private string [] hourWindow_;
        public Hour UpperHour, LowerHour;
        public HourNode Next, Prev;

        public HourNode(Hour from, Hour to)
        {
            LowerHour = from;
            UpperHour = to;
            Prev = Next = null;
        }

        public HourNode(string hour_window)
        {
            hourWindow_ = new string[2];
            hourWindow_ = hour_window.Split('-');
            LowerHour = new Hour(hourWindow_[LOWER_HOUR]);
            UpperHour = new Hour(hourWindow_[UPPER_HOUR]);
            Prev = Next = null;
        }

        public override bool Equals(object other)
        {
            if (other == null) return false;

            HourNode other_hour_node = other as HourNode;
            if ((System.Object)other_hour_node == null) { return false; }

            if (this.UpperHour.Equals(other_hour_node.UpperHour) &&
                this.LowerHour.Equals(other_hour_node.LowerHour))
                return true;
            return false;
        }

        public static bool operator <(HourNode hour_node1, HourNode hour_node2)
        {
            if ((hour_node1.UpperHour < hour_node2.LowerHour) ||
                hour_node1.UpperHour.Equals(hour_node2.LowerHour))
                return true;
            return false;
        }

        public static bool operator >(HourNode hour_node1, HourNode hour_node2)
        {
            /*if (!(hour_node1.Equals(hour_node2)) && 
                !(hour_node1 < hour_node2))
                return true;
            return false;*/
            if ((hour_node1.LowerHour > hour_node2.UpperHour) ||
                hour_node1.LowerHour.Equals(hour_node2.UpperHour))
                return true;
            return false;
        }

        public static bool operator <=(HourNode hour_node1, HourNode hour_node2)
        {
          if ((hour_node1.Equals(hour_node2)) || 
                (hour_node1 < hour_node2))
                return true;
            return false;
        }

        public static bool operator >=(HourNode hour_node1, HourNode hour_node2)
        {
            if ((hour_node1.Equals(hour_node2)) || 
                (hour_node1 > hour_node2))
                return true;
            return false;
        }

        public string ToHebString()
        {
            return UpperHour.ToString() + " - " + LowerHour.ToString();
        }  

        public override string ToString() 
        {
            return LowerHour.ToString() + " - " + UpperHour.ToString(); 
        }


    }
}
