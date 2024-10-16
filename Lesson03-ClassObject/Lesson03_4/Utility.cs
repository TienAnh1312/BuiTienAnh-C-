using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_4
{
    internal class Utility
    {
        //không sử dụng ref
        public void SwapFake(int a,int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        //sử dụng ref cho tham số
        public void SwapReally(ref int a,ref int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        //sử dụng out cho tham số
        public void AreaCircle(double radius, out double area)
        {
            area = 2 * Math.PI*radius;
        }
    }
}
