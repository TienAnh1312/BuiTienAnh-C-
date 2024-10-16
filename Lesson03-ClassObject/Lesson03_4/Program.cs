namespace Lesson03_4
{

    /// <summary>
    /// Author: Tiến Anh
    /// Date: 16/10/2024
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int a = 20, b = 30;
            double area;
            Utility u = new Utility();
            Console.WriteLine("Trước khi hoán vị a={0}, b={1}", a, b);
            u.SwapFake(a, b);
            Console.WriteLine("Sau khi hoán vị dang fake a={0}, b={1}", a, b);
            u.SwapReally(ref a, ref b);
            Console.WriteLine("Sau khi hoán vị dang really a={0}, b={1}", a, b);
            u.AreaCircle(100, out area);
            Console.WriteLine("CHu vi hinh tron ban kinh 100 la: {0}",area);

        }
    }
}
