using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_ex3
{
    internal interface IStorage
    {
        string Data { get; set; }
        void Write(string fileName);
        void Read(string fileName);
    }
}
