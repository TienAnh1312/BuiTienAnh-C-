namespace Lesson08_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Khởi tạo dữ liệu
            string[] data = { "Tôm", "Hùm", "Bông", "Bỏ", "Lò", "Phô", "Mai", "Hương", "Vị", "Độc", "Bản", "Chỉ", "Có", "Ở", "Muối", "Biển" };

            //truy vấn dữ liệu
            IEnumerable<string> result1 = from m in data select m;

            //hiển thị kết quả
            Console.WriteLine("Hiển thị tất cả kết quả");
            foreach (var item in result1)
            {
                Console.Write(item + " ");
            }

            //truy vấn theo điều kiện lấy cá từ là "Tôm"
            IEnumerable<string> result2 = from m in data where m.Equals("Tôm")
            select m;

            //hiển thị kết quả
            Console.WriteLine("\n truy vấn theo điều kiện");
            foreach (var item in result2)
            {
                Console.WriteLine(item + " ");
            }

            //sắp xếp theo dữ liệu
            IEnumerable<string> result3 = from m in data orderby m select m;
            foreach (var item in result3)
            {
                Console.Write(item + " ");
            }

            //lấy tập dữ liệu mới
            var result4 = from m in data select new { Thuong = m.ToLower(), Hoa = m.ToUpper() };

            //hiển thị kết quả
            Console.WriteLine("Chữ thường và hoa");
            foreach (var item in result4)
            {
                Console.WriteLine(item.Thuong + ":" + item.Hoa);
            }
        }
    }
}
