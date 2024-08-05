//Console.WriteLine("Hello, World!");

//static float TinhDiemTrungBinh()
//{
//    int diemtoan, diemvan, diemanh;
//    bool B1, B2, B3;
//P:
//    Console.WriteLine("Nhap diem toan:");
//    B1 = int.TryParse(Console.ReadLine(), out diemtoan);
//    Console.WriteLine("Nhap diem van:");
//    B2 = int.TryParse(Console.ReadLine(), out diemvan);
//    Console.WriteLine("Nhap diem anh:");
//    B3 = int.TryParse(Console.ReadLine(), out diemanh);
//    if (B1 == false || B2 == false || B3 == false)
//    {
//        Console.WriteLine("Vui long nhap lai:");
//        goto P;
//    }
//    return((float)(diemanh + diemtoan + diemvan) / 3);
//}

//static void ThongTinHocSinh(int sobaodanh)
//{
//    if (sobaodanh <= 100)
//    {
//        Console.WriteLine("Ho ten Nguyen Thi Thu Huyen\nGioi tinh Nu\nNgay sinh 03/05/2005");
//        Console.WriteLine("Da ghi nhan");
//        Console.WriteLine("Diem trung binh: {0}", TinhDiemTrungBinh());
//    }
//    else
//    {
//        Console.WriteLine("Ho ten Tran Ba Quang\nGioi tinh Nam\nNgay sinh 08/04/2005");
//        Console.WriteLine("Da ghi nhan");
//        Console.WriteLine("Diem trung binh: {0}", TinhDiemTrungBinh());
//    }
//}

//int sobaodanh;
//bool ROR;
//W: Console.WriteLine("Nhap so bao danh:");
//ROR = int.TryParse(Console.ReadLine(), out sobaodanh);
//if (ROR == false) { goto W; }
//ThongTinHocSinh(sobaodanh);


//int[] diemso = new int[3];
//float tinhdiem=0;
//int i = 0;
//Console.WriteLine("Nhap diem so cua sinh vien");
//for (; i < diemso.Length; i++)
//{
//    diemso[i] = int.Parse(Console.ReadLine());
//}
//i = 0;
//for (; i < diemso.Length; i++)
//{
//    tinhdiem += diemso[i];
//}
//Console.WriteLine(tinhdiem/3);

//string[] s = new string[4];
//int i = 0;
//for (; i < s.Length; i++)
//{
//    s[i] = Console.ReadLine();
//}
//Console.WriteLine("So sinh vien da cap nhat ten la: " + i);

int[] songuyen = new int[10];
int tongsochan = 0;
int max = int.MinValue;
int sosole = 0;
for (int i = 0; i <songuyen.Length; i++)
{
    songuyen[i]=int.Parse(Console.ReadLine());
    if (songuyen[i] % 2 == 0)
    {
        tongsochan += songuyen[i];
    }
    else sosole++;
    if (max < songuyen[i])
    {
        max=songuyen[i];
    }
    //if ((i + 1) < songuyen.Length && (songuyen[i] > songuyen[i + 1]))
    //{
    //    int doicho = songuyen[i];
    //    songuyen[i] = songuyen[i + 1];
    //    songuyen[i + 1] = doicho;
    //} Đặt sai vị trí, chưa ra khỏi tầm vực của for, giá trị nhập vào của mảng chưa được áp dụng, mặc định mọi phần từ mảng đều bằng 0 
}
for (int i = 0;i < songuyen.Length;i++)
{
    for (int j = 0;j < songuyen.Length;j++)
    {
        if ((j + 1) < songuyen.Length && (songuyen[j] > songuyen[j + 1]))
        {
            int doicho = songuyen[j];
            songuyen[j] = songuyen[j + 1];
            songuyen[j + 1] = doicho;
        }

    }
}

//for (int i = 0; i < songuyen.Length - 1; i++)
//{
//    for (int j = 0; j < songuyen.Length - 1; j++)
//    {
//        if (songuyen[j] > songuyen[j + 1])
//        {
//            // Khai báo và sử dụng biến tạm để hoán đổi hai phần tử
//            int doicho = songuyen[j];
//            songuyen[j] = songuyen[j + 1];
//            songuyen[j + 1] = doicho;
//        }
//    }
//}

for (int i = 0; i<songuyen.Length;i++)
{
    Console.WriteLine(songuyen[i]);
}
Console.WriteLine("Tong cac so chan trong mang: " + tongsochan);
Console.WriteLine("So cac so le co trong mang: " + sosole);
Console.WriteLine("So lon nhat trong mang: " + max);
