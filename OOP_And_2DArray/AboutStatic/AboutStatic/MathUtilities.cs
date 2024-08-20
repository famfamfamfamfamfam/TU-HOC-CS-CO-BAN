using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutStatic
{
    internal class MathUtilities
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        protected static double PI = 3.14;
        public static double sopi {  get => PI; private set => PI = value; }
        public static double CalculateCircleArea(int r)
        {
            return PI * Math.Pow(r, 2);
        }
    }
}
