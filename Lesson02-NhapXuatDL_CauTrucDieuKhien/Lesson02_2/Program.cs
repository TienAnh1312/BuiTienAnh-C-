namespace Lesson02_3
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective: Nhập kí tự thông báo đó là nguyên âm hay phụ âm
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char ch;
            Console.WriteLine("Nhập vào kí tự:");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':
                 Console.WriteLine("{0} là nguyên âm.", ch);
                break;
                default: 
                    Console.WriteLine("{0} là phụ âm.", ch);
                break;
            }
        }
    }
}
