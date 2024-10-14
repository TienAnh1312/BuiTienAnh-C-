namespace Lesson02_ex4
{

    /// <summary>
    /// Author: Tiến Anh
    /// Date: 13/12/2003
    /// Objective: viết chương trình in ra tổng 3 ký số là chẵn từ 100 - 999
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int totalSum = 0;

            // Duyệt qua các số từ 100 đến 999
            for (int number = 100; number <= 999; number++)
            {
                // Tách 3 chữ số
                int hundreds = number / 100;       // Lấy chữ số hàng trăm
                int tens = (number / 10) % 10;     // Lấy chữ số hàng chục
                int ones = number % 10;            // Lấy chữ số hàng đơn vị

                // Tính tổng của 3 chữ số
                int digitSum = hundreds + tens + ones;

                // Kiểm tra nếu tổng là số chẵn
                if (digitSum % 2 == 0)
                {
                    totalSum += number;
                }
            }

            // In ra tổng các số có tổng 3 chữ số là số chẵn
            Console.WriteLine($"Tổng các số có 3 chữ số mà tổng các chữ số là chẵn: {totalSum}");
        }
    }
}
