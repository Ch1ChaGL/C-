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
        public static string getAll = "SELECT F.FlightID,  F.PlaneID, PT.NumberOfSeats, PT.PlaneTypeName, Po.DestinationPortName, F.DepartureTime,   F.ArrivalTime,   F.FlightDuration,   FF.FlightFrequency FROM    Flights F JOIN FlightFrequency FF ON F.FlightFrequencyId = FF.FlightFrequencyId JOIN Planes P ON F.PlaneID = P.PlaneID JOIN PlaneTypes PT ON P.PlaneTypeID = PT.PlaneTypeID  JOIN Ports Po ON F.DestinationPortID = Po.DestinationPortID";
        public static string GetInfoQueryPlaneTypes = "select PlaneTypeID, PlaneTypeName from PlaneTypes";
        public static string GetNameFlightFrequency = "select * from FlightFrequency";
        public static string GetImageTypeAirplane(int id)
        {
            return $"select PT.PlaneImage from Flights F join Planes P on F.PlaneID = P.PlaneID join PlaneTypes PT on P.PlaneTypeID = PT.PlaneTypeID where FlightID = {id}";
        }
        public static string GetImageType(int id)
        {
            return $"select PlaneImage from PlaneTypes where PlaneTypeID = {id}";
        }
        public static string GetNamePorts = "select * from Ports";

        public static string addFlight(int FlightID, int PlaneId, int PlaneTypeId,int DestinationPortId,DateTime DepartureDate,
            DateTime ArrivalDate, int FlightFrequencyId)
        {

            return $"exec AddFlightProcedure {FlightID}, {PlaneId}, {PlaneTypeId}, {DestinationPortId}, '{DepartureDate.ToString("yyyy-MM-dd HH:mm:ss")}', '{ArrivalDate.ToString("yyyy-MM-dd HH:mm:ss")}', {FlightFrequencyId}";
        }
        public static string updateFlight(int FlightId,int PlaneId, int PlaneTypeId,int DestinationPortId, DateTime DepartureDate, DateTime ArrivalDate, int FlightFrequencyId)
        {
            return $"exec UpdateFlight {FlightId}, {PlaneId}, {PlaneTypeId},{DestinationPortId}, '{DepartureDate.ToString("yyyy-MM-dd HH:mm:ss")}', '{ArrivalDate.ToString("yyyy-MM-dd HH:mm:ss")}', {FlightFrequencyId}";
        }
        public static string getAllOne(int id, int planeId, int destinationPortId, DateTime DepartureDate, DateTime ArrivalDate, int FlightFrequencyId)
        {
            return $"SELECT F.FlightID,  F.PlaneID, PT.NumberOfSeats, PT.PlaneTypeName, Po.DestinationPortName, F.DepartureTime,   F.ArrivalTime,   F.FlightDuration,   FF.FlightFrequency FROM    Flights F JOIN FlightFrequency FF ON F.FlightFrequencyId = FF.FlightFrequencyId JOIN Planes P ON F.PlaneID = P.PlaneID JOIN PlaneTypes PT ON P.PlaneTypeID = PT.PlaneTypeID  JOIN Ports Po ON F.DestinationPortID = Po.DestinationPortID where F.FlightID = {id} and F.PlaneID = {planeId} and F.DestinationPortID = {destinationPortId} and F.DepartureTime = '{DepartureDate.ToString("yyyy-MM-dd HH:mm:ss")}' and F.ArrivalTime = '{ArrivalDate.ToString("yyyy-MM-dd HH:mm:ss")}' and F.FlightFrequencyId = {FlightFrequencyId}";
        }
        public static string getAllTwo(int planeId, int destinationPortId, DateTime DepartureDate, DateTime ArrivalDate, int FlightFrequencyId)
        {
            return $"SELECT F.FlightID,  F.PlaneID, PT.NumberOfSeats, PT.PlaneTypeName, Po.DestinationPortName, F.DepartureTime,   F.ArrivalTime,   F.FlightDuration,   FF.FlightFrequency FROM    Flights F JOIN FlightFrequency FF ON F.FlightFrequencyId = FF.FlightFrequencyId JOIN Planes P ON F.PlaneID = P.PlaneID JOIN PlaneTypes PT ON P.PlaneTypeID = PT.PlaneTypeID  JOIN Ports Po ON F.DestinationPortID = Po.DestinationPortID where F.PlaneID = {planeId} and F.DestinationPortID = {destinationPortId} and F.DepartureTime = '{DepartureDate.ToString("yyyy-MM-dd HH:mm:ss")}' and F.ArrivalTime = '{ArrivalDate.ToString("yyyy-MM-dd HH:mm:ss")}' and F.FlightFrequencyId = {FlightFrequencyId}";
        }
        public static string getAllTrhee(int planeId)
        {
            return $"SELECT F.FlightID,  F.PlaneID, PT.NumberOfSeats, PT.PlaneTypeName, Po.DestinationPortName, F.DepartureTime,   " +
                $"F.ArrivalTime,   F.FlightDuration,   FF.FlightFrequency FROM    Flights F JOIN FlightFrequency FF " +
                $"ON F.FlightFrequencyId = FF.FlightFrequencyId JOIN Planes P ON F.PlaneID = P.PlaneID " +
                $"JOIN PlaneTypes PT ON P.PlaneTypeID = PT.PlaneTypeID  JOIN Ports Po ON F.DestinationPortID = Po.DestinationPortID where F.PlaneID = {planeId}";
        }
        public static string getAllFour(DateTime DepartureDate, DateTime ArrivalDate)
        {
            return $"SELECT F.FlightID,  F.PlaneID, PT.NumberOfSeats, PT.PlaneTypeName, Po.DestinationPortName, F.DepartureTime,   " +
                $"F.ArrivalTime,   F.FlightDuration,   FF.FlightFrequency FROM    Flights F JOIN FlightFrequency FF " +
                $"ON F.FlightFrequencyId = FF.FlightFrequencyId JOIN Planes P ON F.PlaneID = P.PlaneID " +
                $"JOIN PlaneTypes PT ON P.PlaneTypeID = PT.PlaneTypeID  JOIN Ports Po ON F.DestinationPortID = Po.DestinationPortID where F.DepartureTime = '{DepartureDate.ToString("yyyy-MM-dd HH:mm:ss")}' and F.ArrivalTime = '{ArrivalDate.ToString("yyyy-MM-dd HH:mm:ss")}'";
        }
        public static string getAllFive(DateTime DepartureDate)
        {
            return $"SELECT F.FlightID,  F.PlaneID, PT.NumberOfSeats, PT.PlaneTypeName, Po.DestinationPortName, F.DepartureTime,   " +
                $"F.ArrivalTime,   F.FlightDuration,   FF.FlightFrequency FROM    Flights F JOIN FlightFrequency FF " +
                $"ON F.FlightFrequencyId = FF.FlightFrequencyId JOIN Planes P ON F.PlaneID = P.PlaneID " +
                $"JOIN PlaneTypes PT ON P.PlaneTypeID = PT.PlaneTypeID  JOIN Ports Po ON F.DestinationPortID = Po.DestinationPortID where F.DepartureTime = '{DepartureDate.ToString("yyyy-MM-dd HH:mm:ss")}'";
        }
        public static string getAllSix(DateTime ArrivalDate)
        {
            return $"SELECT F.FlightID,  F.PlaneID, PT.NumberOfSeats, PT.PlaneTypeName, Po.DestinationPortName, F.DepartureTime,   " +
                $"F.ArrivalTime,   F.FlightDuration,   FF.FlightFrequency FROM    Flights F JOIN FlightFrequency FF " +
                $"ON F.FlightFrequencyId = FF.FlightFrequencyId JOIN Planes P ON F.PlaneID = P.PlaneID " +
                $"JOIN PlaneTypes PT ON P.PlaneTypeID = PT.PlaneTypeID  JOIN Ports Po ON F.DestinationPortID = Po.DestinationPortID where F.ArrivalTime = '{ArrivalDate.ToString("yyyy-MM-dd HH:mm:ss")}'";
        }
        public static string getAllSeven(int Flightid)
        {
            return $"SELECT F.FlightID,  F.PlaneID, PT.NumberOfSeats, PT.PlaneTypeName, Po.DestinationPortName, F.DepartureTime,   " +
                $"F.ArrivalTime,   F.FlightDuration,   FF.FlightFrequency FROM    Flights F JOIN FlightFrequency FF " +
                $"ON F.FlightFrequencyId = FF.FlightFrequencyId JOIN Planes P ON F.PlaneID = P.PlaneID " +
                $"JOIN PlaneTypes PT ON P.PlaneTypeID = PT.PlaneTypeID  JOIN Ports Po ON F.DestinationPortID = Po.DestinationPortID where F.FlightID = {Flightid}";
        }
    }
}
