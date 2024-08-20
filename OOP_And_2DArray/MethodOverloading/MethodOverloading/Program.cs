using MethodOverloading;

//Calculator nhancacsonguyen = new Calculator();
//Calculator nhancacsothuc = new Calculator();
Calculator nhancacso = new Calculator();
Console.WriteLine("Can nhap so nguyen hay so thuc?");
string s = Console.ReadLine();
Console.WriteLine("Can nhan 2 hay 3 so?");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap cac so:");
if (s == "nguyen")
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (n == 2)
    {
        Console.WriteLine(nhancacso.Multiply(a, b));
    }
    if (n == 3)
    {
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(nhancacso.Multiply(a, b, c));
    }
}
else
{
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    if (n == 2)
    {
        Console.WriteLine(nhancacso.Multiply(a, b));
    }
    if (n == 3)
    {
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(nhancacso.Multiply(a, b, c));
    }
}
