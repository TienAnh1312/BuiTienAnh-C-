namespace Lesson02_ex3
{

    /// <summary>
    /// Author: Tiến Anh
    /// Date: 13/12/2003
    /// Objective: Nhập số nguyên dương là số giây, in ra định dạng hh:mm:ss
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            // Nhập số giây
            Console.Write("Nhập số giây: ");
            int totalSeconds = int.Parse(Console.ReadLine());

            // Tính giờ, phút, giây
            int hours = totalSeconds / 3600; // 1 giờ = 3600 giây
            int minutes = (totalSeconds % 3600) / 60; // 1 phút = 60 giây
            int seconds = totalSeconds % 60; // số giây còn lại

            // In ra kết quả theo định dạng hh:mm:ss
            Console.WriteLine("{0}:{1}:{2}" ,hours, minutes, seconds);
        }
    }
}
