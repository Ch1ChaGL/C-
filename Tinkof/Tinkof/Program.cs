using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tinkof
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                    if (sum == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}




//1
//bool isIncrease(int[] arr)
//{
//    for (int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] < arr[i - 1])
//        {
//            return false;
//        }
//    }
//    return true;
//}
//bool isDecrease(int[] arr)
//{
//    for (int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] > arr[i - 1])
//        {
//            return false;
//        }
//    }
//    return true;
//}
//string[] input = Console.ReadLine().Split(' ');
//int[] numbers = Array.ConvertAll(input, int.Parse);


//if(isIncrease(numbers) || isDecrease(numbers))
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}


//2
//int countCheck(int num1, int num2)
//{
//    return num1 * num2;
//}

//double totalTime(int num1, int num2)
//{
//    return (double)num1 / num2;
//}


//string[] input = Console.ReadLine().Split(' ');
//int[] numbers = Array.ConvertAll(input, int.Parse);

//int countCh = countCheck(numbers[0], numbers[2]);
//double timeTl = totalTime(countCh, numbers[1]);

//Console.WriteLine(Math.Ceiling(timeTl));

//Console.ReadKey();


//3
//bool allContains(string str)
//{
//    return str.Contains('a') && str.Contains('b') &&
//        str.Contains('c') && str.Contains('d');
//}

//int stringLength = int.Parse(Console.ReadLine());
//string isString = Console.ReadLine();

//if (allContains(isString))
//{
//    int minLength = stringLength;
//    for (int i = 0; i < stringLength; i++)
//    {
//        for (int j = 0; j < stringLength - i; j++)
//        {
//            string subStr = isString.Substring(i, j);
//            if (allContains(subStr))
//            {
//                minLength = Math.Min(minLength, subStr.Length);
//            }
//        }
//    }
//    Console.WriteLine(minLength);
//}
//else
//{
//    Console.WriteLine(-1);
//}
//Console.ReadKey();


//4
//static void Main(string[] args)
//{
//    int length = int.Parse(Console.ReadLine());
//    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//    // Создаем словарь, где ключ - число, значение - количество вхождений
//    var freq = new Dictionary<int, int>();
//    foreach (int x in numbers)
//    {
//        if (!freq.ContainsKey(x))
//        {
//            freq[x] = 0;
//        }
//        freq[x]++;
//    }



//    // Сортируем массив по возрастанию
//    Array.Sort(numbers);

//    int maxLen = length;
//    int len = length;

//    for (int i = length - 1; i >= 0; i--)
//    {
//        // Уменьшаем количество вхождений последнего элемента
//        freq[numbers[i]]--;

//        // Удаляем ключ из словаря, если значение равно 0
//        if (freq[numbers[i]] == 0)
//        {
//            freq.Remove(numbers[i]);
//        }

//        // Проверяем, что количество вхождений всех чисел одинаково
//        bool isBoring = freq.Values.All(x => x == freq.Values.First());

//        // Если количество вхождений всех чисел одинаково,
//        // обновляем максимальную длину префикса и выходим из цикла
//        if (isBoring)
//        {
//            maxLen = len;
//            break;
//        }
//        else
//        {
//            // Иначе уменьшаем длину префикса
//            len--;
//        }
//    }

//    Console.WriteLine(maxLen);
//    Console.ReadKey();
//}