using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_ex1
{
    internal class Book
    {
        public int Id { get; set; }      
        public string Name { get; set; }  
        public string Author { get; set; }  
        public double Price { get; set; }  
        public string Publisher { get; set; }  
        public int Year { get; set; }  

        // Constructor khởi tạo đối tượng Book
        public Book(int id, string name, string author, double price, string publisher, int year)
        {
            Id = id;
            Name = name;
            Author = author;
            Price = price;
            Publisher = publisher;
            Year = year;
        }
    }
}
