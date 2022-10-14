using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace лб2_2
{
    //. Найти номер столбца двумерного массива с наименьшим количеством нечетных элементов и раскрасить этот столбец при выводе зеленым цветом.
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int width = 3;
            int min = width+1, count = 0, column = 0;
            int height = 3;
            int[,] arr = new int[height, width];
           
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            /*for (int i = 0; i < arr.GetLength(0); i++)
            {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
            Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
            }*/

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {

                    if (arr[i, j] % 2 != 0)
                    {
                        count++;

                    }
                }
                if (count < min)
                {
                    min = count;
                    count = 0;
                    column = j;
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (column == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(arr[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(arr[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }





            Console.ReadKey();
        }
    }
}