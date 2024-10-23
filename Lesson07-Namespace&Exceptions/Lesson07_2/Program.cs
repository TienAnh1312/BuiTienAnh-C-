namespace Lesson07_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng House trong namespace Business
            Bussiness.House h = new Bussiness.House();

            //gán thông tin
            h.HouseNo = "H01";
            h.Price = 100000;

            //in thông tin
            Console.WriteLine("House detail");
            Console.WriteLine("\t House No: "+ h.HouseNo);
            Console.WriteLine("\t Price: " + h.Price);
            
            //tạo mới đối tượng Car tr namespace Business.Dealership
            Bussiness.Dealership.Car c = new Bussiness.Dealership.Car();
            c.CarNo = "AO999";
            c.Price = 3456.50M;

            //in thông tin
            Console.WriteLine("Car detail");
            Console.WriteLine("\t Car No: " + h.HouseNo);
            Console.WriteLine("\t Price: " + h.Price);
        }
    }
}
