//#region
////Console.Write("hello, world!");
////Console.Write(10);
////Console.Write(10.6567665f);
////Console.Write(true);
//#endregion
////Console.ReadKey();
////Console.Write("Hello World \n");
////Console.Write(10.988f);
////Console.Write(Environment.NewLine);
////Console.ReadLine();
////Console.WriteLine("Nothing");
////int a = 5;
////Console.WriteLine("a = "+a);
////Console.WriteLine("a = {0}", a);
////Console.WriteLine("a1 = {0}, a2 = {1}, a3 = {2}, {3} - {4}", a, 1, 2, "abc", false);
////int a= Console.Read();
////Console.WriteLine(a);
////Console.Write(Console.Read());
////string a = Console.ReadLine();
////Console.WriteLine(a);
////Console.ReadLine();
////Console.Write("hahahahahah");
////Console.ReadKey(true);

Console.WriteLine("Ten dang nhap: ");
string tendangnhap = Console.ReadLine();
Console.WriteLine("Ho va ten that: ");
string hoten = Console.ReadLine();
Console.WriteLine("Biet danh: ");
char tenviettat = char.Parse(Console.ReadLine());
Console.WriteLine("Nhap diem Toan: ");
float diemtoan = float.Parse(Console.ReadLine());
Console.WriteLine("Nhap diem Van: ");
float diemvan = float.Parse(Console.ReadLine());
float tongdiem = (diemtoan + diemvan) / 2;
Console.WriteLine("Diem trung binh cua nguoi dung {0}, ten that {1}, goi tat bang {2} la: {3}", tendangnhap, hoten, tenviettat, tongdiem);

//bool YN;
//int x, a = 1, b = 23;
//Console.WriteLine("Nhap so vao: ");
//YN = int.TryParse(Console.ReadLine(), out x);
//x = a + b + x;
//Console.WriteLine("Ketqua {0}", x);

//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(x);

bool XO;
Console.WriteLine("MAY TINH TONG, HIEU, TICH, THUONG----");
Console.WriteLine("Nhap so thu nhat: ");
string a = Console.ReadLine();
Console.WriteLine("Nhap so thu hai: ");
string b = Console.ReadLine();
Console.WriteLine("Nhap so thu ba: ");
string c = Console.ReadLine();
int a0, b0, c0;
XO = int.TryParse(a, out a0);
Console.WriteLine(XO == true ? "Khong co gi sai sot" : "yamete");
XO = int.TryParse(b, out b0);
Console.WriteLine(XO == true ? "Tiep tuc phep tinh" : "yamete");
XO = int.TryParse(c, out c0);
Console.WriteLine(XO == true ? "" : "yamete");
//int a0 = int.Parse(a);
//int b0 = int.Parse(b);
//int c0 = int.Parse(c);
int tong = a0 + b0 + c0;
int hieu1 = a0 - b0;
int hieu2 = b0 - c0;
int hieu3 = c0 - a0;
int tich = a0 * b0 * c0;
float thuong1 = (float)a0 / b0;
float thuong2 = (float)b0 / c0;
float thuong3 = c0 / (float)a0;
Console.WriteLine("Tong 3 so la: {0}", tong);
Console.WriteLine("Hieu tung cap so cua 3 so la: {0} {1} {2}", hieu1, hieu2, hieu3);
Console.WriteLine("Tich 3 so la: {0}", tich);
Console.WriteLine("Thuong tung cap so cua 3 so la: {0} {1} {2}", thuong1, thuong2, thuong3);

//int a = 10;
//object a0 = a; //boxing
//int n = (int)a0; //unboxing

//int e = int.Parse(Console.ReadLine());
//object e0 = e;
//int n1 = (int)e0;
//Console.WriteLine(n1);
//Console.WriteLine(e0);