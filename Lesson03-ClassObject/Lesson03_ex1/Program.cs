namespace Lesson03_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.id = 1;
            emp.name = "Nguyen Van A";
            emp.yearOfBirth = 1990;
            emp.salaryLevel = 3.5;

            // Hiển thị thông tin nhân viên
            emp.Display();
        }
    }
}
