//string s1, s2, s4, s5, s6, s7 = "";
//string s = Console.ReadLine();
//s1 = s.Trim();
//while (s1.IndexOf("  ") != -1)
//{
//    s1 = s1.Replace("  ", " ");
//}
//for (int i = 0; i < s1.Length; i++)
//{
//    //s2 = s1[i].ToString(); định dùng trim() :v
//    if (s1[i] < 'A' || s1[i] > 'Z' && (s1[i] < 'a' || s1[i] > 'z'))
//    {
//        s1 = s1.Replace(s1[i], ' ');
//    }
//}
//string[] s3 = s1.Split(' ');
//for (int i = 0; i < s3.Length; i++)
//{
//    s4 = s3[i].Substring(0, 1);
//    s5 = s3[i].Substring(1);
//    s6 = s4.ToUpper() + s5.ToLower();
//    s7 += s6 + " ";
//}
//s7 = s7.Trim();
//Console.WriteLine(s7);

////using System.Text;
////string e = "shkgbsujgfh";
////StringBuilder S = new StringBuilder(e);
////StringBuilder F = new StringBuilder("kfbhiefhf");
////F.AppendLine(e); Console.Write(F);
////S.Append(e); Console.WriteLine(S);


//static void Nhapthongtin(ref ThongtinNhanVien NV)
//{
//    bool MM, MN;
//    Console.WriteLine("Nhap ho ten:");
//    NV.hoten = Console.ReadLine();
//    GT: Console.WriteLine("Nhap ma nhan vien:");
//    MM = int.TryParse(Console.ReadLine(), out NV.maso);
//    if (MM == false) goto GT;
//    GT1: Console.WriteLine("Nhap so ngay nghi trong thang:");
//    MN = int.TryParse(Console.ReadLine(), out NV.songaynghi);
//    if (MN == false) goto GT1;
//    NV.diemchuyencan = 3 - (0.1f*NV.songaynghi);
//}

//static float luongthang(ThongtinNhanVien luong)
//{
//    float luong1;
//    luong1 = luong.luongcong * 10 * luong.diemchuyencan;
//    return luong1;
//}
//ThongtinNhanVien NV00 = new ThongtinNhanVien();
//Nhapthongtin(ref NV00);
//Console.WriteLine("Nhan vien {0} co ma so {1}, nghi {2} ngay co so diem chuyen can la: {3}", NV00.hoten, NV00.maso, NV00.songaynghi, NV00.diemchuyencan);
//Console.WriteLine("Luong cua anh/chi thang nay la: {0}", luongthang(NV00));
//struct ThongtinNhanVien()
//{
//    public int maso;
//    public float diemchuyencan;
//    public int songaynghi;
//    public int luongcong = 200000;
//    public string hoten;
//}

static void TinhTongGiaTriTonKho()
{
    float S = 0;
    SanPham searchfor = new SanPham();
    SanPham[] Xet = new SanPham[0];
    ThemSanPham(ref searchfor, ref Xet);
    for (int i = 0; i < Xet.Length; i++)
    {
        var k = Xet[i];
        S = S + k.gia * k.soluongtonkho;
    }
    Console.WriteLine("Gia tri ton kho len den "+S);
}
static void TimSanPhamGiaCaoNhat()
{
    SanPham dat = new SanPham();
    SanPham[] MNG = new SanPham[0];
    ThemSanPham(ref dat, ref MNG);
    int chuama=0;
    string chuaten="";
    for (int i = 0; i < (MNG.Length - 1); i++)
    {
        var trich = MNG[i];
        var kiem = MNG[i + 1];
        if (trich.gia<=kiem.gia)
        {
            chuama = kiem.masanpham;
            chuaten = kiem.tensanpham;
        }
        else
        {
            chuama = trich.masanpham;
            chuaten = trich.tensanpham;
        }
    }
    Console.WriteLine("San pham {0} ma so {1} co gia cao nhat", chuaten, chuama);
}

static void XuatThongTinSanPham()
{
    SanPham sanPham = new SanPham();
    SanPham[] aRR = new SanPham[0];
    ThemSanPham(ref sanPham, ref aRR);
    for (int i = 0; i < aRR.Length; i++)
    {
        var truyxuat = aRR[i];
        sanPham.hienthithongtinsanpham(truyxuat.masanpham, truyxuat.tensanpham, truyxuat.gia, truyxuat.soluongtonkho);
    }
}

static void ThemSanPham(ref SanPham thongtin, ref SanPham[] Arr)
{
    bool kt, kt1, kt2, kt3;
    int moi;
AG: Console.WriteLine("So dau san pham moi:");
    kt3 = int.TryParse(Console.ReadLine(), out moi);
    Arr = new SanPham[moi];
    if (kt3 == false || moi < 0) goto AG;
    for (int i = 0; i < moi; i++)
    {
        do
        {
            Console.WriteLine("Nhap ma san pham:");
            kt = int.TryParse(Console.ReadLine(), out thongtin.masanpham);
        } while (kt == false);
       
            Console.WriteLine("Nhap ten san pham:");
            thongtin.tensanpham = Console.ReadLine();
        do
        {
            Console.WriteLine("Nhap gia san pham:");
            kt1 = float.TryParse(Console.ReadLine(), out thongtin.gia);
        } while (kt1 == false);
        do
        {
            Console.WriteLine("Nhap so luong ton kho:");
            kt2 = int.TryParse(Console.ReadLine(), out thongtin.soluongtonkho);
        } while (kt2 == false);
        Arr[i] = thongtin;
    }
    for (int j = 0; j < Arr.Length; j++)
    {
        var ttsp = Arr[j];
        Console.WriteLine("San pham {0} ma so {1} co gia {2} ton kho {3} san pham", ttsp.tensanpham, ttsp.masanpham, ttsp.gia, ttsp.soluongtonkho);
    }

}

struct SanPham
{
    public int masanpham;
    public string tensanpham;
    public float gia;
    public int soluongtonkho;
    public void hienthithongtinsanpham(int msp, string tsp, float g, int sltk)
    {
        masanpham = msp; tensanpham = tsp; gia = g; soluongtonkho = sltk;
        Console.WriteLine("Ma san pham la: "+masanpham);
        Console.WriteLine("Ten san pham la: " + tensanpham);
        Console.WriteLine("Co gia: " + gia);
        Console.WriteLine("Con lai {0} san pham", soluongtonkho);
    }

}