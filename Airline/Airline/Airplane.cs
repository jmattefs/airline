using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Airplane
    {
        public int flightNum;
        public int seat;
        public int range;
        public int flightTime;
        public string origin;
        public string destination;
        public string maintenance;
        public string schedule;

        public Airplane(int flightNum, int seat, int range, int flightTime, string origin, string destination, string maintenance, string schedule)
        {
            this.flightNum = flightNum;
            this.seat = seat;
            this.range = range;
            this.flightTime = flightTime;
            this.origin = origin;
            this.destination = destination;
            this.maintenance = maintenance;
            this.schedule = schedule;
        }
    }
}
