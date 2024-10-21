namespace Lesson05_ExHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo mảng 1 chiều gồm 10 phần tử Student
            Student[] students = new Student[10]
            {
            new Student(1, "John", 20),
            new Student(2, "Jane", 18),
            new Student(3, "Mike", 22),
            new Student(4, "Emily", 19),
            new Student(5, "Bob", 23),
            new Student(6, "Alice", 21),
            new Student(7, "Tom", 18),
            new Student(8, "Sarah", 20),
            new Student(9, "David", 24),
            new Student(10, "Emma", 22)
            };

            // Tìm sinh viên có tuổi nhỏ nhất
            Student youngestStudent = students[0];
            foreach (Student student in students)
            {
                if (student.Age < youngestStudent.Age)
                {
                    youngestStudent = student;
                }
            }
            Console.WriteLine("Sinh viên có tuổi nhỏ nhất:");
            youngestStudent.DisplayInfo();

            // Sắp xếp mảng tăng dần theo tuổi
            Array.Sort(students, (s1, s2) => s1.Age.CompareTo(s2.Age));
            Console.WriteLine("\nMảng sắp xếp theo tuổi tăng dần:");
            foreach (Student student in students)
            {
                student.DisplayInfo();
            }

            // Tìm sinh viên có tuổi lớn nhất
            Student oldestStudent = students[0];
            foreach (Student student in students)
            {
                if (student.Age > oldestStudent.Age)
                {
                    oldestStudent = student;
                }
            }
            Console.WriteLine("\nSinh viên có tuổi lớn nhất:");
            oldestStudent.DisplayInfo();
        }
    }
    
}
