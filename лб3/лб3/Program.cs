using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лб3
{
    enum ViewGame
    {
        MMORPG,
        Sport,
        Races,                  //Жанр игр в виде перечисления 
        Shooter,
        Strategies
    }
    struct Game
    {
        public string NameGame;                 //Структура игр содержит имя, жанр игры, объем игры, и частоту процессора
        public ViewGame View;
        public double Volume;
        public double ProcessorFrequency;

    }

    class Program
    {
      static List<Game> games = new List<Game>();               //Список игр
         static void Add_To_List()                  //Функция создания игры
        {
            int choice;                             //Переменная для выбора жанра игры
            Game a = new Game();
            Console.WriteLine("Введите название");
            a.NameGame=Console.ReadLine();
            Console.WriteLine("Объем требуемой памяти");
            a.Volume= double.Parse(Console.ReadLine());
            Console.WriteLine("Введите частоту процессора");
            a.ProcessorFrequency=double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите жанр игры:\n 1.MMORPG \n 2.Sport \n 3.Races \n 4.shooter \n 5.Strategies");         //Выбор жанра игры
            choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        a.View=ViewGame.MMORPG;
                        break;
                    }
                case 2:
                    {
                        a.View = ViewGame.Sport;
                        break;
                    }
                case 3:
                    {
                        a.View = ViewGame.Races;
                        break;
                    }
                case 4:
                    {
                        a.View = ViewGame.Shooter;
                        break;
                    }
                case 5:
                    {
                        a.View = ViewGame.Strategies;
                        break;
                    }

            }
            games.Add(a);               //Добавление игры в список игр

        }
         static void Show_list()  
            //Функция вывода списка игр
        {
            for(int i = 0; i < games.Count; i++)
            {
                Console.WriteLine("Название: " + games[i].NameGame);
                Console.WriteLine("Жанр: " + games[i].View);
                Console.WriteLine("Объем памяти: " + games[i].Volume);
                Console.WriteLine("Частота процессора: " + games[i].ProcessorFrequency);
                Console.WriteLine("--------------------------------------------------");
            }
        }
         static void Show_View()
        {
            int a;
            ViewGame choice = new ViewGame();
            int count = 0;
            Console.WriteLine("Выберите жанр игры для поиска:\n 1.MMORPG \n 2.Sport \n 3.Races \n 4.shooter \n 5.Strategies");          //Выбор жанра для поиска
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        choice = ViewGame.MMORPG;
                        break;
                    }
                case 2:
                    {
                        choice = ViewGame.Sport;
                        break;
                    }
                case 3:
                    {
                        choice = ViewGame.Races;
                        break;
                    }
                case 4:
                    {
                        choice = ViewGame.Shooter;
                        break;
                    }
                case 5:
                    {
                        choice = ViewGame.Strategies;
                        break;
                    }
            }
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].View == choice)                //Вывод жанра 
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Название: " + games[i].NameGame);
                    Console.WriteLine("Жанр: " + games[i].View);
                    Console.WriteLine("Объем памяти: " + games[i].Volume);
                    Console.WriteLine("Частота процессора: " + games[i].ProcessorFrequency);
                    Console.WriteLine("--------------------------------------------------");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Таких игр нет");
            }
        }
         static void Show_Main()
         {
            int b, c;
            int count = 0;
            Console.WriteLine("Введите объем");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите частоту");
            c = int.Parse(Console.ReadLine());
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].Volume == b && games[i].ProcessorFrequency == c)       //Выыод по объему и частоте 
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Название: " + games[i].NameGame);
                    Console.WriteLine("Жанр: " + games[i].View);
                    Console.WriteLine("Объем памяти: " + games[i].Volume);
                    Console.WriteLine("Частота процессора: " + games[i].ProcessorFrequency);
                    Console.WriteLine("--------------------------------------------------");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Таких игр нет");
            }
        }
        static void Main(string[] args)
        {
            int a,b,c,d;
            ViewGame choice = new ViewGame();
            for (; ; )          //Бесконечный цикл для меню
            {
                Console.WriteLine("1.Записать игру\n2.Показать список игр\n3.Поиск по жанру\n4.Поиск по объему и частоте\n5.Выход");        //Выбор в меню
                d = int.Parse(Console.ReadLine());
                switch (d)
                {
                    case 1:
                        {
                            Add_To_List();
                            break;

                        }
                    case 2:
                        {
                            Show_list();
                            break;
                        }
                    case 3:
                        {
                            Show_View();
                            //int count = 0;
                            //Console.WriteLine("Выберите жанр игры для поиска:\n 1.MMORPG \n 2.Sport \n 3.Races \n 4.shooter \n 5.Strategies");          //Выбор жанра для поиска
                            //a = int.Parse(Console.ReadLine());
                            //switch (a)
                            //{
                            //    case 1:
                            //        {
                            //            choice = ViewGame.MMORPG;
                            //            break;
                            //        }
                            //    case 2:
                            //        {
                            //            choice = ViewGame.Sport;
                            //            break;
                            //        }
                            //    case 3:
                            //        {
                            //            choice = ViewGame.Races;
                            //            break;
                            //        }
                            //    case 4:
                            //        {
                            //            choice = ViewGame.Shooter;
                            //            break;
                            //        }
                            //    case 5:
                            //        {
                            //            choice = ViewGame.Strategies;
                            //            break;
                            //        }
                            //}
                            //for (int i = 0; i < games.Count; i++)
                            //{
                            //    if (games[i].View == choice)                //Вывод жанра 
                            //    {
                            //        Console.WriteLine("--------------------------------------------------");
                            //        Console.WriteLine("Название: " + games[i].NameGame);
                            //        Console.WriteLine("Жанр: " + games[i].View);
                            //        Console.WriteLine("Объем памяти: " + games[i].Volume);
                            //        Console.WriteLine("Частота процессора: " + games[i].ProcessorFrequency);
                            //        Console.WriteLine("--------------------------------------------------");
                            //        count++;
                            //    }   
                            //}
                            //if (count == 0)
                            //{
                            //    Console.WriteLine("Таких игр нет");     
                            //}
                            break;
                        }
                    case 4:
                        {
                            Show_Main();
                            //int count = 0;
                            //Console.WriteLine("Введите объем");
                            //b = int.Parse(Console.ReadLine());
                            //Console.WriteLine("Введите частоту");
                            //c = int.Parse(Console.ReadLine());
                            //for (int i = 0; i < games.Count; i++)
                            //{
                            //    if (games[i].Volume == b && games[i].ProcessorFrequency == c)       //Выыод по объему и частоте 
                            //    {
                            //        Console.WriteLine("--------------------------------------------------");
                            //        Console.WriteLine("Название: " + games[i].NameGame);
                            //        Console.WriteLine("Жанр: " + games[i].View);
                            //        Console.WriteLine("Объем памяти: " + games[i].Volume);
                            //        Console.WriteLine("Частота процессора: " + games[i].ProcessorFrequency);
                            //        Console.WriteLine("--------------------------------------------------");
                            //        count++;
                            //    }                             
                            //}
                            //if (count == 0)
                            //{                               
                            //        Console.WriteLine("Таких игр нет");                              
                            //}
                            break;
                        }
                    case 5:
                        {
                            return;
                        }
                }
            }
            //Add_To_List();
            //Add_To_List();
            //Add_To_List();
            //Show_list();

            //Console.WriteLine("Выберите жанр игры для поиска:\n 1.MMORPG \n 2.Sport \n 3.Races \n 4.shooter \n 5.Strategies");
            //a =int.Parse(Console.ReadLine());
            //switch (a)
            //{
            //    case 1:
            //        {
            //            choice = ViewGame.MMORPG;
            //            break;
            //        }
            //    case 2:
            //        {
            //            choice = ViewGame.Sport;
            //            break;
            //        }
            //    case 3:
            //        {
            //            choice = ViewGame.Races;
            //            break;
            //        }
            //    case 4:
            //        {
            //            choice = ViewGame.Shooter;
            //            break;
            //        }
            //    case 5:
            //        {
            //            choice = ViewGame.Strategies;
            //            break;
            //        }
            //}
            //for(int i = 0; i < games.Count; i++)
            //{
            //    if (games[i].View == choice)
            //    {
            //        Console.WriteLine("--------------------------------------------------");
            //        Console.WriteLine("Название: " + games[i].NameGame);
            //        Console.WriteLine("Жанр: " + games[i].View);
            //        Console.WriteLine("Объем памяти: " + games[i].Volume);
            //        Console.WriteLine("Частота процессора: " + games[i].ProcessorFrequency);
            //        Console.WriteLine("--------------------------------------------------");
            //    }
            //}
            //Console.WriteLine("Введите объем");
            //b=int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите частоту");
            //c=int.Parse(Console.ReadLine());
            //for(int i = 0; i < games.Count; i++)
            //{
            //    if (games[i].Volume==b && games[i].ProcessorFrequency == c)
            //    {
            //        Console.WriteLine("--------------------------------------------------");
            //        Console.WriteLine("Название: " + games[i].NameGame);
            //        Console.WriteLine("Жанр: " + games[i].View);
            //        Console.WriteLine("Объем памяти: " + games[i].Volume);
            //        Console.WriteLine("Частота процессора: " + games[i].ProcessorFrequency);
            //        Console.WriteLine("--------------------------------------------------");
            //    }
            //}

            Console.ReadKey();
        }
    }



}
