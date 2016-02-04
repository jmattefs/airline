using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class SmallPlaneSW : Airplane
    {
        public SmallPlaneSW(int flightNum, int seat, int range, int flightTime, string origin, string destination, string maintenance, string schedule) : base(flightNum, seat, range, flightTime, origin, destination, maintenance, schedule)
        {
            this.flightNum = 1001;
            this.seat = 20;
            this.range = 750;
            this.flightTime = 90;
            this.origin = "Milwaukee WI";
            this.destination = "Atlanta GA";
            this.maintenance = "Maintenance";
            this.schedule = "Departure Time : 6:30AM | Arrival Time : 8:00AM ";
        }

        public override string ToString()
        {
            return "Flight : " + flightNum + Environment.NewLine + "Capacity : " + seat + " passengers" + Environment.NewLine + "Range: " + range + " miles" + Environment.NewLine + "Flight Time : " + flightTime + " minutes" + Environment.NewLine + "From " + origin + " TO " + destination + Environment.NewLine + maintenance + ": Passed" + Environment.NewLine + schedule;
        }
    }
}
