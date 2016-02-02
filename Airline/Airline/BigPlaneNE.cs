using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class BigPlaneNE : Airplane
    {
        int firstClass;
        public BigPlaneNE(int flightNum, int seat, int range, int flightTime, string origin, string destination, string maintenance, int firstclass) : base(flightNum, seat, range, flightTime, origin, destination, maintenance)
        {
            this.flightNum = 12;
            this.seat = 75;
            this.range = 3000;
            this.flightTime = 330;
            this.origin = "Los Angeles, CA";
            this.destination = "New York, NY";
            this.maintenance = "Maintenance";
            this.firstClass = 25;
        }

        public override string ToString()
        {
            return "Flight : " + flightNum + " | Capacity : " + seat + " passengers | FirstClass Seats : " + firstClass + " | Range: " + range + " miles | Flight Time : " + flightTime + " minutes | FROM: " + origin + " | TO: " + destination + " | " + maintenance + " : Passed";
        }
    }
}
