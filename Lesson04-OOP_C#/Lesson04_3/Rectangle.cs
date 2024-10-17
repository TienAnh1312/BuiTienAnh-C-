using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_3
{
    internal class Rectangle:Shape
    {
        //phương thức nhập liệu
        public void InputData()
        {
            Console.WriteLine("Nhap chieu dai: ");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            width = int.Parse(Console.ReadLine());
        }
        //ghì đè phương thức tính diện tích
        public override float Area()
        {
            return length * width;
        }
        //ghì đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * length * width;
        }
    }
}
