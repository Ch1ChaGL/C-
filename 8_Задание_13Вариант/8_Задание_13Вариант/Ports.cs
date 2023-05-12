using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Задание_13Вариант
{
    public class Ports
    {
        public int DestinationPortID { get; set; }
        public string DestinationPortName { get; set; }

        public Ports(int DestinationPortID, string DestinationPortName)
        {
            this.DestinationPortID = DestinationPortID;
            this.DestinationPortName = DestinationPortName;
        }
    }
}
