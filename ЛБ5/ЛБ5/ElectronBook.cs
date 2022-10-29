using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ5
{
    class ElectronBook : Book
    {
        private string _electronicSource;
        public ElectronBook(string lastName, string firstName, string secondName, int years, string nameBook, category genre, string soure) : base(lastName, firstName, secondName, years, nameBook, genre)
        {
            _electronicSource = soure;
        }
        public ElectronBook(Book book, string soure) : base(book)
        {
            _electronicSource = soure;
        }
        public override void ShowBook()
        {
            base.ShowBook();
            Console.WriteLine("Электронный источник: " + _electronicSource);
        }



    }
}