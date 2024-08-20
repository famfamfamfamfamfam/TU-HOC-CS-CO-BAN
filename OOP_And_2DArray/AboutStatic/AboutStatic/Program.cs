using AboutStatic;

Console.WriteLine("Nhap hai so nguyen can tinh tong");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MathUtilities.Add(a, b));
Console.WriteLine("Nhap ban kinh hinh tron can tinh dien tich");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MathUtilities.CalculateCircleArea(r));
Console.WriteLine(MathUtilities.sopi);