using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ВАРИАНТ 13

//Задача 1
//Разработать программу, использующую функцию программиста с передачей результата. Функция должна вычислять наибольший общий делитель (НОД) двух натуральных чисел, переданных ей в качестве параметров.

//Задача 2
//	Заданы два одномерных массива разной размерности. Организовать ввод и вывод на экран массивов с использованием функций программиста.
//	Найти сумму нечетных по значению элементов каждого массива, используя функцию программиста.
//	В том массиве, где эта сумма больше всего, поменять местами максимальный и минимальный элемент массива. Обмен осуществить при помощи функции.

namespace лб4
{   
     
    internal class Program
    {
        

        static double NOD(out double GCD)
        {
            double a, b;
            Console.WriteLine("Введите два числа для нахождения НОД");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            try
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {
                        a = a % b;
                    }
                    else
                    {
                        b = b % a;
                    }
                }
                GCD = a + b;
                return 1;
            }catch(Exception)
            {
                GCD = 0;
                return -1;
            }


        } //Задание 1
        static double MyArray(ref double result,params double[] Arr1)
        {   double sum=0;
            //Random rnd = new Random();
            for(int i = 0; i < Arr1.Length; i++)
            {
                Console.WriteLine("Введите элемент массива");
                Arr1[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            for(int i = 0; i < Arr1.Length; i++)
            {
                Console.WriteLine(Arr1[i] +"\t");
                if (Arr1[i] % 2 != 0)
                {
                    sum = sum + Arr1[i];
                }
            }
            result = sum;
            return 0;
        }
        static void change(params double[] Arr1)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i=0; i < Arr1.Length; i++)
            {
                if (Arr1[i] > max)
                {
                    max = Arr1[i];
                   
                }
                if (Arr1[i] < min)
                {
                    min = Arr1[i];
                   
                }
            }     
            for (int i = 0; i < Arr1.Length; i++)
            {
                if (Arr1[i] == min)
                {
                    Arr1[i] = max;
                }
                else if(Arr1[i] == max)
                {
                    Arr1[i] = min;
                }
                
            }
            for (int i = 0; i < Arr1.Length; i++)
            {
                Console.WriteLine(Arr1[i]+"\t");
            }


        }
        static void Main(string[] args)
        {
           
            double answer1=0,answer2=0;
            double[] MyArr1 = new double[4];
            double[] MyArr2 = new double[6];
            double Num1, Num2,ans;
            try
            {           
                NOD(out ans);
                Console.WriteLine("НОД чисeл  = " + ans);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            MyArray(ref answer1,MyArr1);
            MyArray(ref answer2,MyArr2);
            Console.WriteLine("Сумма нечетных чисел 1 массива = "+answer1);
            Console.WriteLine("Сумма нечетных чисел 2 массива = " + answer2);
            if (answer1 > answer2)
            {
                change(MyArr1);
            }
            else
            {
                change(MyArr2);
            }

            Console.ReadKey();
        }
    }
}
