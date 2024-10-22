using System.Collections;

namespace Lesson06_ex2
{
    /// <summary>
    /// Tạo Hashtable lưu trữ thông tin các ngày trong tuần với key từ 1-7
    /// Tìm kiếm ngày "Tuesday" trong Hashtable in ra thông báo nếu tìm thấy hoặc không
    /// In ra các ngày trong tuần bao gồm cả key và value
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo Hashtable lưu trữ thông tin các ngày trong tuần với key từ 1-7
            Hashtable weekDays = new Hashtable
            {
                {1, "Monday"},
                {2, "Tuesday"},
                {3, "Wednesday"},
                {4, "Thursday"},
                {5, "Friday"},
                {6, "Saturday"},
                {7, "Sunday"}
            };

            // Tìm kiếm ngày "Tuesday" trong Hashtable
            Console.WriteLine("Tìm kiếm ngày 'Tuesday':");
            if (weekDays.ContainsValue("Tuesday"))
            {
                // Nếu tìm thấy ngày "Tuesday"
                Console.WriteLine("Ngày 'Tuesday' có trong danh sách.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy ngày 'Tuesday'.");
            }

            // In ra các ngày trong tuần bao gồm cả key và value
            Console.WriteLine("\nCác ngày trong tuần:");
            foreach (DictionaryEntry day in weekDays)
            {
                // Hiển thị key và value của mỗi ngày trong tuần
                Console.WriteLine($"Key: {day.Key}, Value: {day.Value}");
            }
        }
    }
}
