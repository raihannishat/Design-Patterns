using System;
using System.Collections.Generic;
using System.Text;

namespace Repository_Pattern
{
    public class Book : Entity
    {
        public string Author { get; set; }
        public int Price { get; set; }
       
        public Book(int ID, string Name, string Author, int Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Author = Author;
            this.Price = Price;
        }

        public Book(string Name, string Author, int Price)
        {
            this.Name = Name;
            this.Author = Author;
            this.Price = Price;
        }

        public Book(int ID)
        {
            this.ID = ID;
        }
    }
}
