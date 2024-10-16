using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_ex2
{
    internal class Book
    {
        public string author { get; set; }
        public int pages { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public int currentPage { get; set; }

        // Constructor mặc định
        public Book()
        {
            currentPage = 1; // Thiết lập trang hiện tại là 1
        }

        // Constructor với tất cả các tham số
        public Book(string author, int pages, string isbn, string title)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentPage = 1; // Thiết lập trang hiện tại là 1
        }

        // Phương thức lật trang trước
        public void FlipPageForward()
        {
            if (currentPage < pages)
            {
                currentPage++;
                Console.WriteLine("Đã lật sang trang tiếp theo. Trang hiện tại: " + currentPage);
            }
            else
            {
                Console.WriteLine("Đây là trang cuối cùng.");
            }
        }

        // Phương thức lật trang sau
        public void FlipPageBackward()
        {
            if (currentPage > 1)
            {
                currentPage--;
                Console.WriteLine("Đã lật về trang trước. Trang hiện tại: " + currentPage);
            }
            else
            {
                Console.WriteLine("Đây là trang đầu tiên.");
            }
        }

        // Phương thức hiển thị thông tin sách
        public void DisplayBookInfo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Tác giả: " + author);
            Console.WriteLine("Số trang: " + pages);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Tiêu đề: " + title);
            Console.WriteLine("Trang hiện tại: " + currentPage);
        }
    }
}
