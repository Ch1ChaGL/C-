using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ5
{


    class Library
    {
       
        private List<Book> _books = new List<Book>();
        private string _libraryName;
        private string _libraryAddres;

        public string LibraryName
        {
            get { return _libraryName; }
            set { _libraryName = value; }
        }
        public Library(string libraryName, string libraryAddres)
        {
            _libraryName = libraryName;
            _libraryAddres = libraryAddres;
        }
        public void Show_Library()
        {
            Console.WriteLine("Название: " + _libraryName);
            Console.WriteLine("Адресс: " + _libraryAddres);

        }
        public void Add_To_List(Book book, int number)
        {   book.InventoryNumber = number;
            _books.Add(book);
        }
        public void Remove_List(int number)
        {
            for(int i = 0; i < _books.Count; i++)
            {
               int temp = _books[i].InventoryNumber;
                if(number == temp)
                {
                    _books.RemoveAt(i);
                    i--;
                }
            }
        }
        public void Show_list()
        {
            for (int i = 0; i < _books.Count; i++)
            {              
                _books[i].ShowBook();
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}