using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_3
{
    internal class Student
    {
        //tạo các thuộc tinh tự động
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //phương thức hiển thị
        public void Display()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
