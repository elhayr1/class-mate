using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMate.Parsers
{
    class FreeTime
    {
        public HourNode from_to {get; private set;}
        public Hour total_time {get; private set;}

        public FreeTime(Hour from, Hour to)
        {
            from_to = new HourNode(from, to);
            total_time = to - from;
        }
    }
}
