using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Fantasy: IBook
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Fantasy(int Year, string Name, double Price)
        {
            this.Year = Year;
            this.Price = Price;
            this.Name = Name;
        }

        public string getName()
        {
            return this.Name;
        }

        public double getPrice()
        {
            return this.Price;
        }

        public int getYear()
        {
            return this.Year;
        }
    }
}

