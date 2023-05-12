using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Задание_13Вариант
{
    public class SQLstring
    {
        public static string getAll = "SELECT F.FlightID,  F.PlaneID, P.NumberOfSeats, PT.PlaneTypeName, Po.DestinationPortName, F.DepartureTime,   F.ArrivalTime,   F.FlightDuration,   FF.FlightFrequency FROM    Flights F JOIN FlightFrequency FF ON F.FlightFrequencyId = FF.FlightFrequencyId JOIN Planes P ON F.PlaneID = P.PlaneID JOIN PlaneTypes PT ON P.PlaneTypeID = PT.PlaneTypeID  JOIN Ports Po ON F.DestinationPortID = Po.DestinationPortID";
        public static string GetInfoQueryPlaneTypes = "select PlaneTypeID, PlaneTypeName from PlaneTypes";
        public static string GetNameFlightFrequency = "select * from FlightFrequency";
        public static string GetImageTypeAirplane(int id)
        {
            return $"select PT.PlaneImage from Flights F join Planes P on F.PlaneID = P.PlaneID join PlaneTypes PT on P.PlaneTypeID = PT.PlaneTypeID where FlightID = {id}";
        }
    }
}
