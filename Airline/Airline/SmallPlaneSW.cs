using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class SmallPlaneSW : Airplane
    {
        public SmallPlaneSW(int flightNum, int seat, int range, int flightTime, string origin, string destination, string maintenance) : base(flightNum, seat, range, flightTime, origin, destination, maintenance)
        {
            this.flightNum = 1001;
            this.seat = 20;
            this.range = 750;
            this.flightTime = 90;
            this.origin = "Milwaukee WI";
            this.destination = "Atlanta GA";
            this.maintenance = "Maintenance";
        }

        public override string ToString()
        {
            return "Flight : " + flightNum + ", Capacity : " + seat + " passengers, Range: " + range + " miles, Flight Time : " + flightTime + " minutes, From " + origin + " TO " + destination + ", " + maintenance + " : Passed";
        }
    }
}
