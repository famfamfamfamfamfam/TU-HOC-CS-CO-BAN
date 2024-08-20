using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    internal class Vector2D
    {
        public double X {  get; set; }
        public double Y { get; set; }
        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {

            return new Vector2D() { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }
        public static bool operator ==(Vector2D v1, Vector2D v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y) return true;
            else return false;
        }
        public override bool Equals(object? obj) // Equals là phương thức không phải toán tử, nên phải được ghi đè để định nghĩa lại chứ không thể nạp chồng
        {
            if (obj == null || obj.GetType() != GetType()) return false;
            Vector2D v = (Vector2D)obj; //gán obj cho một đối tượng sau khi kiểm tra kiểu của obj
            return v.X == X && v.Y == Y; //để kiểm tra thử các thuộc tính của obj có bằng với thuộc tính của đối tượng gọi phương thức Equals không           
        }
        public static bool operator !=(Vector2D v1, Vector2D v2)
        {
            //if (!v1.Equals(v2)) return true;
            //else return false;
            return !(v1 == v2);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X,Y);
        }
    }
}
