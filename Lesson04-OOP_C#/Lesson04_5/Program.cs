namespace Lesson04_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Car object
            Car myCar = new Car();
            //call myCar.Start()
            Console.WriteLine("Calling myCar.Start()");
            myCar.Start();
            //call myCar.TurnLeft()
            Console.WriteLine("Calling myCar.left()");
            myCar.TurnLeft();
            //call myCar.Acclerate()
            Console.WriteLine("Calling myCar.Accelerate()");
            myCar.Accelerate();
            Console.ReadLine();
        }
    }
}
