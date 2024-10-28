
using System.Collections;

namespace DanhGiaHocPhan_C_
{
    internal class Program
    {// Hashtable lưu trữ sinh viên với khóa là StudID
        static Hashtable studentTable = new Hashtable();

        static void Main(string[] args)
        {
            while (true)
            {
                // Hiển thị menu cho người dùng chọn
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Insert new student");
                Console.WriteLine("2. Display all the student list");
                Console.WriteLine("3. Calculate average mark");
                Console.WriteLine("4. Exit");
                Console.Write("Option: ");
                int option = int.Parse(Console.ReadLine());

                // Xử lý các lựa chọn của người dùng
                switch (option)
                {
                    case 1:
                        InsertStudent();  // Thêm sinh viên mới và lưu vào Hashtable
                        break;
                    case 2:
                        DisplayStudents();  // Hiển thị tất cả sinh viên trong Hashtable
                        break;
                    case 3:
                        CalculateAverage();  // Tính toán và hiển thị điểm trung bình
                        break;
                    case 4:
                        return;  // Thoát khỏi chương trình
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        // Phương thức thêm sinh viên vào Hashtable
        static void InsertStudent()
        {
            Student student = new Student();  // Tạo đối tượng sinh viên mới

            // Nhập thông tin cơ bản của sinh viên
            Console.Write("Enter Student ID: ");
            student.StudID = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            student.StudName = Console.ReadLine();
            Console.Write("Enter Student Gender: ");
            student.StudGender = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            student.StudAge = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Class: ");
            student.StudClass = Console.ReadLine();

            // Nhập 3 điểm của sinh viên
            Console.WriteLine("Enter 3 marks: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Mark {i + 1}: ");
                student[i] = int.Parse(Console.ReadLine());
            }

            // Tính toán điểm trung bình
            student.CalAvg();

            // Thêm sinh viên vào Hashtable với khóa là StudID
            studentTable.Add(student.StudID, student);
            Console.WriteLine("Student added successfully.");
        }

        // hiển thị danh sách sinh viên từ Hashtable
        static void DisplayStudents()
        {
            foreach (DictionaryEntry entry in studentTable)
            {
                Student student = (Student)entry.Value;
                student.Print();  // hiển thị thông tin sinh viên
            }
        }

        // tính toán và hiển thị điểm trung bình của sv
        static void CalculateAverage()
        {
            foreach (DictionaryEntry entry in studentTable)
            {
                Student student = (Student)entry.Value;
                student.CalAvg();  // Tính điểm trung bình
                Console.WriteLine($"Average mark for student {student.StudName}: {student.StudAvgMark}");
            }
        }
    }
}

