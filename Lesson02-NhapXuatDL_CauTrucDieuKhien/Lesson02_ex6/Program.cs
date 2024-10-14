namespace Lesson02_ex6
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective:Nhập vào số nguyên a,b,c-Xét abc tạo thành dộ dài 3 cạnh của một tam giác không, Nếu a,b,c là độ dài 3 cạnh của tam giác thì xét xem là tam giác gì
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập 3 cạnh a, b, c
            Console.Write("Nhập cạnh a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            int c = int.Parse(Console.ReadLine());

            // Kiểm tra điều kiện tạo thành tam giác
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("a, b, c là độ dài của một tam giác.");

                // Kiểm tra loại tam giác
                if (a == b && b == c)
                {
                    Console.WriteLine("Đây là tam giác đều.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Đây là tam giác cân.");
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Console.WriteLine("Đây là tam giác vuông.");
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường.");
                }
            }
            else
            {
                Console.WriteLine("a, b, c không phải là độ dài của một tam giác.");
            }
        }
    }
}
