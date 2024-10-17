using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_ex2
{
    internal class CongNhan:NhanVien
    {
        public int Soluongsanpham { get; set; }

        // Constructor
        public CongNhan(string ten, string diaChi, int soluongsanpham)
        {
            this.Ten = ten;
            this.DiaChi = diaChi;
            this.Soluongsanpham = soluongsanpham;
        }

        // Implement abstract methods
        public override double TinhLuong()
        {
            return Soluongsanpham * 20000; // Mỗi sản phẩm sản xuất được hưởng 20.000 đồng
        }

        public override void HienThi()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Công nhân: {0}, Địa chỉ: {1}, Số lượng sản phẩm: {2},Lương: {3}", Ten, DiaChi, Soluongsanpham, TinhLuong());
        }
    }
}
