using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
