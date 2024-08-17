using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Rectangle : Shape
    {
        protected double a;
        protected double b;
        public double _a
        {
            get { return a; }
            set { a = value; }
        }
        public double _b
        {
            get { return b; }
            set { b = value; }
        }

        public override double GetArea()
        {
            return a * b;
        }
    }
}
