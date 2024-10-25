namespace Lesson08_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo danh sách 10 quyển sách
            List<Book> books = new List<Book>()
            {
                new Book(1, "Book 1", "Author A", 1200, "NXB A", 2015),
                new Book(2, "Book 2", "Author B", 2500, "NXB B", 2020),
                new Book(3, "Book 3", "Author C", 10000, "NXB C", 2012),
                new Book(4, "Book 4", "Author D", 3500, "NXB A", 2015),
                new Book(5, "Lập trình C#", "Author E", 4500, "NXB D", 2019),
                new Book(6, "Book 6", "Author F", 4900, "NXB Giáo Dục", 2018),
                new Book(7, "Book 7", "Author G", 11000, "NXB Giáo Dục", 2021),
                new Book(8, "Lập trình Web", "Author H", 1200, "NXB Giáo Dục", 2015),
                new Book(9, "Book 9", "Author I", 2000, "NXB A", 2011),
                new Book(10, "Book 10", "Author J", 500, "NXB B", 2016)
            };

            // a. Hiển thị tất cả các quyển sách
            // Truy vấn để lấy tất cả sách và hiển thị chúng
            var allBooks = from book in books
                           select book;

            Console.WriteLine("Danh sách tất cả các quyển sách:");
            foreach (var book in allBooks)
            {
                Console.WriteLine($"{book.Name} - {book.Price}");
            }

            // b. Hiển thị những quyển sách có giá từ 1000-5000
            // Truy vấn sách có giá nằm trong khoảng 1000 đến 5000
            var booksInRange = from book in books
                               where book.Price >= 1000 && book.Price <= 5000
                               select book;

            Console.WriteLine("\nNhững quyển sách có giá từ 1000 đến 5000:");
            foreach (var book in booksInRange)
            {
                Console.WriteLine($"{book.Name} - {book.Price}");
            }

            // c. Hiển thị những quyển sách xuất bản năm 2015
            // Truy vấn sách được xuất bản trong năm 2015
            var books2015 = from book in books
                            where book.Year == 2015
                            select book;

            Console.WriteLine("\nNhững quyển sách xuất bản năm 2015:");
            foreach (var book in books2015)
            {
                Console.WriteLine($"{book.Name} - {book.Year}");
            }

            // d. Hiển thị những quyển sách có tên "Lập trình"
            // Truy vấn sách có tên chứa chuỗi "Lập trình"
            var lapTrinhBooks = from book in books
                                where book.Name.Contains("Lập trình")
                                select book;

            Console.WriteLine("\nNhững quyển sách có tên 'Lập trình':");
            foreach (var book in lapTrinhBooks)
            {
                Console.WriteLine($"{book.Name}");
            }

            // e. Đếm các quyển sách của nhà xuất bản Giáo Dục
            // Truy vấn để đếm số lượng sách của nhà xuất bản "NXB Giáo Dục"
            var giaoDucBooksCount = (from book in books
                                     where book.Publisher == "NXB Giáo Dục"
                                     select book).Count();

            Console.WriteLine($"\nSố sách của nhà xuất bản Giáo Dục: {giaoDucBooksCount}");
        }
    }
}
