namespace Lesson05_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo mảng CAN và CHI
            string[] can = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
            string[] chi = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

            Console.OutputEncoding= System.Text.Encoding.UTF8;

            // Nhập vào năm bất kỳ từ người dùng
            Console.WriteLine("Nhập vào một năm dương lịch: ");
            int year = int.Parse(Console.ReadLine());

            // Giả sử năm 2010 là năm CANH DẦN
            int baseYear = 2010; // Năm gốc là 2010
            int baseCanIndex = 6; // Chỉ số của "Canh" trong mảng CAN (6)
            int baseChiIndex = 2; // Chỉ số của "Dần" trong mảng CHI (2)

            // Tính chỉ số của CAN và CHI cho năm nhập vào
            int yearDifference = year - baseYear;

            int canIndex = (baseCanIndex + yearDifference) % 10;
            if (canIndex < 0)
                canIndex += 10; // Điều chỉnh nếu chỉ số âm

            int chiIndex = (baseChiIndex + yearDifference) % 12;
            if (chiIndex < 0)
                chiIndex += 12; // Điều chỉnh nếu chỉ số âm

            // In ra kết quả năm âm lịch tương ứng
            Console.WriteLine($"Năm {year} là năm {can[canIndex]} {chi[chiIndex]}.");
        }
    }
}
