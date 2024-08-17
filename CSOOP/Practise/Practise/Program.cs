using Practise;
using System.Runtime.CompilerServices;
class Program
{
    static void Main(string[] args)
    {
        //Car c1 = new Car();
        //c1.DisplayInfo("inChina_", "new_", 1992);

        //ElectricCar ec1 = new ElectricCar();
        //ec1.DisplayInfo("inJapan_", "old_", 1970);
        //ec1.DisplayBatteryInfo(200);
        Circle tron = new Circle();
        tron._r = 5;
        Rectangle chunhat = new Rectangle();
        chunhat._a = 5;
        chunhat._b = 7;
        Shape tinhdahinh1 = new Circle();
        Shape tinhdahinh2 = new Rectangle();
        Console.WriteLine(tron.GetArea());
        Console.WriteLine(chunhat.GetArea());
        Shape tong = tron + chunhat;
        Console.WriteLine(tong);
    }
}