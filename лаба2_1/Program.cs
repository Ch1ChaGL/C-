using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить в одномерном числовом массиве наибольшее количество последовательно расположенных положительных элементов и окрасить их при выводе бирюзовым цветом. 
            int[] MyArray = new int[10];
            int count = 0;
            int max = 0;
            int start = 0;
            int end = 0;
            int[] MyArray2 = new int[10];
            for (int i= 0; i<MyArray.Length; i++)
            {
                MyArray[i] = int.Parse(Console.ReadLine());             //Заполнение массива
            }
            for(int i = 0; i<MyArray.Length; i++)
            {
                Console.ResetColor();
                if (MyArray[i] > 0)
                {                    
                    count++;                                                //Cчетчик положительных чисел
                }
                else
                {
                
                    if (count > max)
                    {
                                
                        end = i-1;                                          /* Так как при вычислении начала и конца наибольшего отрезка положительных чисел мы используем вычитание,
                                                                             * то появляются ошибки, потому что счет в массиве начинается с 0, поэтому мы намеренно вычитаем из конечного номера наибольшего числа единицу
                                                                             чтобы при выводе на экран, последняя цифра была под своим номером в массиве*/
                        start = (end - count)+1;
                        max = count;
                        /*if ((end - count)+1 == 0)
                        {
                            start = 0;
                        }*/
                        count = 0;
                       
                    }
                }
                if((i == MyArray.Length-1) && count > max)
                {
                                                                            /*Так как решение задачи у нас завязано, на нахождении наиболее длинного количества положительных чисел, то при отрицательном, 
                                                                             * счетчик сбрасывается, как видно выше, но если окажется, что до конца массива не будет отрицательных чисел,то счетчик сбросится, поэтому
                                                                             мы принудительно говорим, что в конце массива нужно проверить счетчик*/
                    end = i;
                    start = (end - count)+1;
                    max = count;
                    /*if (end - count == 0)
                    {
                        start = 0;
                    }*/
                    count = 0;
                }
            }
            for(int i = 0; i<MyArray.Length; i++)
            {
               
                if (i != start)
                {
                    Console.Write(MyArray[i]+"\t");                             //Если элемент массива не старт, то мы выводим его обычным цветом
                }
                if (i == start)                                                  /*Если элемент массива старт, то мы выводим и окрашеваем элементы, попутно увеличивая значение i, так как наш for
                                                                                  находится в одной области видимости с другим for, то инициализировать i мы не можем, используем j*/
                {
                    
                        for (int j = start; j <= end; j++, i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(MyArray[i] + "\t");
                            Console.ResetColor();

                        }
                    i--;                                                        /*так как при последней выполненной итерации мы все равно возвращаемся в for, и еще раз увеличиваем i,
                                                                                 * то это сбивает нам вывод, поэтому мы специально уменьшаем i на 1, чтобы вывод продолжался в правильном порядке*/
                      
                        
                    


                }
               
            }
            Console.ReadKey();









        }
    }
}
