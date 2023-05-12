using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Задание_13Вариант
{
    public class Flights
    {
        public int FlightID { get; set; }
        public int PlaneID { get; set; }

        public int DestinationPortId { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public double FlightDuration { get; set; }

        public int FlightFrequencyId { get; set; }


        public Flights(int flightId, int planeId, int DestinationPortId, DateTime DepartureTime, DateTime ArrivalTime, double FlightDuration, int FlightFrequency)
        {
            FlightID = flightId;
            PlaneID = planeId;
            this.DestinationPortId = DestinationPortId;
            this.DepartureTime = DepartureTime;
            this.ArrivalTime = ArrivalTime;
            this.FlightFrequencyId = FlightFrequency;
            this.FlightDuration = FlightDuration;
        }
    }
}
