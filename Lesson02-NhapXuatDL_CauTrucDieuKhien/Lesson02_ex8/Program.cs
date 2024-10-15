namespace Lesson02_ex8
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective: Tính lãi xuất
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập vào số tiền gửi, lãi suất ngân hàng (tính theo năm) và số tháng gửi
            Console.Write("Nhập vào số tiền gửi ban đầu: ");
            double tienGoc = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập vào lãi suất ngân hàng theo năm (phần trăm): ");
            double laiSuatNam = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập vào số tháng gửi: ");
            int soThangGui = Convert.ToInt32(Console.ReadLine());

            // Tính lãi suất tháng
            double laiSuatThang = (laiSuatNam / 12) / 100;

            double tienLaiThang;
            double tongTienCuoiKy = tienGoc;

            // Tính lãi và số dư cuối kỳ
            for (int i = 1; i <= soThangGui; i++)
            {
                tienLaiThang = tongTienCuoiKy * laiSuatThang;
                tongTienCuoiKy += tienLaiThang;
            }

            // Xuất kết quả
            Console.WriteLine("Số lãi cuối kỳ sau {0} tháng là: {1:0.00} VND", soThangGui, tongTienCuoiKy);
        }
    }
}
