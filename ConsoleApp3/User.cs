using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class User
    {
        //private string userName { get; set; }
        //private int Id { get; set; }
        //private List<IBook> borrowedBooks { get; set; }
        //private bool memberShip { get; set; }

        public abstract void Borrow(IBook book);
        public abstract double Calculate();
    }
}
