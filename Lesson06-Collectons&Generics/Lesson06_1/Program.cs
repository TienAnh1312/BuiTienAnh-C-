using System.Collections;

namespace Lesson06_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //tạo ArrayList
            ArrayList inv = new ArrayList();

            //thêm phần tử vào đanh sách
            inv.Add(new Product("Tiến Anh", 5.9, 3));
            inv.Add(new Product("B", 8.2, 2));
            inv.Add(new Product("C", 3.5, 4));
            inv.Add(new Product("D", 1.8, 8));

            //in ra danh sách phần tử
            Console.WriteLine("Product list: ");
            foreach(Product i in inv)
            {
                Console.WriteLine(" "+ i );
            }
        }
    }
}
