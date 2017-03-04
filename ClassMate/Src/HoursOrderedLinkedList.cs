﻿using System;
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
            int finder_counter = 0;

            if (size_ == 0)
                head_ = tail_ = new_hour_node;
            else if (size_ == 1)
            {
                if (new_hour_node < head_)
                    addToHead(new_hour_node);
                else
                    addToTail(new_hour_node);
            }
            else
            {
                HourNode temp_iterator = head_;

                while (temp_iterator.next != null &&
                       new_hour_node > temp_iterator)
                {
                    temp_iterator = temp_iterator.next;
                    finder_counter++;
                }

                if (temp_iterator.next == null)
                {
                    if (new_hour_node < temp_iterator)
                        addBefore(new_hour_node, temp_iterator);
                    else
                        addToTail(new_hour_node);
                } 
                else if (temp_iterator.prev == null)
                    addToHead(new_hour_node);
                else
                    addBefore(new_hour_node, temp_iterator);
            }
            size_++;
        }

        private void addBefore(HourNode new_hour_node, HourNode curr_node)
        {
            new_hour_node.next = curr_node;
            curr_node.prev.next = new_hour_node;
            new_hour_node.prev = curr_node.prev;
            curr_node.prev = new_hour_node;
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

        public Hour getFreeTime(Hour search_time)
        {
            HourNode temp_iterator = head_;
            while (temp_iterator.next != null)
            {
                if (search_time > temp_iterator.lower_hour &&
                    search_time < temp_iterator.upper_hour)
                    return temp_iterator.next.lower_hour - temp_iterator.upper_hour;

                if (search_time > temp_iterator.upper_hour ||
                    search_time == temp_iterator.upper_hour)
                    return temp_iterator.next.lower_hour - search_time;

                temp_iterator = temp_iterator.next;
            }
            return null; //available until next day
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