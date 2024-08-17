using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Shape
    {
        public double TongDienTich;
        public virtual double GetArea()
        {
            return 0;
        }
        public static Shape operator +(Shape A, Shape B)
        {
            return new Shape { TongDienTich = A.GetArea() + B.GetArea() };
        }
        public override string ToString()
        {
            return TongDienTich.ToString();
        }

    }
}
