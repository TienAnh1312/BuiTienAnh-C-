namespace Lesson06_ex1
{
    /// <summary>
    ///  Tạo lớp Book với thông tin (Id, Title, Author, Publisher, year, Price)
    ///  Tạo Collection sách với 10 quyển
    ///  in sách tăng dần the giá
    ///  in sách có title trùng với giá trị nhập từ bàn phím
    ///  in sách sách xuất bản năm 2014
    ///  Xóa sách có nhà xuất bản nhi đồng
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo danh sách sách với 10 quyển
            List<Book> books = new List<Book>
            {
                new Book(1, "Book A", "Author 1", "Publisher A", 2014, 100),
                new Book(2, "Book B", "Author 2", "Publisher B", 2015, 150),
                new Book(3, "Book C", "Author 3", "Publisher A", 2014, 90),
                new Book(4, "Book D", "Author 4", "Publisher D", 2016, 120),
                new Book(5, "Book E", "Author 5", "Nhị Đồng", 2017, 110),
                new Book(6, "Book F", "Author 6", "Publisher F", 2014, 140),
                new Book(7, "Book G", "Author 7", "Nhị Đồng", 2018, 130),
                new Book(8, "Book H", "Author 8", "Publisher H", 2013, 80),
                new Book(9, "Book I", "Author 9", "Publisher I", 2019, 70),
                new Book(10, "Book J", "Author 10", "Nhị Đồng", 2020, 200)
            };

            // In danh sách các quyển sách tăng dần theo giá
            Console.WriteLine("Danh sách sách tăng dần theo giá:");
            var sortedBooks = books.OrderBy(b => b.Price).ToList();  // Sắp xếp sách theo giá tăng dần
            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book);  // Hiển thị từng quyển sách
            }

            // Tìm quyển sách có title trùng với giá trị nhập từ bàn phím
            Console.WriteLine("\nNhập tiêu đề sách cần tìm:");
            string inputTitle = Console.ReadLine();  // Nhập tiêu đề từ bàn phím
            var foundBooks = books.Where(b => b.Title.Equals(inputTitle, StringComparison.OrdinalIgnoreCase)).ToList();
            if (foundBooks.Any())
            {
                // Nếu tìm thấy sách có tiêu đề trùng
                Console.WriteLine("Sách tìm thấy:");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách với tiêu đề này.");
            }

            // Đưa ra những quyển sách xuất bản năm 2014
            Console.WriteLine("\nSách xuất bản năm 2014:");
            var books2014 = books.Where(b => b.Year == 2014).ToList();  // Lọc những sách xuất bản năm 2014
            foreach (var book in books2014)
            {
                Console.WriteLine(book); 
            }

            // Xóa những quyển sách của nhà xuất bản "Nhị Đồng"
            books.RemoveAll(b => b.Publisher == "Nhị Đồng");

            // In danh sách sau khi xóa sách của nhà xuất bản "Nhị Đồng"
            Console.WriteLine("\nDanh sách sách sau khi xóa những sách của nhà xuất bản 'Nhị Đồng':");
            foreach (var book in books)
            {
                Console.WriteLine(book); 
            }
        }
    }
}
