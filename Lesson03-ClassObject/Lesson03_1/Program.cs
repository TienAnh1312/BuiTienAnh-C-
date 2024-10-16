namespace Lesson03_1
{
    /// <summary>
    /// Author: Tiến Anh
    /// Date: 16/10/2024
    /// Objective:Khởi tạo đối tượng, truy vấn các trường và phương thức
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // tạo đối tượng car
            Car myCar = new Car();
            //gán giá trị cho các trường của dối tượng
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.year = 1995;

            //hiển thị thông tin về đối tượng myCar
            System.Console.WriteLine("--Thông tin chi tiết--");
            System.Console.WriteLine("make: " + myCar.make);
            System.Console.WriteLine("model: " + myCar.model);
            System.Console.WriteLine("color: " + myCar.color);
            System.Console.WriteLine("year release: " + myCar.year);
           
            //gọi các phương thức
            myCar.Start();
            myCar.Stop();

        }
    }
}
