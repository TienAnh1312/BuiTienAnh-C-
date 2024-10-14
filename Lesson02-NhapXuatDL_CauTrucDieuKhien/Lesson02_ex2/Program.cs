namespace Lesson02_ex2
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective: Nhập vào năm x tháng y in ra số ngày trong tháng năm đó
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập năm và tháng
            Console.Write("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            int month = int.Parse(Console.ReadLine());

            // Xác định số ngày trong tháng
            int daysInMonth = DateTime.DaysInMonth(year, month);

            // In ra số ngày của tháng
            Console.WriteLine("Tháng {0} năm {1} có {2} ngày.", month, year, daysInMonth);
        }
    }
}
