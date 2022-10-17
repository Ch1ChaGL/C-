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
        

        static int NOD(int a,int b)
        {
            //double a, b;
            //Console.WriteLine("Введите два числа для нахождения НОД");
            //a = double.Parse(Console.ReadLine());
            //b = double.Parse(Console.ReadLine());
            try
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)                                  //Функция нахождения нод
                    {
                        a = a % b;
                    }
                    else
                    {
                        b = b % a;
                    }
                }
                return  a + b;
               
            }catch(Exception)
            {
                
                return 0;
              
            }


        } //Задание 1
        static double MyArray(ref double result,params double[] Arr1)           //Функция ввода массива и присвоения максимального числа нечетных чисел 
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


        static double Fill_Array(params double[] Ar1)
        {   

            for(int i = 0; i < Ar1.Length; i++)
            {
                Ar1[i] = int.Parse(Console.ReadLine());
            }
            return 0;
        }
        static void Show_List(params double[] Ar1) {
            for(int i = 0; i < Ar1.Length; i++)
            {
                Console.Write(Ar1[i] + "\t");
            }
        }
        static double Max_odd(params double[] Ar1)
        {
            double sum = 0;
            for (int i = 0; i < Ar1.Length; i++)
            {
                Console.WriteLine(Ar1[i] + "\t");
                if (Ar1[i] % 2 != 0)
                {
                    sum = sum + Ar1[i];
                }
            }
            return sum;
        }


        static void change(params double[] Arr1)                        //Функция присвоения минимальному числу максимального и наоборот
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
        }
        static void Main(string[] args)
        {
           
            int num1, num2;
            double[] MyArr1 = new double[4];
            double[] MyArr2 = new double[6];
            
            double ans;
            try
            {
                Console.WriteLine("Введите 1 число");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 2 число");
                num2 = int.Parse(Console.ReadLine());              
                Console.WriteLine("НОД чисeл  = " + NOD(num1, num2));
            }catch(Exception ex)
            {                                       
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Введите 1 массив");
            Fill_Array(MyArr1);
            Console.WriteLine("Введите 2 массив");
            Fill_Array(MyArr2);
            //MyArray(ref answer1,MyArr1);
            //MyArray(ref answer2,MyArr2);
            //Console.WriteLine("Сумма нечетных чисел 1 массива = "+answer1);
            //Console.WriteLine("Сумма нечетных чисел 2 массива = " + answer2);
            if (Max_odd(MyArr1) > Max_odd(MyArr2))  // Проверка максимального количества нечетных
            {
                change(MyArr1);
                Show_List(MyArr1);
            }
            else
            {
                change(MyArr2);
                Show_List(MyArr2);
            }

           



            Console.ReadKey();
        }
    }
}



