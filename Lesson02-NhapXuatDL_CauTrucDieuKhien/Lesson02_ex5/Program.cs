namespace Lesson02_ex5
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective: Viết chương trình in ra các hình
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // In hình a
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
            // In hình b
            for (int i = 6; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("S ");
                }
                Console.WriteLine();
            }

            // In hình c
            int n = 5; // Số dòng của hình tam giác
            for (int i = 1; i <= n; i++)
            {
                // In khoảng trắng
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }

                // In dấu *
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
