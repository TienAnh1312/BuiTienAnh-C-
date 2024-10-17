using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_ex2
{
    internal class NhanVienBanHang:NhanVien
    {
        public int Soluongbanduoc { get; set; }

        // Tạo Constructor có tham số
        public NhanVienBanHang(string ten, string diaChi, int soluongbanduoc)
        {
            this.Ten = ten;
            this.DiaChi = diaChi;
            this.Soluongbanduoc = soluongbanduoc;
        }

        // Implement abstract methods
        public override double TinhLuong()
        {
            return Soluongbanduoc * 50000; // Mỗi sản phẩm bán được hưởng 50.000 đồng
        }

        public override void HienThi()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhân viên bán hàng: {0}, Địa chỉ: {1}, Số lượng bán được: {2}, Lương: {3}",Ten, DiaChi, Soluongbanduoc, TinhLuong());
        }
    }
}
