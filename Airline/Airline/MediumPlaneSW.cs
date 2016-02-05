using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class MediumPlaneSW : Airplane
    {
        int firstClass;

        public MediumPlaneSW(int flightNum, int seat, int range, int flightTime, string origin, string destination, string maintenance, int firstClass, string schedule) : base(flightNum, seat, range, flightTime, origin, destination, maintenance, schedule)
        {
            this.flightNum = 101;
            this.seat = 40;
            this.range = 1500;
            this.flightTime = 210;
            this.origin = "Chicago, IL";
            this.destination = "Phoenix, AZ";
            this.maintenance = "Maintenance";
            this.firstClass = 10;
            this.schedule = "Departure Time : 6:30AM | Arrival Time : 10:00AM ";
        }

        public override string ToString()
        {
            return "-------Flight-" + flightNum + "-------------------------------------" + Environment.NewLine + "Capacity/First Class Seats : " + seat + " passengers" + "/ " + firstClass + " seats" + Environment.NewLine + "Range: " + range + " miles" + Environment.NewLine + "Flight Time : " + flightTime + " minutes" + Environment.NewLine + "From " + origin + " TO " + destination + Environment.NewLine + maintenance + ": Passed" + Environment.NewLine + schedule;
        }
    }
}
