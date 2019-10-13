using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ConcreteUser : User
    {   
        private Pupil pupil = new Pupil();
        private Student student = new Student();

        public ConcreteUser()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.pupil = new Pupil();
            this.student = new Student();
        }



        public override void Borrow(IBook book)
        {
            throw new NotImplementedException();
        }

        public override double Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
