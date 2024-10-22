namespace Lesson06_ex3
{
    /// <summary>
    /// Tạo lớp Car lưu trữ thông tin (name, color)
    /// Khởi tạo một list lưu trữ danh sách 10 Car
    /// Xóa Car có color : Red
    /// in danh sách Car
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo danh sách List chứa 10 xe Car
            List<Car> cars = new List<Car>
            {
                new Car("Car A", "Red"),
                new Car("Car B", "Blue"),
                new Car("Car C", "Red"),
                new Car("Car D", "Green"),
                new Car("Car E", "Black"),
                new Car("Car F", "Red"),
                new Car("Car G", "White"),
                new Car("Car H", "Yellow"),
                new Car("Car I", "Red"),
                new Car("Car J", "Blue")
            };

            // In danh sách các xe Car
            Console.WriteLine("Danh sách các xe Car:");
            foreach (var car in cars)
            {
                Console.WriteLine(car); 
            }

            // Xóa các Car có màu Red
            cars.RemoveAll(car => car.Color == "Red"); 

            // In danh sách các xe còn lại sau khi xóa
            Console.WriteLine("\nDanh sách các xe Car sau khi xóa các xe có màu Red:");
            foreach (var car in cars)
            {
                Console.WriteLine(car); 
            }
        }
    }
}
