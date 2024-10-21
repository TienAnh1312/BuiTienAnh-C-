using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_ExHome
{
    internal class Student
    {
        // Các thuộc tính
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        // Phương thức hiển thị thông tin sinh viên
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
        }
    }
}
