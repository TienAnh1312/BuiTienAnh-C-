using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_1
{
    internal class Button:Window
    {
        //phương thức khởi tạo
        public Button(int top, int left) 
        : base(top, left) // gọi contructor lớp cơ sở
        {         
        }
        //ghì đè phương thức
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a buttonat {0}, {1}", top, left);
        }
    }
}
