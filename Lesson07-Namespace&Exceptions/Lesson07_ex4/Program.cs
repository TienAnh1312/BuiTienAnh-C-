using System.Net.NetworkInformation;

namespace Lesson07_ex4
{
    /// <summary>
    /// Tạo lớp Lecture với các thông tin Name, Salary, Bonus
    ///Viết các phương thức thuộc tính cơ bản cho lớp Lecture.
    ///Tạo lớp custom exception AmountException để điều khiển nghiệp vụ
    ///- Khi giảng viên lương(Salary) thấp hơn 60,000$
    ///- Hoặc thưởng(Bonus) nhiều hơn 10,000$
    ///Test chương trình với ngoại lệ.
    /// </summary>

    // Tạo ngoại lệ tùy chỉnh AmountException
    public class AmountException : Exception
    {
        public AmountException(string message) : base(message)
        {
        }
    }

    // Lớp Lecture chứa thông tin giảng viên
    public class Lecture
    {
        public string Name { get; set; }
        public double Salary { get; set; }  // Lương
        public double Bonus { get; set; }   // Thưởng

        // Constructor để khởi tạo thông tin giảng viên
        public Lecture(string name, double salary, double bonus)
        {
            Name = name;
            Salary = salary;
            Bonus = bonus;

            // Kiểm tra điều kiện lương và thưởng
            if (Salary < 60000)
            {
                throw new AmountException("Lương giảng viên không được thấp hơn 60,000$.");
            }
            if (Bonus > 10000)
            {
                throw new AmountException("Thưởng giảng viên không được nhiều hơn 10,000$.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                // Tạo đối tượng Lecture với lương sai để kiểm tra ngoại lệ
                Lecture lecture1 = new Lecture("Giang Vien Bùi Tiến Anh", 55000, 9000);  // Lương thấp hơn 60,000$
            }
            catch (AmountException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                // Tạo đối tượng Lecture với thưởng sai để kiểm tra ngoại lệ
                Lecture lecture2 = new Lecture("Giang Vien B", 65000, 15000);  // Thưởng nhiều hơn 10,000$
            }
            catch (AmountException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                // Tạo đối tượng Lecture với thông tin hợp lệ
                Lecture lecture3 = new Lecture("Giang Vien C", 65000, 8000);
                Console.WriteLine($"Giảng viên {lecture3.Name} có lương: {lecture3.Salary}$ và thưởng: {lecture3.Bonus}$");
            }
            catch (AmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
