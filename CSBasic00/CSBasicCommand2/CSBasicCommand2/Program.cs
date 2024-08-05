using System.Reflection.Metadata.Ecma335;

bool YOY, YOY1;
float a, b;
Console.WriteLine("Tu dong giai phuong trinh co dang ax+b=0");
Console.WriteLine("Nhap he so a: ");
string nhapa = Console.ReadLine();
Console.WriteLine("Nhap he so b: ");
string nhapb = Console.ReadLine();
YOY = float.TryParse(nhapb, out b);
YOY1 = float.TryParse(nhapa, out a);
//Console.WriteLine(YOY == true && YOY1 == true ? "" : "Nhap sai dan den ket luan sai:");
if (YOY == true && YOY1 == true)
{
    if (a == 0)
    {
        if (b == 0)
        {
            Console.WriteLine("Phuong trinh vo so nghiem.");
        }
        else Console.WriteLine("Phuong trinh vo nghiem.");
    }
    else
    {
        Console.WriteLine("Phuong trinh co nghiem: x = {0}", -b / a);
    }
}
else Console.WriteLine("Baka!");

//int a, b;
//bool HOO, Q;
//Console.WriteLine("Nhap so bat ky: ");
//HOO = int.TryParse(Console.ReadLine(), out a);
//Console.WriteLine("Nhap so tiep theo: ");
//Q = int.TryParse(Console.ReadLine(), out b);
//switch(HOO)
//{
//    case true : Console.WriteLine("OK");
//        break;
//    case false : Console.WriteLine("KO");
//        break;
//};
//switch(Q)
//{
//    case true: Console.WriteLine("OK"); break;
//    case false: Console.WriteLine("KO"); break;
//};
//int c = a + b;
//switch (c)
//{
//    case 0: Console.WriteLine("OK"); break;
//    case 10: Console.WriteLine("OOOK"); break;
//    default: Console.WriteLine("KOOOOOO {0}", c); break;
//}