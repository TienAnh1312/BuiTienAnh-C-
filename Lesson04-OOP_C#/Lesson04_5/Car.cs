using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson04_5.MultipleInterface;


namespace Lesson04_5
{
    //Car class implement the Imovable interface
    internal class Car : IMovable
    {
        //declare the underlying field used bu the
        //Started property of the the iDrivable interface
        private bool started = false;

        //implement the start() method of the IDrivable interface
        public void Start()
        {
            Console.WriteLine("carr started");
            started = true;
        }
        //implement the Stop() method of the IDivable interface
        public void Stop()
        {
            Console.WriteLine("car stopped");
            started = false;
        }
        //implement the Started property of the IDrivable interface
        public bool Started
        {
            get { return started; }
        }
        //implement the TurnLeft() method of the iSteerable interface
        public void TurnLeft()
        {
            Console.WriteLine("car turning left");
        }
        //implement the TurnRight() method of the iSteerable interface
        public void TurnRight()
        {
            Console.WriteLine("car turning right");
        }
        //implement the Accelerate() method of the IMovable interface
        public void Accelerate()
        {
            Console.WriteLine("car acclerating");
        }
        //implement the Accelerate() method of the IMovable interface
        public void Brake()
        {
            Console.WriteLine("car braking");
        }
    }
}
