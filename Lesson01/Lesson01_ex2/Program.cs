namespace Lesson01_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Viết chương trình thực hiện các yêu cầu");
            //Khai báo biến
            string maNV;
            string hoVaTen;
            DateTime ngaySinh;
            string diaChi;
            string dienThoai;
            string email;

            //gán giá trị
            maNV = "Sv001";
            hoVaTen = "Tiến Anh";
            ngaySinh = DateTime.Now;
            diaChi = "Tuyên Quang";
            dienThoai = "0828345288";
            email = "buitienanh13122003@gmail.com";

            //Hiển thị
            Console.WriteLine("---Thông tin cá nhân---");
            Console.WriteLine("Mã nhân viên:" + maNV);
            Console.WriteLine("Họ và tên:{0}", hoVaTen);
            Console.WriteLine("Ngày sinh:{0}", ngaySinh);
            Console.WriteLine("Địa chỉ: " + diaChi);
            Console.WriteLine("Diện thoại:" + dienThoai);
            Console.WriteLine("Email: " + email);
        }
    }
}
