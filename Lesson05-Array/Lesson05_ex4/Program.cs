namespace Lesson05_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo phòng ban mới với 3 nhân viên
            Department department = new Department("IT Department", 3);

            // Thêm các nhân viên vào phòng ban
            department[0] = new Employee(1, "John", 25);
            department[1] = new Employee(2, "Jane", 28);
            department[2] = new Employee(3, "Bob", 30);

            // Hiển thị thông tin các nhân viên trong phòng ban
            department.DisplayEmployees();

            // Truy cập và thao tác với nhân viên thứ 2
            Employee secondEmployee = department[1];
            Console.WriteLine("\nThông tin nhân viên thứ 2:");
            secondEmployee.DisplayInfo();
        }
    }
}
