namespace Lesson02_4
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective: Viết chương trình in ra các số nguyên tố từ 2- 100 (số nt là số chỉ chia hết cho chính nó)
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //khai báo biến đánh dấu
            bool check_i;
            Console.WriteLine("Danh sách các số nguyên tố từ 2-100:");

            //Duyệt từ 2-100
            for (int i = 2; i < 100; i++)
            {
                check_i = true; // giả sử i là số nguyên tố
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0) //Nếu i chia hết cho j thì
                    {
                        check_i = false; // Kết luận không là số nguyên tố
                        beak; //thoát khỏi vòng lặp hiện tại
                    }
                    if (check_i) // nếu giả sử vẫn đúng -> i là số nguyên tố
                        Console.WriteLine(" {0}", i);
                }
            }
        }
    }
}
