using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class SmallPlaneNE : Airplane
    {
        public SmallPlaneNE(int flightNum, int seat, int range, int flightTime, string origin, string destination, string maintenance, string schedule) : base(flightNum, seat, range, flightTime, origin, destination, maintenance, schedule)
        {
            this.flightNum = 1002;
            this.seat = 20;
            this.range = 750;
            this.flightTime = 90;
            this.origin = "Atlanta GA";
            this.destination = "Milwaukee WI";
            this.maintenance = "Maintenance";
            this.schedule = "Departure Time : 1:00PM | Arrival Time : 2:30PM ";
        }

        public override string ToString()
        {
            return "-------Flight-" + flightNum + "-----------------------------------" + Environment.NewLine + "Capacity : " + seat + " passengers" + Environment.NewLine + "Range: " + range + " miles" + Environment.NewLine + "Flight Time : " + flightTime + " minutes" + Environment.NewLine + "From " + origin + " TO " + destination + Environment.NewLine + maintenance + ": Passed" + Environment.NewLine + schedule;
        }
    }
}
