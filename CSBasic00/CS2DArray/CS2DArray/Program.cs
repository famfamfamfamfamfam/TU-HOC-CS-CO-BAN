//using System.Net.NetworkInformation;

//int hang, cot, tong = 0;
//bool nhap1, nhap2, nhap3;
//GA: Console.WriteLine("Nhap so hang cua mang: ");
//nhap1 = int.TryParse(Console.ReadLine(), out hang);
//Console.WriteLine("Nhap so cot cua mang: ");
//nhap2 = int.TryParse(Console.ReadLine(), out cot);
//if (nhap1 == false || nhap2 == false)
//    goto GA;
//int[,] MANG = new int[hang, cot];
//for (int i = 0; i < MANG.GetLength(0); i++)
//{
//    for (int j = 0; j<MANG.GetLength(1); j++)
//    {
//        GA1: Console.WriteLine("Nhap phan tu o vi tri MANG[{0}, {1}]: ", i, j);
//        nhap3 = int.TryParse(Console.ReadLine(), out MANG[i, j]);
//        if(nhap3 == false) goto GA1;
//    }
//}
//Console.WriteLine("Mang cua ban la:");
//for (int i = 0;i < MANG.GetLength(0);i++)
//{
//    for(int j = 0;j<MANG.GetLength(1);j++)
//    {
//        Console.Write("{0, 10} ", MANG[i, j]);
//        tong = tong + MANG[i, j];
//    }
//    Console.WriteLine();
//}
//Console.WriteLine(tong);

//int[] a = { 1, 2, 5, 3 };
//Array.Reverse(a);
//int b = Array.IndexOf(a, 5);
//Console.WriteLine(b);

//int[,,] E =
//{
//    {
//        { 1,2,4,},
//        { 1,2,4,},
//    },
//    {
//        { 1,2,4,},
//        { 1,2,4,},
//    }
//};
//int[,,] E2 = new int[2,2,3];

////mảng jagged 
//int[][] W = new int[3][];
//W[0] = new int[4];
//W[2] = new int[9];
//// có thể khởi tạo thêm ô nhớ mới một cách ngẫu nhiên từ đó tạo ra tính không liên tiếp
//// trong lưu trữ mảng nhưng vì cơ chế dùng ô nào tạo ô đó nên tiết kiệm ô nhớ
//int[][] W1 =
//{
//    new int[] {4,5,6 ,3},//dùng bao nhiêu
//    new int[] {3,5,6,2,5,7,4,7 }//khai báo, khởi tạo, cấp phát bấy nhiêu
//};// cách khai báo này ngôn ngữ sẽ tự đếm giới hạn mảng nên không cần điền

int d = 0;
int[][] I = new int[2][];
I[0]= new int[3];
I[1]= new int[5];
bool L;
for (int i = 0; i<I.Length; i++)
{
    for (int j = 0; j < I[0].Length ; j++)
    {
    o: Console.WriteLine("Nhap phan tu thu [{0},{1}] cua mang", i, j);
        L = int.TryParse(Console.ReadLine(), out I[i][j]);
        if (L == false)
            goto o;
    }
}
foreach (int[] i in I)
{
    foreach (int i0 in i)
    {
        d += i0;
    }
}
Console.WriteLine("Tong cac phan tu cua mang lom chom I: " + d);