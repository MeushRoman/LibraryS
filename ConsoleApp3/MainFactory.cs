using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MainFactory 
    {
        public static IBook getBook(MainAbstractFactory factory, BookType type)
        {
            return factory.createAnyTextBook(type);
        }
    }
}
