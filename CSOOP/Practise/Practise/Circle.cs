using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Circle: Shape
    {
        protected double PI = Math.PI;
        public double _r;
        protected double r { get => _r; set => _r = value; }
        public override double GetArea()
        {
            return PI * Math.Pow(_r,2);
        }
    }
}
