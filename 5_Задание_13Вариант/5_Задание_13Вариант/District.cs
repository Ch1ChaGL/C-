using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Задание_13Вариант
{
    public class District
    {
        public string Name;
        /// <summary>
        /// В километрах квадратных
        /// </summary>
        public double Area;
        public int countPeople;
        public double PopulationDensity;

        public District ( string Name ) 
        {
            this.Name = Name;
        }

        public District(string name, double area, int countPeople) 
        {
            Name = name;
            Area = area;
            this.countPeople = countPeople;

            PopulationDensity = countPeople / area;
        }

        public void AddAreaAndPopulation( double Area, int countPeople ) 
        {
            this.Area = Area;
            this.countPeople = countPeople;


            PopulationDensity = countPeople / Area;
        }


    }
}
