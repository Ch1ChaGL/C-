using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Задание_13Вариант
{
    public class FlightFrequency
    {
        public int FlightFrequencyId { get; set; }
        public string flightFrequency { get; set; }

        public FlightFrequency(int id, string name) 
        {
            FlightFrequencyId = id;

            flightFrequency = name;
        }

       
    }
}
