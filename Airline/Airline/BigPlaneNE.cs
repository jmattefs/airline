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
        public BigPlaneNE(int flightNum, int seat, int range, int flightTime, string origin, string destination, string maintenance, int firstclass, string schedule) : base(flightNum, seat, range, flightTime, origin, destination, maintenance, schedule)
        {
            this.flightNum = 12;
            this.seat = 75;
            this.range = 3000;
            this.flightTime = 330;
            this.origin = "Los Angeles, CA";
            this.destination = "New York, NY";
            this.maintenance = "Maintenance";
            this.firstClass = 25;
            this.schedule = "Departure Time : 1:00PM | Arrival Time : 6:30PM ";
        }

        public override string ToString()
        {
            return "Flight : " + flightNum + Environment.NewLine + "Capacity/First Class Seats : " + seat + " passengers" + "/ " + firstClass + " seats" + Environment.NewLine + "Range: " + range + " miles" + Environment.NewLine + "Flight Time : " + flightTime + " minutes" + Environment.NewLine + "From " + origin + " TO " + destination + Environment.NewLine + maintenance + ": Passed" + Environment.NewLine + schedule;
        }
    }
}
