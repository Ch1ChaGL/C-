using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ5
{
    class Program
    {


        static List<Library> _librarys = new List<Library>();
        static void Add_To_Library()
        {
            string name;
            string adress;
            Console.WriteLine("Введите название");
            name = Console.ReadLine();
            Console.WriteLine("Введите адресс");
            adress = Console.ReadLine();
            Library library = new Library(name, adress);
            _librarys.Add(library);
        }
        static void Show_Library()
        {
            for (int i = 0; i < _librarys.Count; i++)
            {
                _librarys[i].Show_Library();
            }
        }
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("1.Добавьте Библиотеку\n2.Выберите Библиотеку\n3.Выйти");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        {   
                            Add_To_Library();
                            break;
                        }
                    case 2:
                        {
                            for (int i = 0; i < _librarys.Count; i++)
                            {
                                Console.WriteLine("Библиотека номер: "+(i + 1));
                                _librarys[i].Show_Library();
                            }
                            int answer2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("1.Добавьте книгу\n2.Удалите Книгу\n3.Показать список книг");
                            int answer3 = int.Parse(Console.ReadLine());
                            for(; ; ) {
                                switch (answer3)
                                {
                                    case 1:
                                        {
                                            string source="";
                                            int sourceanswer;
                                            string nameBook;
                                            int years;
                                            int invwntoryNumber;
                                            Console.WriteLine("Введите название книги: ");
                                            nameBook = Console.ReadLine();
                                            Console.WriteLine("Введите имя : ");
                                            string firstName = Console.ReadLine();
                                            Console.WriteLine("Введите Фамилию : ");
                                            string lastName = Console.ReadLine();
                                            Console.WriteLine("Введите Отчечство : ");
                                            string secondName = Console.ReadLine();
                                            Console.WriteLine("Введите год выпуска : ");
                                            years = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Введите инвентарный номер книги : ");
                                            invwntoryNumber = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Выберите категорию : 1.fantasy\n2.detectives\n3.militants\n4.Thrillers\n5.novels");
                                            int answer4 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Есть ли электронная копия\n1.Да\n2.Нет");
                                            sourceanswer = int.Parse(Console.ReadLine());
                                            if(sourceanswer == 1)
                                            {
                                                Console.WriteLine("Введите электронный адресс");
                                                source = Console.ReadLine();

                                            }
                                           
                                            switch (answer4)
                                            {
                                                case 1:
                                                    {  
                                                        Book standart = new Book(lastName, firstName, secondName, years, nameBook, category.fantasy);
                                                        
                                                        for (int i = 0; i < _librarys.Count; i++)
                                                        {
                                                            if (_librarys[i] == _librarys[answer2 - 1])
                                                            {
                                                                _librarys[answer2 - 1].Add_To_List(standart, invwntoryNumber);
                                                                if (sourceanswer == 1)
                                                                {
                                                                    ElectronBook electronBook = new ElectronBook (standart, source);
                                                                    _librarys[answer2 - 1].Add_To_List(electronBook, invwntoryNumber);
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        Book standart = new Book(lastName, firstName, secondName, years, nameBook, category.detectives);
                                                        for (int i = 0; i < _librarys.Count; i++)
                                                        {
                                                            if (_librarys[i] == _librarys[answer2 - 1])
                                                            {
                                                                _librarys[answer2 - 1].Add_To_List(standart, invwntoryNumber);
                                                                if (sourceanswer == 1)
                                                                {
                                                                    ElectronBook electronBook = new ElectronBook(standart, source);
                                                                    _librarys[answer2 - 1].Add_To_List(electronBook, invwntoryNumber);
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    }
                                                case 3:
                                                    {
                                                        Book standart = new Book(lastName, firstName, secondName, years, nameBook, category.militants);
                                                        for (int i = 0; i < _librarys.Count; i++)
                                                        {
                                                            if (_librarys[i] == _librarys[answer2 - 1])
                                                            {
                                                                _librarys[answer2 - 1].Add_To_List(standart, invwntoryNumber);
                                                                if (sourceanswer == 1)
                                                                {
                                                                    ElectronBook electronBook = new ElectronBook(standart, source);
                                                                    _librarys[answer2 - 1].Add_To_List(electronBook, invwntoryNumber);
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    }
                                                case 4:
                                                    {
                                                        Book standart = new Book(lastName, firstName, secondName, years, nameBook, category.Thrillers);
                                                        for (int i = 0; i < _librarys.Count; i++)
                                                        {
                                                            if (_librarys[i] == _librarys[answer2 - 1])
                                                            {
                                                                _librarys[answer2 - 1].Add_To_List(standart, invwntoryNumber);
                                                                if (sourceanswer == 1)
                                                                {
                                                                    ElectronBook electronBook = new ElectronBook(standart, source);
                                                                    _librarys[answer2 - 1].Add_To_List(electronBook, invwntoryNumber);
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    }
                                                case 5:
                                                    {
                                                        Book standart = new Book(lastName, firstName, secondName, years, nameBook, category.novels);
                                                        for (int i = 0; i < _librarys.Count; i++)
                                                        {
                                                            if (_librarys[i] == _librarys[answer2 - 1])
                                                            {
                                                                _librarys[answer2 - 1].Add_To_List(standart, invwntoryNumber);
                                                                if (sourceanswer == 1)
                                                                {
                                                                    ElectronBook electronBook = new ElectronBook(standart, source);
                                                                    _librarys[answer2 - 1].Add_To_List(electronBook, invwntoryNumber);
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    }
                                            }
                                            break;
                                        }
                                    case 2: {
                                            int temp;
                                            Console.WriteLine("Введите инвентарный номер книги");
                                            temp = int.Parse(Console.ReadLine());
                                            _librarys[answer2 - 1].Remove_List(temp);
                                            break; 
                                        }
                                    case 3:
                                        {
                                            _librarys[answer2 - 1].Show_list();
                                            break;
                                        }
                                }
                                break;
                            }

                            break;
                            
                          
                        }
                    case 3:
                        {
                            return;                         
                        }
                }
            }










            //Library ISPO = new Library("ИСПО","Энгельса 23");

            //ElectronBook electron1 = new ElectronBook(first, "vk.com");
            //electron1.ShowBook();
            //first.InventoryNumber = 2;

            //for (int i = 0; i < 2; i++)
            //{
            //    Book first = new Book("Иванов", "Иван", "Иванович", 2004, "8 Миля 9", category.fantasy);
            //    //first.InventoryNumber = 2;
            //    ISPO.Add_To_List(first, i);
            //}
            ////first.InventoryNumber = 2;
            ////ISPO.Add_To_List(first,2);
            ////ISPO.Show_list();
            ////ISPO.Add_To_List(first, );
            //ISPO.Show_list();



            Console.ReadKey();
        }
    }
}