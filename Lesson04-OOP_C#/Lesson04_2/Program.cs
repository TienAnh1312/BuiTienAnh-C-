namespace Lesson04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo sinh viên cao đẳng và in ra thông tin
            Console.WriteLine("Student of College");
            StudentCollege sv1 = new StudentCollege("Hanh", 2007, 9.5, 8, 7);
            sv1.Display();
            Console.WriteLine("Average of score: {0}", sv1.Average());
            //khởi tạo sinh viên đại học và in ra thông tin
            Console.WriteLine("Student of university:");
            StudentUniversity sv2 = new StudentUniversity("Anh", 2003, 6, 8, 9, 6);
            sv2.Display();
            Console.WriteLine("Average of score: {0}", sv2.Average());
        }
    }
}
