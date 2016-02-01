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
        public MediumPlaneSW(int flightNum, int seat, int range, int flightTime, string origin, bool maintenance) : base(flightNum, seat, range, flightTime, origin, maintenance)
        {
            this.flightNum = flightNum;
            this.seat = seat;
            this.range = range;
            this.flightTime = flightTime;
            this.origin = origin;
            this.maintenance = maintenance;
        }
    }
}
