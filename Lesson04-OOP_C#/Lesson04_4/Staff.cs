using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_4
{
    internal class Staff:Iperson
    {
        //thực thi các phương thức cảu giao diện
        public void Insert(object obj)
        {
            Console.WriteLine("Da luu doi tuong: " + obj);
        }
        public void Update(object obj) 
        {
            Console.WriteLine("Da Cap nhap doi tuong: " + obj);
        }
        public void Delete(object obj)
        {
            Console.WriteLine("Da Xoa doi tuong: " + obj);
        }
        public void Display(object obj)
        {
            Console.WriteLine("Thong tin doi tuong: " + obj);
        }
    }
}
