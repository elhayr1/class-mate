using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMate.Parsers
{
    /*********************************************************************************
     * This class holds hours linked list, and keep it 
     * ordered after each insersion. Output example:
     * [8:30 - 11:0] => [12:30 - 13:15] => [13:30 - 16:0] => [16:15 - 17:45] => [NULL]
     ********************************************************************************/

    //todo: on top of each class - document and draw illustration of data

    class HoursOrderedLinkedList
    {
        private int size_;
        private HourNode head_, tail_;
        public HoursOrderedLinkedList()
        {
            size_ = 0;
            head_ = tail_= null;
        }

        public void add(HourNode new_node)
        {
            //TODO: prevent adding same hours node (sapir fucked up html...) - compare to each node while finding place to insert new node
            if (size_ == 0)
                head_ = tail_ = new_node;
            else
            {
                HourNode temp_iterator = head_;

                while (temp_iterator.next != null &&
                       new_node > temp_iterator)
                {
                   
                    temp_iterator = temp_iterator.next;
                   //if (new_node == temp_iterator) //node already exist, stop 
                  //     return;
                }

                if (temp_iterator.next == null)
                {
                    if (new_node < temp_iterator)
                        addBefore(new_node, temp_iterator);
                    else
                        addToTail(new_node);
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

        public FreeTime getFreeTime(Hour from_time)
        {
            if (from_time < head_.lower_hour)
                return new FreeTime(from_time, head_.lower_hour);

            HourNode temp_iterator = head_;
            while (temp_iterator.next != null)
            {
                //search time is between hour nodes
                if  (from_time >= temp_iterator.upper_hour && 
                     from_time <= temp_iterator.next.lower_hour)
                {
                    if (temp_iterator.next.lower_hour - from_time > new Hour(0, 0))
                        return new FreeTime(from_time, temp_iterator.next.lower_hour); 
                }
                //search time is inside hour node range
                else if (from_time >= temp_iterator.lower_hour && 
                         from_time <= temp_iterator.upper_hour)
                {
                    if (temp_iterator.next.lower_hour - temp_iterator.upper_hour > new Hour(0, 0))
                        return new FreeTime(temp_iterator.upper_hour, temp_iterator.next.lower_hour);
                }
                temp_iterator = temp_iterator.next;
            }

            if (tail_.upper_hour > from_time)
            {
                if (new Hour(24, 0) - tail_.upper_hour > new Hour(0, 0))
                    return new FreeTime(tail_.upper_hour, new Hour(24, 0)); //available until end of day
            }
            else
            {
                if (new Hour(24, 0) - from_time > new Hour(0, 0))
                    return new FreeTime(from_time, new Hour(24, 0)); //available until end of day
            }
            return null; //no avail time found
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
