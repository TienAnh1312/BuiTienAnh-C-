namespace Lesson02_ex7
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective: in tam giác
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10; // Chiều cao của tam giác

            for (int i = 1; i <= n; i++)
            {
                // In khoảng trắng cho canh giữa
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // In các số tăng dần
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j % 10);
                }

                // In các số giảm dần
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j % 10);
                }

                Console.WriteLine(); // Xuống dòng sau khi hoàn thành mỗi dòng
            }
        }
    }
}
