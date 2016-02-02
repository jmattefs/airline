using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class BigPlaneSW : Airplane
    {
        int firstClass;

        public BigPlaneSW(int flightNum, int seat, int range, int flightTime, string origin, string destination, string maintenance, int firstClass) : base(flightNum, seat, range, flightTime, origin, destination, maintenance)
        {
            this.flightNum = 11;
            this.seat = 75;
            this.range = 3000;
            this.flightTime = 330;
            this.origin = "New York, NY";
            this.destination = "Los Angeles, CA";
            this.maintenance = "Maintenance";
            this.firstClass = 25;
        }

        public override string ToString()
        {
            return "Flight : " + flightNum + " | Capacity : " + seat + " passengers | FirstClass Seats : " + firstClass + " | Range: " + range + " miles | Flight Time : " + flightTime + " minutes | FROM: " + origin + " | TO: " + destination + " | " + maintenance + " : Passed";
        }
    }
}
