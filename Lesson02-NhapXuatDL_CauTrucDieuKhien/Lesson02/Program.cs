namespace Lesson02_1
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective: Nhập xuất dữ liệu - Nhập mã sv, tên ngày sinh và điểm 3 môn và in ra màn hình
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo các biến
            string id, name;
            double mark1, mark2, mark3, average;
            DateTime birthday;
            //Nhập dữ liệu từ bàn phím
            Console.WriteLine("Nhap ma so: ");
            id = Console.ReadLine();

            Console.WriteLine("Nhập Tên: ");
            name = Console.ReadLine();

            Console.WriteLine("Nhập Ngày sinh: ");
            birthday = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Nhập điểm môn 1: ");
            mark1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhập điểm môn 2: ");
            mark2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhập điểm môn 3: ");
            mark3 = Convert.ToDouble(Console.ReadLine());

            //tính điểm trung bình
            average = (mark1 + mark2 + mark3) / 3;

            //In thông tin ra màn hình
            Console.WriteLine("\n Thong tin Sinh Vien");
            Console.WriteLine("Ma so: {0}", id);
            Console.WriteLine("Ngay Sinh: {0:dd/MM/yyyy}", birthday);
            Console.WriteLine("Diem 1:{0:N}, Diem 2:{1:N}, Diem 3:{2:N} ", mark1, mark2, mark3);
            Console.WriteLine("Điểm trung binh :{0}", average);
        }
    }
}
