using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise12
{
    internal class ScientificCalculator : Calculator
    {
        public override dynamic Add(int a, int b, int c)
        {
            return a + b + c + 1;
        }
    }
}
