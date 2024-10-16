using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_3
{
    internal class StudentModel
    {
        //khai báo tập hợp chứa các sinh viên
        List<Student> liststudents;
        //phương thức khởi tạo 
        public StudentModel()
        {
            //khởi tạo danh sách sinh viên
            this.liststudents = new List<Student>
            {
                new Student() {Id=1,Name="An",Age=20},
                new Student() {Id=2,Name="Vinh",Age=22},
                new Student() {Id=3,Name="Ha",Age=24},
                new Student() {Id=4,Name="Anh",Age=21},
                new Student() {Id=5,Name="Lung",Age=27},
                new Student() {Id=6,Name="Hao",Age=28},
            };
        }
        //phương thức trả về danh sách sinh viên
        public List<Student> GetStudents()
        {
            return liststudents;
        }
        //Phương thức trả về danh sách sinh viên  theo Id
        public Student GetStudents(int id)
        {
            Student st = null;
            foreach (var item in liststudents)
            {
                if (item.Id == id)
                    st = item;
            }
            return st;
        }
        // phương thức trả về vinh viên có tuổi từ x to y
        public List<Student> GetStudents(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (var item in liststudents)
            {
                if (item.Age >= x && item.Age <= y)
                    result.Add(item);
            }
            return result;
        }
    }
}
