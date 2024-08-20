using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise12
{
    internal class Calculator
    {
        public virtual dynamic Add(int a, int b)
        {
            return a + b;
        }
        public virtual dynamic Add (int a, int b, int c)
        {
            return Add(Add(a,b), c);
        }
        public virtual dynamic Add (double a, double b)
        {
            return a + b;
        }
    }
}
