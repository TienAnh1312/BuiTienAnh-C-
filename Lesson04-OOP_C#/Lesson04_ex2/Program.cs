namespace Lesson04_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVienBanHang nvbh = new NhanVienBanHang("BuiTienAnh", "Hà Nội", 100);
            CongNhan cn = new CongNhan("Tran Van B", "TPHCM", 150);

            nvbh.HienThi();
            cn.HienThi();
        }
    }
}
