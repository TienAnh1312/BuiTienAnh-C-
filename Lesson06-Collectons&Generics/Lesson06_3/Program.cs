namespace Lesson06_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //khai báo và khởi tạo dánh sách sv sử dụng list generic
            List<Student> list = new List<Student>()
            {
                new Student {Id="S10", FirstName="Bùi Tiến", LastName="Anh", Avg=10 },
                new Student {Id="S12", FirstName="Nguyễn Tiến", LastName="Anh", Avg=9 },
                new Student {Id="S13", FirstName="lê Hoàng", LastName="Nhật", Avg=8.5 },
                new Student {Id="S14", FirstName="Trần Hoàng", LastName="Phương", Avg=3 },
                new Student {Id="S15", FirstName="Hoàng Thị", LastName="Huệ", Avg=5 },
                new Student {Id="S16", FirstName="Nguyễn Thiên", LastName="Nhân", Avg=7.5 },
                new Student {Id="S17", FirstName="Nguyễn Thiến", LastName="Tùng", Avg=8.8 },
            };

            //in danh sách sv
            Console.WriteLine("Danh sách sv: ");
            foreach (var st in list)
            {
                Console.Write(st);
            }

            //tìm sv có điểm trung binh cao nhất
            double max = list[0].Avg;
            Student stmax = list[0];
            foreach (var st in list)
            {
                if (st.Avg > max)
                {
                    max = st.Avg;
                    stmax = st;
                }
            }

            //in kq
            Console.WriteLine("Sv có điểm cao nhất là :");
            Console.WriteLine(stmax);
        }
    }
}
