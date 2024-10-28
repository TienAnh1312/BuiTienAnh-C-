using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DanhGiaHocPhan_C_.Student;

namespace DanhGiaHocPhan_C_
{
    internal class Student
    {
        
        private float studAvgMark;

        // Mảng lưu trữ 3 điểm của sinh viên
        private int[] markList = new int[3];

        // Triển khai các thuộc tính của interface IStudent
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }

        // Thuộc tính điểm trung bình chỉ có thể đọc
        public float StudAvgMark
        {
            get { return studAvgMark; }
        }

        // Phương thức Print() in ra thông tin sinh viên
        public void Print()
        {
            Console.WriteLine($"ID: {StudID}, Name: {StudName}, Gender: {StudGender}, Age: {StudAge}, Class: {StudClass}, Average Mark: {StudAvgMark}");
        }

        // Indexer để truy cập mảng markList
        public int this[int index]
        {
            get { return markList[index]; }  // Lấy giá trị từ mảng
            set { markList[index] = value; } // Gán giá trị vào mảng
        }

        // Phương thức CalAvg() tính toán điểm trung bình từ mảng markList
        public void CalAvg()
        {
            // Tính trung bình của 3 điểm và lưu vào studAvgMark
            studAvgMark = (float)(markList[0] + markList[1] + markList[2]) / 3;
        }
    }
}
