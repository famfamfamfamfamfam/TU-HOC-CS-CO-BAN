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
///