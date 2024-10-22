using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_ex1
{
    class Book
    {
        public int Id { get; set; }  // Mã sách
        public string Title { get; set; }  // Tiêu đề sách
        public string Author { get; set; }  // Tác giả
        public string Publisher { get; set; }  // Nhà xuất bản
        public int Year { get; set; }  // Năm xuất bản
        public decimal Price { get; set; }  // Giá sách

        // Constructor để khởi tạo đối tượng Book
        public Book(int id, string title, string author, string publisher, int year, decimal price)
        {
            Id = id;
            Title = title;
            Author = author;
            Publisher = publisher;
            Year = year;
            Price = price;
        }

        // Ghi đè ToString để hiển thị thông tin sách
        public override string ToString()
        {
            return $"ID: {Id}, Title: {Title}, Author: {Author}, Publisher: {Publisher}, Year: {Year}, Price: {Price}";
        }
    }
}

