namespace Lesson02_ex1
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 13/12/2003
    /// Objective: Nhập thông tin nhân viên (Id, Name, Address, birthday, Salary, Bonus). in ra màn có định dạng thêm trường TotalSalary=Slary+Bonus
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập thông tin nhân viên
            Console.Write("Nhập ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nhập Tên: ");
            string name = Console.ReadLine();

            Console.Write("Nhập Địa chỉ: ");
            string address = Console.ReadLine();

            Console.Write("Nhập Ngày sinh: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Console.Write("Nhập Lương: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.Write("Nhập Thưởng: ");
            decimal bonus = decimal.Parse(Console.ReadLine());

            // Tính tổng lương
            decimal totalSalary = salary + bonus;

            // In ra màn hình thông tin nhân viên
            Console.WriteLine("\n--- Thông tin nhân viên ---");
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Tên: {0}", name);
            Console.WriteLine("Địa chỉ: {0}", address);
            Console.WriteLine("Ngày sinh: {0}", birthday);
            Console.WriteLine("Lương: {0}", salary);
            Console.WriteLine("Thưởng: {0}", bonus);
            Console.WriteLine("Tổng lương: {0}", totalSalary);
        }
    }
}
