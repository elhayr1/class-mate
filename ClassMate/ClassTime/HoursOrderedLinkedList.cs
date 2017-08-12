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

        public void Add(HourNode newNode)
        {
            //TODO: prevent adding same hours node (sapir fucked up html...) - compare to each node while finding place to insert new node
            if (size_ == 0)
                head_ = tail_ = newNode;
            else
            {
                HourNode tempIterator = head_;

                while (tempIterator.Next != null &&
                       newNode > tempIterator)
                {
                   
                    tempIterator = tempIterator.Next;
                   //if (new_node == temp_iterator) //node already exist, stop 
                  //     return;
                }

                if (tempIterator.Next == null)
                {
                    if (newNode < tempIterator)
                        AddBefore(newNode, tempIterator);
                    else
                        AddToTail(newNode);
                }
            }
            size_++;
        }

        private void AddBefore(HourNode newHourNode, HourNode currNode)
        {
            if (currNode.Prev == null)
                AddToHead(newHourNode);
            else
            {
                newHourNode.Next = currNode;
                currNode.Prev.Next = newHourNode;
                newHourNode.Prev = currNode.Prev;
                currNode.Prev = newHourNode;
            }
        }

        private void AddToHead(HourNode newHourNode)
        {
            newHourNode.Next = head_;
            head_.Prev = newHourNode;
            head_ = newHourNode;   
        }

        private void AddToTail(HourNode newHourNode)
        {
            tail_.Next = newHourNode;
            newHourNode.Prev = tail_;
            tail_ = newHourNode;
        }

        public int Size() { return size_; }

        public FreeTime GetFreeTime(Hour fromTime)
        {
            if (fromTime < head_.LowerHour)
                return new FreeTime(fromTime, head_.LowerHour);

            HourNode tempIterator = head_;
            while (tempIterator.Next != null)
            {
                //search time is between hour nodes
                if  (fromTime >= tempIterator.UpperHour && 
                     fromTime <= tempIterator.Next.LowerHour)
                {
                    if (tempIterator.Next.LowerHour - fromTime > new Hour(0, 0))
                        return new FreeTime(fromTime, tempIterator.Next.LowerHour); 
                }
                //search time is inside hour node range
                else if (fromTime >= tempIterator.LowerHour && 
                         fromTime <= tempIterator.UpperHour)
                {
                    if (tempIterator.Next.LowerHour - tempIterator.UpperHour > new Hour(0, 0))
                        return new FreeTime(tempIterator.UpperHour, tempIterator.Next.LowerHour);
                }
                tempIterator = tempIterator.Next;
            }

            if (tail_.UpperHour > fromTime)
            {
                if (new Hour(24, 0) - tail_.UpperHour > new Hour(0, 0))
                    return new FreeTime(tail_.UpperHour, new Hour(24, 0)); //available until end of day
            }
            else
            {
                if (new Hour(24, 0) - fromTime > new Hour(0, 0))
                    return new FreeTime(fromTime, new Hour(24, 0)); //available until end of day
            }
            return null; //no avail time found
        }

        public void PrintList()
        {
            HourNode temp_iterator = head_;
            while (temp_iterator != null)
            {
                Console.Write("[{0}:{1} - {2}:{3}] => ", 
                              temp_iterator.LowerHour.Hours,
                              temp_iterator.LowerHour.Minutes,
                              temp_iterator.UpperHour.Hours,
                              temp_iterator.UpperHour.Hours);
                temp_iterator = temp_iterator.Next;
            }
            Console.WriteLine("[NULL]");
        }
        
    }
}
