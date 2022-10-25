using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП5
{
    internal class Program
    {
        static List<Entity> entities = new List<Entity>();

        static void Main(string[] args)
        {
            Demon standart = new Demon("Стандарт", 0, 0, 0);
            entities.Add(standart);
            for (; ; ) {   
                Console.WriteLine("1.Создать игрока \n2.Создать себя \n3.Начать игру \n4.Выйти из игры");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите имя");
                            string UserName = Console.ReadLine();
                            Console.WriteLine("Выберите рассу: 1.Демон 2.Монстр");
                            int answer2 = int.Parse(Console.ReadLine());
                            if (answer2 == 1)
                            {
                                Random rnd = new Random();
                                Demon user = new Demon(UserName, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                                entities.Add(user);
                            }
                            if (answer2 == 2)
                            {
                                Random rnd = new Random();
                                Monster user = new Monster(UserName, rnd.Next(1, 100), rnd.Next(1, 100));
                                entities.Add(user);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите имя");
                            string UserName = Console.ReadLine();
                            Console.WriteLine("Выберите рассу: 1.Демон 2.Монстр");
                            int answer2 = int.Parse(Console.ReadLine());
                            if (answer2 == 1)
                            {
                                Random rnd = new Random();
                                Demon user = new Demon(UserName, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                                entities.RemoveAt(0);
                                entities.Insert(0, user);
                            }
                            if (answer2 == 2)
                            {
                                Random rnd = new Random();
                                Monster user = new Monster(UserName, rnd.Next(1, 100), rnd.Next(1, 100));
                                entities.RemoveAt(0);
                                entities.Insert(0, user);
                            }
                            break;
                        }
                    case 3:
                        {
                            int count = 0;

                            //for(int i = 0; i < answer3; i++)
                            //{
                            //    if (answer3 % 2 == 0)
                            //    {
                            //        Random rnd = new Random();
                            //        Demon user = new Demon("Demon" +i, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
                            //        entities.Add(user);
                            //    }
                            //    else
                            //    {
                            //        Random rnd = new Random();
                            //        Monster user = new Monster("Monster" + i, rnd.Next(0, 100), rnd.Next(0, 100));
                            //        entities.Add(user);
                            //    }
                            //}
                            for (int i = 0; i < entities.Count; i++)
                            {
                               
                                
                                if (i == 0)
                                {
                                    if (entities[0] == standart)
                                    {
                                        Console.WriteLine("Вы не создали своего персонажа");
                                        break;
                                    }
                                    else if (entities.Count == 1)
                                    {
                                        Console.WriteLine("Противники не созданы");
                                        break;
                                    }
                                    continue;
                                }
                                count++;
                                 Console.WriteLine("Бой номер " + count);
                                entities[0].Attac(entities[i]);
                                if (entities[0].GetHealth() <= 0)
                                {
                                    entities[0].Show();
                                    entities.Clear();
                                    entities.Add(standart);
                                    break;
                                }
                                if (entities[i].GetHealth() <= 0)
                                {
                                    Console.WriteLine("Противник убит");
                                    entities[0].Show();
                                    entities.RemoveAt(i);
                                    i--;
                                }
                            }
                            break;
                        }
                    case 4: { return; }

                }
                    //        Demon Danya = new Demon("Danil", 100, 200, 50);
                    //Monster Andrey = new Monster("Andrey", 100, 200);
                    //Danya.Show();
                    //Console.WriteLine("----------------------------------");
                    //Andrey.Show();
                    //Console.WriteLine("----------------------------------");
                    //Andrey.Attac(Danya);
                    //Console.WriteLine("----------------------------------");
                    //Danya.Show();
                    //Console.WriteLine("----------------------------------");
                    //Andrey.Show();
                 
            }
            Console.ReadKey();
        }
    }
}