using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_5
{
    internal class MultipleInterface
    {
        internal interface IDrivable
        {
            //method seclarations
            void Start();
            void Stop();
            //property declaration
            bool Started { get; }
        }
        //define the iSteerable interface
        public interface ISteerable
        {
            //method declarations
            void TurnLeft();
            void TurnRight();
        }
        //define the IMovable interface
        public interface IMovable : IDrivable, ISteerable
        {
            void Accelerate();
            void Brake();
        }
    }
}
