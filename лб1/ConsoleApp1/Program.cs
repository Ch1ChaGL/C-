using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double volumeCone;              //Объем конуса
            double volumeCylinder;          //Объем цилиндра
            const double PI = 3.14159;      //число пи
            double r;                       //радиус
            double h;                       //высота
            Console.Write(" Введите радиус = ");
            r = double.Parse(Console.ReadLine());
            Console.Write(" Введите высоту = ");
            h = double.Parse(Console.ReadLine());
            if (h > 0 && r > 0)
            {                 //Проверка на введенные данные
                volumeCylinder = PI * r * r * h;
                Console.WriteLine(" Объем цилиндра = " + volumeCylinder);
                volumeCone = (PI * r * r * h) / 3;
                Console.WriteLine(" Объем конуса = " + volumeCone);
            }
            else { Console.WriteLine("Неверные данные"); }
            Console.ReadKey();

        }
    }
}
  
          

 