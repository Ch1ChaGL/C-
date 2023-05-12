using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Задание_13Вариант
{
    public class PlaneTypes
    {
        public int PlaneTypeID {  get; set; }
        public string PlaneTypeName { get; set; }
        public string PlaneImage { get; set; }


        public PlaneTypes(int planeTypeID, string planeTypeName, string planeImage)
        {
            PlaneTypeID = planeTypeID;
            PlaneTypeName = planeTypeName;
            PlaneImage = planeImage;
        }


        
    }
}
