using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Library
    {
        private List<IBook> Books;

        private Library()
        {
            Books = new List<IBook>();
        }        

        private static Library _instance;

        public static Library GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Library();
            }
            return _instance;
        }

        public void addBooks(IBook book)
        {
            Books.Add(book);
        }
        public List<IBook> getBooks()
        {
            return Books;
        }

    }
}
