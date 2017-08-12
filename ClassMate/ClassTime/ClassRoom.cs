using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMate.Parsers;
using System.Windows.Forms;

namespace ClassMate.Parsers
{
    class ClassRoom
    {
        private int id_, floor_, building_;
        private HoursOrderedLinkedList hoursList_;
        public int ID { get { return id_; } }
        public int Floor { get { return floor_; } }
        public int Building { get { return building_; } }
        public HoursOrderedLinkedList HoursList { get { return hoursList_; } }

        public ClassRoom(string classId)
        {
            try
            {
                id_ = int.Parse(classId);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Parser Error");
            }

            floor_ = (id_ / 100) % 10;
            building_ = id_ / 1000;
        }

        public void attachHours(HoursOrderedLinkedList hoursList)
        {
            hoursList_ = hoursList;
        }

        public void addHourNode(HourNode hourNode)
        {
            hoursList_.Add(hourNode);
        }

        
    }
}
