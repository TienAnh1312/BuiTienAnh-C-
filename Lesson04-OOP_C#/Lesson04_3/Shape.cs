using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_3
{
    //định nghĩa lớp trừu trượng
    internal abstract class Shape
    {
        protected float radius, length, width;
        //khai báo các phương thức trừu tượng
        public abstract float Area(); //tính diện tích
        public abstract float Circumference(); //tính chu vi
    }
}
