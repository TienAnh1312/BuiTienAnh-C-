
namespace Lesson08_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //khai báo chung
            int[] Numbers = {7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
            string[] Words =
            {
                "Văn", "bản", "là", "một", "loại", "hình", "phương", "tiện", "để", "ghi", "nhận", "lưu", "giữ", "và", "truyền", "đạt", "các", "thông", "tin"
            };
            List<Film> ListFilm = new List<Film>()
            {
                new Film{FilmId = "F01", FilmName = "Tiến Anh là tôi", Price = 120000},
                new Film{FilmId = "F02", FilmName = "Tam quốc diễn nghĩa", Price = 140000},
                new Film{FilmId = "F03", FilmName = "Thiếu lâm truyền kỳ", Price = 150000},
                new Film{FilmId = "F04", FilmName = "Người Nhện 2", Price = 130000},
                new Film{FilmId = "F05", FilmName = "Ngân hàng chuyển đổi   ", Price = 160000},
                new Film{FilmId = "F06", FilmName = "Alien", Price = 180000},
                new Film{FilmId = "F07", FilmName = "Tổ đội", Price = 170000},
            };

            //lọc các số chẵn
            IEnumerable<int> querynumber = Numbers.Where(n => n % 2 == 0);
            Show<int>(querynumber, "Lọc các số chẵn: ");
            
            //lọc các từ có độ dài >4
            IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
            Show<string>(queryword, "Lọc các từ có độ dài > 4");

            //lọc các từ có tên bắt đầu bằng chữ t
            IEnumerable<string> queryT = Words.Where(w => w.StartsWith("t"));
            Show<string>(queryT, "Lọc các từ có tên bắt đầu bằng chữ t: ");

            //lọc các số duy nhất trong các tập số
            var uniqueNumber = Numbers.Distinct();
            Show<int>(uniqueNumber, "Lọc các số duy nhất trong các tập số:");
            
            //đến xem có bao nhiêu từ không trùng nhau
            var countDistinct = Words.Distinct().Count();
            Console.WriteLine("Đếm xxem có bao nhiêu từ không trùng nhau:" + countDistinct);

            //lấy 4 số đầu tiên trong dãy
            var fourNumber = Numbers.Take(4);
            Show<int>(fourNumber, "Lấy 4 số đầu tiên trong dãy:");

            //lấy 2 từ đầu tiên trong câu
            var twoword = Words.Take(2);
            Show<string>(twoword, "Lấy 2 từ dầu tiên trong câu:");

            //lấy những từ đầu tiên có chứa chữ t
            var seachword = Words.TakeWhile(w => w.Contains('t'));
            Show<string>(seachword, "Lấy những từ đầu tiên có chứa chữ t:");

            //sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá < 200000
            var queryfilm = ListFilm.OrderBy(f => f.Price)
            .Select(x => new {x.FilmId, x.FilmName, x.Price})
            .ToList().TakeWhile(t => t.Price < 200000);

            //bỏ qua 3 phần tử đầu tiên, lấy tất cả các phần tử còn lại
            var skipNumber = Numbers.Skip(3);
            Show<int>(skipNumber, "Bỏ qua 3 phần tử đầu tiên, lấy tất cả các phần tử còn lại:");

            //bỏ qua 4 phần tử đầu tiên lấy 3 phần tử kế tiếp
            var skipTakeNumber = Numbers.Skip(4).Take(3);
            Show<int>(skipTakeNumber, "Bỏ qua 4 phần tử đầu tiên, lấy 3 phần tử kế tiếp:");

            //bỏ qua 3 phim đầu tiên lấy 3 phim kết tiếp (có thể áp dụng để phân trang)
            var skipTakeFilm = ListFilm.Skip(3).Take(3);
            Show<Film>(skipTakeFilm, "Bỏ qua 4 phần tử đầu tiên, lấy 3 phần tử kế tiếp: ");

            //sắp xếp giảm dần, sau đó lấy các phần tử <5
            var sortNumber = Numbers.OrderByDescending(x => x).SkipWhile(x => x > 5);
            Show<int>(sortNumber, "Sắp xếp giảm dần, sau đó lấy các phần tử <5:");
        }

        //định nghĩa phương thức Generic hiển thị dữ liệu

        private static void Show<T>(IEnumerable<T> data, string message)
        {
            Console.WriteLine(message);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}
