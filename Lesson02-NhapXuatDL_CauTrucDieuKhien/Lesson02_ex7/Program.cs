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
            int n = 10; 

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string (' ',n-i));
                int num = i;
              
                for (int j = 1; j <=  i; j++)
                {
                    Console.Write(num % 10);
                    num++;
                }

                // In các số tăng dần
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j % 10);
                }

                num -= 2;
                // In các số giảm dần
                for (int j = 1; j < 1; j++)
                {
                    Console.Write(num % 10);
                    num --;
                }

                Console.WriteLine(); 
            }
        }
    }
}
