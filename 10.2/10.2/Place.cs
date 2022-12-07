using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10._2
{
    internal class Place
    {
        string _name;
        double _countPeople;
        int _countCrime;
        public double _procent { get; private set; }
        public Place(string name, double countPeople, int countCrime)
        {
            _name = name;
            _countPeople = countPeople;
            _countCrime = countCrime;
            _procent = Math.Round((countCrime / countPeople) * 100, 2);
        }
        public override string ToString()
        {
            return $"Name of the region: { _name}, Number of people: { _countPeople}, Number of crimes: { _countCrime}, Percent: { _procent}%\n";
        }

    }
}
