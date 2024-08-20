using OverloadOperator;

Vector2D vecto1 = new Vector2D() { X = 3.5, Y = 4.5 };
Vector2D vecto2 = new Vector2D() { X = 7.5, Y = 5.4 };
double X0 = (vecto1 + vecto2).X;
double Y0 = (vecto1 + vecto2).Y;
Console.WriteLine($"Vector tong co X = {X0}, Y = {Y0}");
if (vecto2 != vecto1)
{
    Console.WriteLine("Hai vector khong bang nhau");
}
else Console.WriteLine("Hai vector bang nhau");