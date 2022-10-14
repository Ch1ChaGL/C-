using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace задание222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int size= 4; 
            int [] Massiv = new int[size]; 
            for (int i= 0; i < Massiv.Length; i++)
            {                                                               // Ввод данных
                Console.WriteLine("Введите " + (i+1) + " число");
                Massiv[i] = int.Parse(Console.ReadLine());
            }
            if (true)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();                                            //Окрашевание фона
            }
            for (int i=0; i<Massiv.Length;i++)
            {
                if (Massiv[i] < 100 || Massiv[i] >= 1000)
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition((Console.WindowWidth / 3) + 5, Console.WindowHeight / 2 + i);
                    Console.WriteLine("Число: " + Massiv[i] + " Не подходит по заданию");                       //Проверка данных
                }
                if ((Massiv[i]<1000) && (Massiv[i] >= 100))
                {
                    if (Massiv[i] % 5 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition((Console.WindowWidth / 3) + 5, Console.WindowHeight / 2 + i);
                        Console.WriteLine("Число: " + Massiv[i] + " кратно 5");                                         //Выполнение для кратных 5
                    }
                    if (Massiv[i] % 3 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition((Console.WindowWidth / 3) + 5, Console.WindowHeight / 2 + i);
                        Console.WriteLine("Число: " + Massiv[i] + " кратно 3");                                         //Выполнение для кратных 3
                    }
                }
                    if (Massiv[i] % 5 == 0 && Massiv[i] % 3 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition((Console.WindowWidth / 3)+5, Console.WindowHeight / 2+i);
                        Console.WriteLine("Число: " + Massiv[i] + " кратно 5 и кратно 3");                               //Выполнение для кратных 5 и 3
                }
            }
                    if (Massiv[i]%5!=0 && Massiv[i]%3!=0)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition((Console.WindowWidth / 3) + 5, Console.WindowHeight / 2 + i);
                        Console.WriteLine("Число: " + Massiv[i] + " не кратно 3 и не кратно 5");                            //Выполнение для не кратных 5 и не кратных 3
                    }
                }
            }          
            Console.ReadKey();
        }
     
    }
}
