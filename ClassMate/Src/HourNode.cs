using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMate.Parsers
{
    class HourNode
    {
        public const int UPPER_HOUR = 1, LOWER_HOUR = 0;
        public string [] hour_window_;
        public Hour upper_hour, lower_hour;
        public HourNode next, prev;

        public HourNode(Hour from, Hour to)
        {
            lower_hour = from;
            upper_hour = to;
            prev = next = null;
        }

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
            if ((hour_node1.upper_hour < hour_node2.lower_hour) ||
                hour_node1.upper_hour.Equals(hour_node2.lower_hour))
                return true;
            return false;
        }

        public static bool operator >(HourNode hour_node1, HourNode hour_node2)
        {
            /*if (!(hour_node1.Equals(hour_node2)) && 
                !(hour_node1 < hour_node2))
                return true;
            return false;*/
            if ((hour_node1.lower_hour > hour_node2.upper_hour) ||
                hour_node1.lower_hour.Equals(hour_node2.upper_hour))
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
            return upper_hour.ToString() + " - " + lower_hour.ToString();
        }  

        public override string ToString() 
        {
            return lower_hour.ToString() + " - " + upper_hour.ToString(); 
        }


    }
}
