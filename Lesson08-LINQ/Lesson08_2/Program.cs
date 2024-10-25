namespace Lesson08_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //khởi tạo Customer
            var customers = new Customer[]
            {
                new Customer{Id = 5, Name = "Tiến Anh"},
                new Customer{Id = 6, Name = "Dang" },
                new Customer{Id = 7, Name = "Hai" },
                new Customer{Id = 8, Name = "Sue" }
            };

            //khởi tạo Order
            var orders = new Order[]
            {
                new Order{Id = 5, Product = "Book" },
                new Order{Id = 6, Product = "Game" },
                new Order{Id = 7, Product = "Computer" },
                new Order{Id = 8, Product = "Shirt" },
            };

            //sử dụng truy vấn và join 2 tập dữ liệu trên ID
            var query = from c in customers join o in orders on c.Id equals o.Id
            select new { c.Name, o.Product };

            //hiển thị tên khách hàng và nhóm sản phẩm
            foreach (var group in query)
            {
                Console.WriteLine("{0} bought {1}", group.Name, group.Product);
            }
        }
    }
}
