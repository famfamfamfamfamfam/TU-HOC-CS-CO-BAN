using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise10
{
    internal class Car
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public Engine Engine { get; set; }
        public Car(/*double horsePower, string type*/)
        {
            Engine = new Engine() /*{ HorsePower = horsePower, Type = type }*/; 
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Mau xe {Model} duoc che tao boi {Manufacturer} thuoc dong {Engine.Type} co ma luc {Engine.HorsePower}");
        }
    }
}
