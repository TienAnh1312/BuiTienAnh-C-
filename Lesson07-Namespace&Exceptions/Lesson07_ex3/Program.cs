using System.Xml.Linq;

namespace Lesson07_ex3
{
    /// <summary>
    /// Tạo lớp ngoại lệ tự định nghĩa InvalidMarkException.
    ///Tạo lớp Student với các thông tin(id, name, theorymark, labmark).
    ///Nếu theorymark(điểm lý thuyết) hoặc labmark(điểm thực hành) nhập vào nằm ngoài đoạn 0-10 thì tung ngoại lệ InvalidMarkException.
    ///Test các ngoại lệ.
    /// </summary>

    // Tạo ngoại lệ tùy chỉnh InvalidMarkException
    public class InvalidMarkException : Exception
    {
        public InvalidMarkException(string message) : base(message)
        {
        }
    }

    // Lớp Student chứa thông tin sinh viên
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double TheoryMark { get; set; }  // Điểm lý thuyết
        public double LabMark { get; set; }     // Điểm thực hành

        // Constructor để khởi tạo thông tin sinh viên
        public Student(int id, string name, double theoryMark, double labMark)
        {
            ID = id;
            Name = name;
            TheoryMark = theoryMark;
            LabMark = labMark;

            // Kiểm tra điểm lý thuyết và thực hành
            if (TheoryMark < 0 || TheoryMark > 10)
            {
                throw new InvalidMarkException("Điểm lý thuyết phải nằm trong khoảng 0-10.");
            }
            if (LabMark < 0 || LabMark > 10)
            {
                throw new InvalidMarkException("Điểm thực hành phải nằm trong khoảng 0-10.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                // Tạo đối tượng Student và nhập điểm sai để kiểm tra ngoại lệ
                Student student1 = new Student(1, "Bùi Tiến Anh", 9, 12);  // Điểm thực hành sai
            }
            catch (InvalidMarkException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                // Tạo đối tượng Student với điểm hợp lệ
                Student student2 = new Student(2, "Tran Thi B", 8, 9);
                Console.WriteLine($"Sinh viên {student2.Name} có điểm lý thuyết: {student2.TheoryMark} và điểm thực hành: {student2.LabMark}");
            }
            catch (InvalidMarkException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
