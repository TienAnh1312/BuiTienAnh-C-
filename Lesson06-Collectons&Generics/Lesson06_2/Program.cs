namespace Lesson06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo SortedList generic
            SortedList<string, string> listEm = new SortedList<string, string>();

            // Đưa dữ liệu vào
            listEm.Add("E01", "Bùi Tiến Anh");
            listEm.Add("E02", "Lâm Thế Vinh");
            listEm.Add("E03", "Trần Ngọc An");
            listEm.Add("E04", "Nguyễn Tuấn Anh");
            listEm.Add("E05", "Phạm Chi Chanh");

            // In danh sách
            Console.WriteLine("Danh sách nhân viên");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ": " + listEm[key]);
            }

            // Tìm kiếm tất cả các nhân viên có tên bắt đầu bằng chữ A
            Console.WriteLine("Danh sách nhân viên bắt đầu bằng chữ V");
            foreach (var key in listEm.Keys)
            {
                if (listEm[key].StartsWith("B")) //Tìm kiếm theo họ
                {
                    Console.WriteLine(key + ": " + listEm[key]);
                }
            }

            foreach (var key in listEm.Keys)
            {
                if (listEm[key].Contains("V")) //kiểm tra họ hoặc tên bắt đầu bằng chữ "V"
                {
                    Console.WriteLine(key + ": " + listEm[key]);
                }
            }

            // Xóa nhân viên có mã E04
            listEm.Remove("E04");

            // Kiểm tra nếu chưa có nhân viên E06 thì thêm vào
            if (!listEm.ContainsKey("E06"))
            {
                listEm.Add("E06", "Phạm Chí Hữu");
            }

            // In danh sách sau khi thêm, xóa
            Console.WriteLine("Danh sách sau khi xóa, thêm");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ": " + listEm[key]);
            }
        }
    }
}
