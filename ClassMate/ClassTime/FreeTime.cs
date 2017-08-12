using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMate.Parsers
{
    class FreeTime
    {
        public HourNode fromTo {get; private set;}
        public Hour totalTime {get; private set;}

        public FreeTime(Hour from, Hour to)
        {
            fromTo = new HourNode(from, to);
            totalTime = to - from;
        }
    }
}
