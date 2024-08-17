//string s = Console.ReadLine();
//int k = int.Parse(Console.ReadLine());
//Console.WriteLine(s[k - 1]);

//string s = "ABCDEF";
//Console.WriteLine(s[3]);
//for(int i=0; i<s.Length;i++)
//    Console.WriteLine(s[i]);

//string s = Console.ReadLine();
//char c = char.Parse(Console.ReadLine());
//int d = 0;
//for (int i = 0; i < s.Length; i++)
//{
//    if (c == s[i])
//        d++;
//}
//Console.WriteLine(d);

//string s=Console.ReadLine();
//char c = char.Parse(Console.ReadLine());
//int a = -1;
//for (int i=0; i<s.Length;i++)
//{
//    if (s[i] == c)
//    {
//        a=i+1;
//        break;
//    }
//}
//Console.WriteLine(a);

//string s = "youandI";
//Console.WriteLine(s.Replace("and", "or"));
//Console.WriteLine(s.Replace("I", "me"));
//Console.WriteLine(s.Replace('I', 'X'));
//string s1 = s.Replace("I", "yourself");
//Console.WriteLine(s1);

//string s = "ChuNghia";
//string s0 = s.ToLower();
//string s1 = s.ToUpper();

//string s = "truthordare";
//string A = "or";
////Console.WriteLine(s.IndexOf(A));
////Console.WriteLine(A.IndexOf("o"));
//if (s.StartsWith(A)==true)
//    {
//    Console.WriteLine("correcr");
//}
//else
//{
//    Console.WriteLine(s);
//}
//if (A.EndsWith("r") == true)
//{
//    Console.WriteLine("correct");
//}
//else Console.WriteLine("no");
//string[] s0 = s.Split("or");
////for (int i= 0; i < s0.Length; i++)
//    Console.WriteLine(s0[0]);
//Console.WriteLine(s.Substring(0,5));
//Console.WriteLine(s.Substring(2));

//Console.WriteLine("Nhap chuoi lon: ");
//string s1 = Console.ReadLine();
//Console.WriteLine("Nhap chuoi nho: ");
//string s2 = Console.ReadLine();
//string s01 = s1.ToUpper();
//string s02 = s2.ToUpper();
//Console.WriteLine(s01.IndexOf(s02));

//string s = Console.ReadLine();
//for (char c ='0'; c<='9'; c++)
//{
//    s = s.Replace(c + "", "");
//}
//Console.WriteLine(s);

//using System.Net;

//string s = Console.ReadLine();
//int dem = 0;
//for (char r = 'A'; r <= 'Z';  r++)
//{
//    for (int i = 0; i < s.Length; i++)
//    {
//        if (s[i] == r)
//        {
//            dem++;
//        }
//    }
//}
//Console.WriteLine(dem);

//string s = Console.ReadLine();
//for (int i = s.Length - 1; i >= 0; i--)
//{
//    Console.Write(s[i]);
//}

//string s = Console.ReadLine();
//for (char c = '0'; c <= '9'; c++)
//{
//    s = s.Replace(c + "", "");
//}
//Console.WriteLine(s);
////Vòng lặp lặp lại 10 lần, mỗi lần duyệt qua một giá trị của c trên toàn bộ string s và thực thi lệnh replace
//int a = 0;
//if ((cachanghinhhoc)a == cachanghinhhoc.congthucdientich)
//Console.WriteLine((int)cachanghinhhoc.thu);
//Console.WriteLine(a);//ép kiểu, đã chỉ sửa theo debug cho hết lỗi
//enum cachanghinhhoc
//{
//    thu,
//    sopi = 4,
//    congthucdientich,
//    donvithetich
//}
//using System.ComponentModel.DataAnnotations;

//static string Daonguocchuoikytu(string s)
//{
//    if (s.Length == 1) return s[0].ToString();
//    return s[s.Length - 1] + Daonguocchuoikytu(s.Substring(0, s.Length - 1));
//}

//static int Tinhtong(int[] arr)
//{
//    if (arr.Length == 1) return arr[0];
//    int[] arrr = new int[arr.Length-1];
//    Array.Copy(arr,0, arrr, 0, arr.Length - 1);
//    return arr[arr.Length-1] + Tinhtong(arrr);
//}

//static int TimSoLonNhat(int[] arr)
//{
//    if (arr.Length == 1) return arr[0];
//    int mx = TimSoLonNhat(arr[1..]); // bằng với Array.Copy(arr, 1, tenmangcon, 0, arr.Length - 1)
//    return Math.Max(arr[0], mx); //Lớp Math hỗ trợ
//}
//using System;

//namespace MANGMOTCHIEU
//{
//    class ThemPhanTuVaoMang
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Nhap so phan tu cua mang:");
//            int n = int.Parse(Console.ReadLine());
//            int[] mang = new int[n + 1];
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("Phan tu vi tri {0}: ", i);
//                mang[i] = int.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("Nhap so muon chen vao mang:");
//            int sochen = int.Parse(Console.ReadLine());
//            Console.WriteLine("Nhap vi tri muon chen vao mang:");
//            int vitri = int.Parse(Console.ReadLine());
//            if (vitri < 0 || vitri >= (n + 1)) return;
//            for (int i = n; i >= vitri; i--)
//            {
//                if (i==0) break;
//                mang[i] = mang[i - 1];
//            }
//            mang[vitri] = sochen;
//            for (int i = 0; i < n + 1; i++)
//            {
//                Console.WriteLine(mang[i]);
//            }
//        }
//    }
//}
char[,] map = { {'.','.','*','.'},
    {'.','.','.','*'},
    {'*','*','.','.'},
    {'.','.','.','.'} };
int y = map.GetLength(0);
int x = map.GetLength(1);
int[,] mapgoc = new int[,] { {0,0,y-1,y-1},{0,x-1,0,x-1} };
int[] arr0 = new int[] {-1, 0, 1};
int[] arr1 = {-1,0,1};
for (int xx = 0; xx < mapgoc.GetLength(1); xx++)
{
    if (map[mapgoc[1,xx],mapgoc[0,xx]] != '*')
    {
        map[mapgoc[1, xx], mapgoc[0, xx]] = '0';
        for (int i = 0; i < arr0.Length; i++)
        {
            for (int j = 0; j < arr1.Length; j++)
            {
                int y0 = arr0[i] + mapgoc[1,xx];
                int x0 = arr1[j] + mapgoc[0, xx];
                if (y0 >= 0 && y0 < y && x0 < x && x0 >= 0 && map[y0, x0] == '*')
                {
                    map[mapgoc[1, xx], mapgoc[0, xx]]++;
                }
            }
        }
    }
}