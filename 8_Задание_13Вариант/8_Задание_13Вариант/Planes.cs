using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Задание_13Вариант
{
    public class Planes
    {
        public int PlaneId { get; set; }
        public int PlaneTypeID { get; set; }
        public int NumberOfSeats { get; set; }


        public Planes(int PlaneId, int PlaneTypeID, int NumberOfSeats)
        {
            this.PlaneId = PlaneId;
            this.PlaneTypeID = PlaneTypeID;
            this.NumberOfSeats = NumberOfSeats;
        }


    }
}
