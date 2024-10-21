namespace Lesson05_1
{

    /// <summary>
    /// Mảng 1 chiều
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ///khai báo và khởi tạo mảng
            int[] m = { 5, 7, 0, 1, 2, 6, 9};

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //duyệt mảng và in dữ liệu
            Console.WriteLine("Các phần tử của mảng");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write("{0},", m[i]);
            }

            //tìm phần tử lớn nhất
            int max = m[0];
            for (int i = 1; i < m.Length; i++)
            {
                if (max < m[i])
                {
                    max = m[i];
                }
            }
            Console.WriteLine("Phần tử lớn nhất: " + max);

            //kiểm tra mảng có đối xứng không
            bool kt = true; //giả sử mảng là đối xứng

            for (int i = 0; i < m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                Console.WriteLine("mảng đối xứng");
            }
            else
            {
                Console.WriteLine("mảng không đối xứng");
            }
        }
    }
}
