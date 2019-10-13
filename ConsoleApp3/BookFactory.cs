using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TextBookFactory : MainAbstractFactory
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public TextBookFactory(int year, string name, double price)
        {
            this.Name = name;
            this.Year = year;
            this.Price = price;
        }

        public IBook createAnyTextBook(BookType type)
        {
            IBook book = null;
            switch (type)
            {           
                case BookType.Art:
                    book = new Art(Year, Name, Price);
                    break;
                case BookType.Detective:
                    book = new Detective(Year, Name, Price);
                    break;
                case BookType.Fantasy:
                    book = new Fantasy(Year, Name, Price);
                    break;                            
                default:
                    break;
            }

            return book;
        }
    }

    public class HistoricalBookFactory : MainAbstractFactory
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Era { get; set; }

        public HistoricalBookFactory(int year, string name, double price, string era)
        {
            this.Name = name;
            this.Year = year;
            this.Price = price;
            this.Era = era;
        }

        public IBook createAnyTextBook(BookType type)
        {
            IBook book = null;
            switch (type)
            {
                case BookType.HistoricalBook:
                    book = new HistoricalBook1(Year, Name, Price, Era);
                    break;               
            }

            return book;
        }
    }
}
