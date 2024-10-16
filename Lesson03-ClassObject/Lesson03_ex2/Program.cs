namespace Lesson03_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng Book với constructor mặc định
            Book book1 = new Book();
            book1.author = "Nguyen Nhat Anh";
            book1.pages = 300;
            book1.isbn = "978-3-16-148410-0";
            book1.title = "Cho Toi Mot Ve Di Tuoi Tho";

            // Hiển thị thông tin sách
            book1.DisplayBookInfo();

            // Lật trang
            book1.FlipPageForward();
            book1.FlipPageForward();
            book1.FlipPageBackward();

            // Tạo đối tượng Book với constructor đầy đủ tham số
            Book book2 = new Book("J.K. Rowling", 500, "978-0-7475-3269-9", "Harry Potter and the Philosopher's Stone");

            // Hiển thị thông tin sách
            book2.DisplayBookInfo();

            // Lật trang
            book2.FlipPageForward();
            book2.FlipPageBackward();
        }
    }
}
