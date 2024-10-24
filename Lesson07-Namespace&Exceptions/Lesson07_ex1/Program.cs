namespace Lesson07_ex1
{
    /// <summary>
    /// Trong namespace AnCo tạo các lớp Bo, Trau, De
    /// Trong namespace AnThit tạo các lớp CaSau, Ho, SuTu
    /// Các lớp trên đều có các thuộc tính: ID,Name,Weight.
    /// Trong namespace DongVat tạo lớp Program để test ứng dụng trên với mỗi loài 1 con.
    /// Test chương trình trong hàm Main.
    /// </summary>

    namespace DongVat
    {
        // Namespace AnCo chứa các loài động vật ăn cỏ
        namespace AnCo
        {
            // Lớp Bo
            public class Bo
            {

                public int ID { get; set; }
                public string Name { get; set; }
                public double Weight { get; set; }

                // Constructor khởi tạo giá trị cho Bò
                public Bo(int id, string name, double weight)
                {
                    ID = id;
                    Name = name;
                    Weight = weight;
                }
            }

            // Lớp Trau 
            public class Trau
            {
                public int ID { get; set; }
                public string Name { get; set; }
                public double Weight { get; set; }

                public Trau(int id, string name, double weight)
                {
                    ID = id;
                    Name = name;
                    Weight = weight;
                }
            }

            // Lớp De 
            public class De
            {
                public int ID { get; set; }
                public string Name { get; set; }
                public double Weight { get; set; }

                public De(int id, string name, double weight)
                {
                    ID = id;
                    Name = name;
                    Weight = weight;
                }
            }
        }

        // Namespace AnThit chứa các loài động vật ăn thịt
        namespace AnThit
        {
            // Lớp CaSau 
            public class CaSau
            {
                public int ID { get; set; }
                public string Name { get; set; }
                public double Weight { get; set; }

                public CaSau(int id, string name, double weight)
                {
                    ID = id;
                    Name = name;
                    Weight = weight;
                }
            }

            // Lớp Ho 
            public class Ho
            {
                public int ID { get; set; }
                public string Name { get; set; }
                public double Weight { get; set; }

                public Ho(int id, string name, double weight)
                {
                    ID = id;
                    Name = name;
                    Weight = weight;
                }
            }

            // Lớp SuTu 
            public class SuTu
            {
                public int ID { get; set; }
                public string Name { get; set; }
                public double Weight { get; set; }

                public SuTu(int id, string name, double weight)
                {
                    ID = id;
                    Name = name;
                    Weight = weight;
                }
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                // Tạo các đối tượng cho các loài động vật ăn cỏ
                var bo = new AnCo.Bo(1, "Bo", 500);
                var trau = new AnCo.Trau(2, "Trau", 700);
                var de = new AnCo.De(3, "De", 60);

                // Tạo các đối tượng cho các loài động vật ăn thịt
                var casau = new AnThit.CaSau(4, "Ca Sau", 300);
                var ho = new AnThit.Ho(5, "Ho", 250);
                var sutu = new AnThit.SuTu(6, "Su Tu", 230);

                // In ra thông tin của các loài động vật ăn cỏ
                Console.WriteLine($"Bo: {bo.ID}, {bo.Name}, {bo.Weight}kg");
                Console.WriteLine($"Trau: {trau.ID}, {trau.Name}, {trau.Weight}kg");
                Console.WriteLine($"De: {de.ID}, {de.Name}, {de.Weight}kg");

                // In ra thông tin của các loài động vật ăn thịt
                Console.WriteLine($"Ca Sau: {casau.ID}, {casau.Name}, {casau.Weight}kg");
                Console.WriteLine($"Ho: {ho.ID}, {ho.Name}, {ho.Weight}kg");
                Console.WriteLine($"Su Tu: {sutu.ID}, {sutu.Name}, {sutu.Weight}kg");
            }
        }
    }
}
