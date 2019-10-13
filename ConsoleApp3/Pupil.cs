using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Pupil 
    {
        private string userName { get; set; }
        private int Id { get; set; }
        private List<IBook> borrowedBooks { get; set; }
        private bool memberShip { get; set; }

        //public override void Borrow(IBook book)
        //{
        //    throw new NotImplementedException();
        //}

        //public override double Calculate()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
