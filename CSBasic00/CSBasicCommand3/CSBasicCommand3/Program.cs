////// See https://aka.ms/new-console-template for more information
////goto No;
////Console.WriteLine("Hello, World!");
////Console.WriteLine("Hello, World!");
////Console.WriteLine("Hello, World!");
////No: Console.WriteLine(Console.ReadLine());
////int a = 6;
////switch (a)
////{
////    case 1:
////        Console.WriteLine("JDHF");
////        break;
////    case 6:
////        Console.WriteLine("weufrhu");
////        goto case 1;
////}

////Console.WriteLine("Vui long nhap chinh xac chu Come in: ");
////string a = Console.ReadLine();
////if (a == "Come in")
////{
////    Console.WriteLine("Xin cam on!");
////}
////else
////{
////    Console.WriteLine();
////X:
////    goto K;
////K: Console.WriteLine("ERROR!");
////    goto X;
////}

//bool duyet0, duyet1;
//int a, b;
//Q:
//Console.WriteLine("Nhap chieu dai: ");
//duyet0 = int.TryParse(Console.ReadLine(), out a);
//Console.WriteLine("Nhap chieu rong: ");
//duyet1 = int.TryParse(Console.ReadLine(), out b);
//if (duyet0 == false || duyet1 == false)
//{
//    Console.WriteLine("Nhap lai:");
//    goto Q;
//}
//for (int i = 0; i < b; i++)
//{
//    for (int j = 0; j < a; j++)
//    {
//        if (j == 0 || j == (a - 1) || i == 0 || i == (b - 1))
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.Write("*");
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine();
//}

////int N = 10;
////int M = 20;

////char drawChar = '*';
////char insideChar = ' ';


////// Vẽ từ trên xuống
////for (int i = 0; i < N; i++)
////{
////    // Vẽ từ trái sang
////    for (int j = 0; j < M; j++)
////    {
////        /*
////         * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
////         * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
////         * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
////         * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
////         * thì vẽ ra ký tự của hình chữ nhật
////         * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
////        */

////        if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M - 1) == 0)))
////        {
////            Console.Write(drawChar);    // lúc này là ký tự *
////        }
////        else
////        {
////            Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
////        }
////    }
////    //mỗi lần vẽ xong một hàng thì xuống dòng
////    Console.WriteLine();
////}
////Console.ReadKey();

//int hangngang = 10;
//int hangdoc = 5000;
//int randmin = 0;
//int randmax = 500;
//int i = 0;
//int j = 0;
//Random randnum = new Random();
//while (i < hangdoc)
//{
//    while (j < hangngang)
//    {
//        int rd = randnum.Next(randmin, randmax);
//        Console.Write("{0,10}", rd);
//        j++;
//    }
//    Console.WriteLine();
//    i++;
//    j = 0;
//}

//bool a0, b0;
//int a, b, ngang = 0, doc = 0;
//NG:
//Console.WriteLine("Nhap canh 1:");
//a0 = int.TryParse(Console.ReadLine(), out a);
//Console.WriteLine("Nhap canh 2:");
//b0 = int.TryParse(Console.ReadLine(), out b);
//if (a0 == false || b0 == false)
//{
//    Console.WriteLine("Loi. Nhap lai:");
//    goto NG;
//}
//while (doc < b)
//{
//    while (ngang < a)
//    {
//        if (ngang == 0 || ngang == (a - 1) || doc == 0 || doc == (b - 1))
//        {
//            Console.Write("*");
//        }
//        else
//            Console.Write(" ");
//            ngang++;
//    }
//    Console.WriteLine();
//    doc++;
//    ngang = 0;
//}

//int d = 0;
//int a = 3;
////while (d > a)
////{
////    Console.WriteLine(d);
////    d++;
////}

//do
//{
//    Console.WriteLine(d);
//    d++;
//} while (d > a);

bool Kk, k02;
int day, duongcao;
T:
Console.WriteLine("Nhap kich thuoc day tam giac can:");
Kk = int.TryParse(Console.ReadLine(), out day);
Console.WriteLine("Nhap kich thuoc duong cao:");
k02 = int.TryParse(Console.ReadLine(), out duongcao);
if (Kk == false || k02 == false)
{
    goto T;
}
int i = 0, j = 0;
for (i = 0; i < duongcao; i++)
{
    for (j = 0; j < day; j++)
    {
        if (j == (day - 1) / 2 && i == 0 || j == ((day - 1) / 2) - ((day - 1) / (2 * /*i **/ (duongcao - i))) || i == duongcao - 1 || j == ((day - 1) / 2) + ((day - 1) / (2 * /*i **/ (duongcao - i)))) // doi duongcao - i thanh duongcao - 1 va bo chu thich cho cac toan tu * i de ra cong thuc
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Éc, thành cái lâu đài??!!! >:))))");

//bool Kk, k02;
//int day, duongcao;
//T:
//Console.WriteLine("Nhap kich thuoc day tam giac can:");
//Kk = int.TryParse(Console.ReadLine(), out day);
//Console.WriteLine("Nhap kich thuoc duong cao:");
//k02 = int.TryParse(Console.ReadLine(), out duongcao);
//if (Kk == false || k02 == false)
//{
//    goto T;
//}
//int i = 0, j = 0;
//for (i = 0; i < duongcao; i++)
//{
//    for (j = 0; j < day; j++)
//    {
//        if (j == (day - 1) / 2 && i == 0 || j == (day - 1) / 2 - i || i == duongcao - 1 && j >= (day - 1) / 2 - i && j <= (day - 1) / 2 + i || j == (day - 1) / 2 + i) //Không giòn khi đường cao lớn hơn đáy 
//        {
//            Console.Write("*");
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine();
//}


