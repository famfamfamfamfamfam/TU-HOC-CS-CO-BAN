using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Person
    {
        private string Name;
        private int Age;
        private string Address;
        public string _name { get => Name; set => Name = value; }
        public int _age { get => Age; set => Age = value; }
        public string _address { get => Address; set => Address = value; }
        //public void DisplayInfo(string name, int age, string address)
        //{
        //    Name = name;
        //    Age = age;
        //    Address = address;
        //    Console.WriteLine(Name + ", " + Age + " tuoi, co dia chi: " + Address);
        //}
        public void DisplayInfo()
        {
            Console.WriteLine(Name + ", " + Age + " tuoi, co dia chi: " + Address);
        }
    }
}
