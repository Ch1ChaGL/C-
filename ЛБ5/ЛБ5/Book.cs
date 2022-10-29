using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ5
{
    enum category
    {

        fantasy,
        detectives,
        militants,
        Thrillers,
        novels
    }
    class Book
    {
        private string _firstName;
        private string _lastName;
        private string _secondName;
        private string _nameBook;
        private int _years;
        private int _inventoryNumber;
        private category _genre;

        public Book(Book book)
        {
            _firstName = book._firstName;
            _lastName = book._lastName;
            _secondName = book._secondName;
            _nameBook = book._nameBook;
            _years = book._years;
            _genre = book._genre;
            _inventoryNumber = book._inventoryNumber;
        }

        public Book(string lastName, string firstName, string secondName, int years, string nameBook, category genre)
        {
            _firstName = firstName;
            _lastName = lastName;
            _secondName = secondName;
            _years = years;
            _nameBook = nameBook;
            _genre = genre;
            _inventoryNumber = 0;
        }
        public int InventoryNumber
        {
            get { return _inventoryNumber; }
            set { _inventoryNumber = value; }
        }
        public virtual void ShowBook()
        {
            Console.WriteLine("Имя автора: " + _firstName);
            Console.WriteLine("Фамилия автора: " + _lastName);
            Console.WriteLine("Отчество автора: " + _secondName);
            Console.WriteLine("Название книги: " + _nameBook);
            Console.WriteLine("Год выпуска: " + _years);
            Console.WriteLine("Категория книги: " + _genre);
            Console.WriteLine("Инвентарный номер: " + _inventoryNumber);

        }
        

    }
}