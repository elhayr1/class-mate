using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMate.Src;

namespace ClassMate.Src
{
    class ClassRoom
    {
        private int id_, floor_, building_;
        private HoursOrderedLinkedList hours_list_;

        public ClassRoom(string class_id)
        {
            try
            {
                id_ = int.Parse(class_id);
            }
            catch (Exception e)
            {

            }

            floor_ = (id_ / 100) % 10;
            building_ = id_ / 1000;
        }

        public void attachHours(HoursOrderedLinkedList hours_list)
        {
            hours_list_ = hours_list;
        }

        public void addHourNode(HourNode hour_node)
        {
            hours_list_.add(hour_node);
        }

        public int getID() { return id_; }
        public int getFloor() { return floor_; }
        public int getBuilding() { return building_; }
        public HoursOrderedLinkedList getHoursList() { return hours_list_; }
    }
}
