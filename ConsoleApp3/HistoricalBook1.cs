using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class HistoricalBook1 : IBook
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Era { get; set; }

        public HistoricalBook1(int Year, string Name, double Price, string  Era)
        {
            this.Year = Year;
            this.Price = Price;
            this.Name = Name;
            this.Era = Era;
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

        public string getEra()
        {
            return this.Era;
        }
    }
}
