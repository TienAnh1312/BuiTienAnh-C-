using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_ex4
{
    internal class Department
    {
        // Thuộc tính
        public string Name { get; set; }
        private Employee[] employees;

        // Constructor
        public Department(string name, int size)
        {
            Name = name;
            employees = new Employee[size];
        }

        // Indexer để truy cập và thao tác với từng Employee
        public Employee this[int index]
        {
            get
            {
                if (index >= 0 && index < employees.Length)
                {
                    return employees[index];
                }
                throw new IndexOutOfRangeException("Index out of range");
            }
            set
            {
                if (index >= 0 && index < employees.Length)
                {
                    employees[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
        }

        // Phương thức hiển thị tất cả nhân viên trong phòng ban
        public void DisplayEmployees()
        {
            Console.WriteLine($"Department: {Name}");
            foreach (var emp in employees)
            {
                emp?.DisplayInfo();  // Kiểm tra nếu nhân viên không null
            }
        }
    }
}
