using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook textbook1 = MainFactory.getBook(new TextBookFactory(2000, "sss", 23), BookType.Art);
            IBook historicalbook2 = MainFactory.getBook(new HistoricalBookFactory(1050, "dsdad", 2334234, "sdsdad"), BookType.HistoricalBook);



            Library library = Library.GetInstance();

            library.addBooks(textbook1);
            library.addBooks(historicalbook2);

            List<IBook> books = library.getBooks();

                                   
            Console.WriteLine(textbook1.getName()+" "+ textbook1.getPrice());
            Console.WriteLine(historicalbook2.getName()+ " "+ historicalbook2.getPrice() + " " + historicalbook2.getYear());
        }
    }
}
