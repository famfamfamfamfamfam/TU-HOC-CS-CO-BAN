using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise2
{
    internal class Dog : Animal
    {
        string Breed;
        public string _breed {  get => Breed; set => Breed = value; }
        public void MakeSound()
        {
            Console.WriteLine("GAU GAU");
        }
        public void DisplayInfo()
        {
            //Console.WriteLine(Name + "\t" + Age + "\t" + Breed);
            Console.WriteLine($"Ten: {Name}, tuoi: {Age}, thuoc giong: {Breed}");
        }
    }
}
