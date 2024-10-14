namespace Lesson02_6
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective: Khởi tạo mảng tên, dùng foreach để in
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] names = { "Tiến Anh","Đào","Hoa", "Dũng"};
            Console.WriteLine("Danh sách sinh viên: ");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
