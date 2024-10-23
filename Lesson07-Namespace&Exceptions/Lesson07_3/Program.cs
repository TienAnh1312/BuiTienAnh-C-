namespace Lesson07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //khai báo mảng
            byte[] a = new byte[5];

            //nhập mảng
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("a[{0}]", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {   
                Console.WriteLine("Không được nhập ks tự cho mảng số");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Không được nhập giá trị nằm ngoài 0-255");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Lỗi vượt qua phạm vi của mảng");
            }

            //in mảng
            Console.WriteLine("Nội dung mảng");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
        }
    }
}
