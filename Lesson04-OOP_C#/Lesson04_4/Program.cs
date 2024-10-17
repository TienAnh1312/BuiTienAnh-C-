namespace Lesson04_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo một nv
            Iperson staff = new Staff();
            object data = "Dai hoc Nguyen Trai";
            //gọi các hoạt động
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);
            //tạo sinh viên
            Iperson student = new Student()
            {
                Id = "Sv01",
                Name = "Tien Anh",
                Age = 20
            };
            //hiển thị dữ liệu
            student.Display(student);
        }
    }
}
