//using System.Reflection.Metadata.Ecma335;

//bool YOY, YOY1;
//float a, b;
//Console.WriteLine("Tu dong giai phuong trinh co dang ax+b=0");
//Console.WriteLine("Nhap he so a: ");
//string nhapa = Console.ReadLine();
//Console.WriteLine("Nhap he so b: ");
//string nhapb = Console.ReadLine();
//YOY = float.TryParse(nhapb, out b);
//YOY1 = float.TryParse(nhapa, out a);
////Console.WriteLine(YOY == true && YOY1 == true ? "" : "Nhap sai dan den ket luan sai:");
//if (YOY == true && YOY1 == true)
//{
//    if (a == 0)
//    {
//        if (b == 0)
//        {
//            Console.WriteLine("Phuong trinh vo so nghiem.");
//        }
//        else Console.WriteLine("Phuong trinh vo nghiem.");
//    }
//    else
//    {
//        Console.WriteLine("Phuong trinh co nghiem: x = {0}", -b / a);
//    }
//}
//else Console.WriteLine("Baka!");

////int a, b;
////bool HOO, Q;
////Console.WriteLine("Nhap so bat ky: ");
////HOO = int.TryParse(Console.ReadLine(), out a);
////Console.WriteLine("Nhap so tiep theo: ");
////Q = int.TryParse(Console.ReadLine(), out b);
////switch(HOO)
////{
////    case true : Console.WriteLine("OK");
////        break;
////    case false : Console.WriteLine("KO");
////        break;
////};
////switch(Q)
////{
////    case true: Console.WriteLine("OK"); break;
////    case false: Console.WriteLine("KO"); break;
////};
////int c = a + b;
////switch (c)
////{
////    case 0: Console.WriteLine("OK"); break;
////    case 10: Console.WriteLine("OOOK"); break;
////    default: Console.WriteLine("KOOOOOO {0}", c); break;
////}
int h;
int ab;
Console.WriteLine("Nhap chieu cao tam giac");
h = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap chieu dai day tam giac");
ab = int.Parse(Console.ReadLine());
for (int i = 0; i < h; i++)
{
    for (int j = 0; j < ab; j++)
    {
        if (j > (ab - 1) / 2 - i/* * (ab - 1) / (2 * (h - 1))*/ && j < (ab - 1) / 2 + i /** (ab - 1) / (2 * (h - 1)) || i == h - 1*/) //Điều kiện cuối cùng đảm bảo được chiều dài đáy như đã nhập, tuy nhiên việc cộng trừ vào một đơn vị i có thể không cho ra một tam giác trong nhiều trường hợp
        {//Những điều kiện bị khóa bằng comment trong trường hợp chiều cao lớn hơn đáy cho ra hình lâu đài vì các phép tính chỉ lấy số nguyên, có thể làm lại đầy đủ bằng cách phân case hoặc phương pháp tương tự
            Console.Write("*");
        }
        else { Console.Write(" "); }
    }
    Console.WriteLine();
}

