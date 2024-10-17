using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_4
{
    //định nghĩa lớp sinh viên thực thi từ giao diện Iperson
    internal class Student:Iperson
    {
        //khai báo thuộc tính
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //Thực thi các phương thức từ giao diện
        public void Insert (object obj)
        {
            Console.WriteLine("Da luu doi tuong: " + obj);
        }
        public void Delete(object obj)
        {
            Console.WriteLine("Da Xoa doi tuong: " + obj);
        }
        public void Update(object obj)
        {
            Console.WriteLine("Da cap nhap doi tuong: " + obj);
        }
        public void Display(object obj)
        {
            Student st = (Student)obj;
            Console.WriteLine("Id: " + st.Id);
            Console.WriteLine("Name: " + st.Name);
            Console.WriteLine("Age: " + st.Age);
        }
    }
}
