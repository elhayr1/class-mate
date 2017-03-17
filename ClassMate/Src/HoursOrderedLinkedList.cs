using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMate.Src
{
    /*********************************************************************************
     * This class holds hours linked list, and keep it 
     * ordered after each insersion. Output example:
     * [8:30 - 11:0] => [12:30 - 13:15] => [13:30 - 16:0] => [16:15 - 17:45] => [NULL]
     ********************************************************************************/

    class HoursOrderedLinkedList
    {
        private int size_;
        private HourNode head_, tail_;
        public HoursOrderedLinkedList()
        {
            size_ = 0;
            head_ = tail_= null;
        }

        public void add(HourNode new_hour_node)
        {
            
            if (size_ == 0)
                head_ = tail_ = new_hour_node;
            else
            {
                HourNode temp_iterator = head_;

                while (temp_iterator.next != null &&
                       new_hour_node > temp_iterator)
                {
                    temp_iterator = temp_iterator.next;
                }

                if (temp_iterator.next == null)
                {
                    if (new_hour_node < temp_iterator)
                        addBefore(new_hour_node, temp_iterator);
                    else
                        addToTail(new_hour_node);
                }
            }
            size_++;
        }

        private void addBefore(HourNode new_hour_node, HourNode curr_node)
        {
            if (curr_node.prev == null)
                addToHead(new_hour_node);
            else
            {
                new_hour_node.next = curr_node;
                curr_node.prev.next = new_hour_node;
                new_hour_node.prev = curr_node.prev;
                curr_node.prev = new_hour_node;
            }
        }

        private void addToHead(HourNode new_hour_node)
        {
            new_hour_node.next = head_;
            head_.prev = new_hour_node;
            head_ = new_hour_node;   
        }

        private void addToTail(HourNode new_hour_node)
        {
            tail_.next = new_hour_node;
            new_hour_node.prev = tail_;
            tail_ = new_hour_node;
        }

        public int size() { return size_; }

        public FreeTime getFreeTime(Hour search_time)
        {
            if (search_time < head_.lower_hour)
                return new FreeTime(search_time, head_.lower_hour);

            HourNode temp_iterator = head_;
            while (temp_iterator.next != null)
            {
 
                //search time is between hour nodes
                if  (search_time >= temp_iterator.upper_hour && search_time <= temp_iterator.next.lower_hour)
                    if (temp_iterator.next.lower_hour - search_time > new Hour(0, 0))
                        return new FreeTime(search_time, temp_iterator.next.lower_hour); 

                //search time is inside hour node range
                else if (search_time >= temp_iterator.lower_hour && 
                         search_time <= temp_iterator.upper_hour)
                    if (temp_iterator.next.lower_hour - temp_iterator.upper_hour > new Hour(0,0))
                        return new FreeTime(temp_iterator.upper_hour, temp_iterator.next.lower_hour);

                temp_iterator = temp_iterator.next;
            }
            if (tail_.upper_hour > search_time)
            {
                if (new Hour(24, 0) - tail_.upper_hour > new Hour(0, 0))
                    return new FreeTime(tail_.upper_hour, new Hour(24, 0)); //available until end of day
            }
            else
            {
                if (new Hour(24, 0) - search_time > new Hour(0, 0))
                    return new FreeTime(search_time, new Hour(24, 0)); //available until end of day
            }
            return null;
        }

        public void printList()
        {
            HourNode temp_iterator = head_;
            while (temp_iterator != null)
            {
                Console.Write("[{0}:{1} - {2}:{3}] => ", 
                              temp_iterator.lower_hour.getHours(),
                              temp_iterator.lower_hour.getMinutes(),
                              temp_iterator.upper_hour.getHours(),
                              temp_iterator.upper_hour.getMinutes());
                temp_iterator = temp_iterator.next;
            }
            Console.WriteLine("[NULL]");
        }
        
    }
}
