namespace Lesson02_2
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 14/10/2024
    /// Objective: Số phút gọi <=30 số phí 30$, tr khoảng (3-50] số tính 1.2% mỗi số 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Tính tiền điện
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // khai báo biến
            string name;
            int number;
            double money = 0;
            //Nhập thông tin
            Console.WriteLine("Nhập tên thuê bao: ");
            name = Console.ReadLine();

            Console.WriteLine("Nhập số điện sử dụng: ");
            number = Convert.ToInt32(Console.ReadLine());
            //tính toán số tiền
            if (number <= 30)
            {
                money = 30;
            }else if (number> 30 && number <= 50){
                money = 30 + (number - 30) * 1.2;
            }else if (number > 50){
                money = 30 + 20 * 1.2 + (number - 50) * 1.5;
            }

            //in thông tin
            Console.WriteLine("\n thông tin tiền điện");
            Console.WriteLine("Họ và tên: {0}", name);
            Console.WriteLine("Số tiền điện sử dụng:{0}", number);
            Console.WriteLine("Số Tiền: {0:C})", money);
        }
    }
}
