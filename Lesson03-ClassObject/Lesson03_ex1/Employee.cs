using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_ex1
{
    internal class Employee
    {

        // Các thành phần dữ liệu
        public int id { get; set; }
        public string name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }

        // Biến static cho lương cơ bản
        public static double basicSalary = 5000;

        // Phương thức tính thu nhập
        public double GetIncome()
        {
            return salaryLevel * basicSalary;
        }

        // Phương thức hiển thị thông tin nhân viên
        public void Display()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Họ tên: " + name);
            Console.WriteLine("Năm sinh: " + yearOfBirth);
            Console.WriteLine("Bậc lương: " + salaryLevel);
            Console.WriteLine("Thu nhập: " + GetIncome());
        }
    }
}
