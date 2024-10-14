namespace Lesson02_5
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective: Tính tổng số chẵn và không chi hết cho 3 từ 1-100
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //khai báo biến tổng
            int sum = 0;

            //duyệt từ 1-100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 != 0 ) 
                {
                    sum += i;
                }    
            }
            //in kết quả
            Console.WriteLine("Tổng các số chẵn không chia hết cho 3 từ 1-100 là {0}", sum);
        }
    }
}
