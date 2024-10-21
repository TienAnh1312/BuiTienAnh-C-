namespace Lesson05_3
{
    /// <summary>
    /// chỉ mục đơn và chỉ mục kép
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //khởi tạo đối tượng sinh viên với 3 sv và mỗi sv gồm 2 điểm
            Student st = new Student(3, 2);
            //Sử dụng chỉ mục để truy cập vào thành phần mảng của lớp
            st[0] = "TienAnh";
            st[0, 0] = 9;
            st[0, 1] = 6.5;
            st[1] = "Dang";
            st[1, 0] = 5;
            st[1, 1] = 7.5;
            st[2] = "BI";
            st[2, 0] = 10;
            st[2, 1] = 9.5;
            //in ra thông tin
            Console.WriteLine("Thông tin sinh viên");
            for (int i = 0; i < 3; i++  )
            {
                Console.WriteLine("Họ và tên: " + st[i]);
                Console.Write("Diem: ");
                for (int j = 0; j < 2;j++)
                {
                    Console.Write(st[i, j] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}
