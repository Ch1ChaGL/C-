using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5_Задание_13Вариант
{
    public class City
    {
        public string Name;
        public int countRegion = 0;
        public List<District> region  { get; private set; } = new List<District>();

        public City(string Name) { this.Name = Name; }
        public City(string Name, int countRegion) 
        {
            this.Name = Name;
            this.countRegion = countRegion;
        }
        /// <summary>
        /// Конструктор Города, с известным списком районов сразу
        /// </summary>
        /// <param name="Name">Название города</param>
        /// <param name="countRegion"> Количество районов </param>
        /// <param name="reigons"> Список Районов </param>
        public City(string Name, int countRegion, List<District> reigons) 
        {
            this.Name = Name;
            this.countRegion = countRegion;
            region = reigons;
        }

        /// <summary>
        /// Добавление района в Город
        /// </summary>
        /// <param name="Name">Название района</param>
        /// <param name="Area">Площадь района</param>
        /// <param name="countPeople">Количество людей</param>
        public void AddRegion (string Name, double Area, int countPeople) 
        {
            region.Add(new District(Name, Area, countPeople)); 
            countRegion++;
        }
        /// <summary>
        ///Удаление района 
        /// </summary>
        /// <param name="Name"> Название района </param>
        /// <exception cref="Exception"> Отстутвие района </exception>
        public void RemoveRegion (string Name)
        {
            for (int i = 0; i < region.Count; i++)
            {
                if (region[i].Name == Name) { region.RemoveAt(i);  countRegion--; return; }
            }
            throw new Exception("Район в данном городе отсутсвует");
        }

        public void addinformation(string districtName, int countPeople, double area) 
        {
            for (int i = 0; i < region.Count; i++)
            {
                if (region[i].Name == districtName) { region[i].AddAreaAndPopulation(area, countPeople); return; }
            }
            region.Add(new District(districtName, area, countPeople));
            countRegion++;
        }

        /// <summary>
        /// Сериализация города
        /// </summary>
        /// <returns></returns>
        public string GetInformationAboutCity()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Название города: " + Name);

            stringBuilder.AppendLine("Количество районов: " + countRegion);
            stringBuilder.AppendLine();

            foreach (var district in region)
            {
                stringBuilder.AppendLine("Название района: " + district.Name);
                stringBuilder.AppendLine("Площадь района: " + district.Area);
                stringBuilder.AppendLine("Количество людей: " + district.countPeople);
                stringBuilder.AppendLine("Плотность населения: " + district.PopulationDensity);

                stringBuilder.AppendLine();
            }

            stringBuilder.AppendLine("____________________");

            return stringBuilder.ToString();
        }
    }
}
