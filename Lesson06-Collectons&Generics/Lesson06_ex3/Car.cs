using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_ex3
{
    internal class Car
    {
        public string Name { get; set; }  
        public string Color { get; set; } 

        // Constructor để khởi tạo đối tượng Car
        public Car(string name, string color)
        {
            Name = name;
            Color = color;
        }

        // Phương thức ghi đè ToString để hiển thị thông tin xe
        public override string ToString()
        {
            return $"Name: {Name}, Color: {Color}";
        }
    }
}
