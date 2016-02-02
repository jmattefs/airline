using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class MediumPlaneNE : Airplane
    {
        int firstClass;

        public MediumPlaneNE(int flightNum, int seat, int range, int flightTime, string origin, string destination, string maintenance, int firstClass) : base(flightNum, seat, range, flightTime, origin, destination, maintenance)
        {
            this.flightNum = 102;
            this.seat = 40;
            this.range = 1500;
            this.flightTime = 210;
            this.origin = "Phoenix, AZ";
            this.destination = "Chicago, IL";
            this.maintenance = "Maintenance";
            this.firstClass = 10;
        }

        public override string ToString()
        {
            return "Flight : " + flightNum + " | Capacity : " + seat + " passengers | FirstClass Seats : " + firstClass + " | Range: " + range + " miles | Flight Time : " + flightTime + " minutes | FROM: " + origin + " | TO: " + destination + " | " + maintenance + " : Passed";
        }
    }
}
