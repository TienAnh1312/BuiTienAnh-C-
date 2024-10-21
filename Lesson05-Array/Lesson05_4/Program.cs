namespace Lesson05_4
{
    /// <summary>
    /// Mô phỏng danh sách các chương trong 1 quyển sách
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
           //tạo đối tượng book
           Book b = new Book("progamming with C#", 4);

            //nhập thông tin các chương
            b[0] = new Chapter("Chapter 1", "Intoduction to C#");
            b[1] = new Chapter("Chapter 2", "DataType and Variable in C#");
            b[2] = new Chapter("Chapter 3", "Input and Output in Console Application");
            b[3] = new Chapter("Chapter 4", "Staments Conditions and Loops");

            //in thông tin sách
            Console.WriteLine("List of book");
            Console.WriteLine(b.Name);
            // danh sách chương
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(b[i]);
            }
            //thông tin chương 3
            Console.WriteLine("Detail of Chapter3");
            Console.WriteLine(b["Chapter 3"]);
            Console.Read();
        }
    }
}
