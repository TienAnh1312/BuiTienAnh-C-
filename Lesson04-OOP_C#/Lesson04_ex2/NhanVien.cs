using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_ex2
{
    internal abstract class NhanVien
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }

        // Abstract methods
        public abstract double TinhLuong();
        public abstract void HienThi();
    }
}
