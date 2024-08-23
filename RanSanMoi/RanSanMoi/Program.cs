using System;
using System.Security.Cryptography.X509Certificates;
namespace DUANGAME
{
    class RanSanMoi
    {
        public static void Main(string[] args)
        {
            List<char> ran = new List<char>() { 'O', 'o', 'o', 'o' };
            for (int i = 0; i <= 25; i++)
            {
                for (int j = 0; j <= 50; j++)
                {
                    if (i == 0 ||  j == 0 || i == 25 || j == 50)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            #region
            //for (int j = 1; j < 49; j++)
            //{
            //    Console.SetCursorPosition(j, 12);
            //    Console.Write(ran[0]);
            //    Console.SetCursorPosition(j, 12);
            //    Console.Write(" ");
            //    Console.Write(ran[0]);
            //    System.Threading.Thread.Sleep(75);
            //}
            //Console.SetCursorPosition(51, 12);
            //for (int i = 1; i < 24; i++)
            //{
            //    Console.SetCursorPosition(25, i);
            //    Console.Write(ran[0]);
            //    Console.SetCursorPosition(25, i);
            //    Console.Write(' ');
            //    Console.SetCursorPosition(25, i+1);
            //    Console.Write(ran[0]);
            //    System.Threading.Thread.Sleep(75);
            //}
            //Console.SetCursorPosition(25, 26);
            //for (int j = 49; j > 1; j--)
            //{
            //    Console.SetCursorPosition(j,12);
            //    Console.Write(ran[0]);
            //    Console.SetCursorPosition(j, 12);
            //    Console.Write(' ');
            //    Console.SetCursorPosition(j-1, 12);
            //    Console.Write(ran[0]);
            //    System.Threading.Thread.Sleep(75);
            //}
            //for (int i = 24;i > 1; i--)
            //{
            //    Console.SetCursorPosition(25, i);
            //    Console.Write(ran[0]);
            //    System.Threading.Thread.Sleep(75);
            //    Console.SetCursorPosition(25, i);
            //    Console.Write(' ');
            //    //Console.SetCursorPosition(25, i-1);
            //    //Console.Write(ran[0]);
            //    //System.Threading.Thread.Sleep(75);
            //}
            //static void Inlandau(List<char> ran, int j)
            //{
            //    int x = j;
            //    for (int i = ran.Count - 1; i >= 0; i--)
            //    {
            //        Console.SetCursorPosition(x, 12);
            //        Console.Write(ran[i]);
            //        x++;
            //    }
            //}
            //for (int j = 1; j < 46; j++)
            //{
            //    Inlandau(ran, j);
            //    ran.Remove(ran[3]);
            //    ran[0] = ran[1];
            //    ran.Insert(0, 'O');
            //    Console.SetCursorPosition(j, 12);
            //    Console.Write(' ');
            //    Inlandau(ran, j + 1);
            //    System.Threading.Thread.Sleep(100);
            //}
            //Console.SetCursorPosition(0, 26);
            //static void Inran(List<char> ran, int x)
            //{
            //    Console.SetCursorPosition(x,12);
            //    for (int i = 0;i < ran.Count; i++)
            //    {
            //        Console.Write(ran[i]);
            //    }
            //}
            //for (int j = 46; j > 1; j--)
            //{
            //    Inran(ran, j);
            //    ran.Remove(ran[3]);
            //    ran[0] = ran[1];
            //    ran.Insert(0, 'O');
            //    Console.SetCursorPosition(j+3,12);
            //    Console.Write(' ');
            //    Inran(ran, j-1);
            //    System.Threading.Thread.Sleep(75);
            //}
            //static void Inran(List<char> ran, int y)
            //{
            //    for (int i = ran.Count - 1; i >= 0; i--)
            //    {
            //        Console.SetCursorPosition(25, y);
            //        Console.Write(ran[i]);
            //        y++;
            //    }
            //}
            //for (int i = 1; i < 21; i++)
            //{
            //    Inran(ran, i);
            //    ran.Remove(ran[3]);
            //    ran[0] = ran[1];
            //    ran.Insert(0, 'O');
            //    Console.SetCursorPosition(25, i);
            //    Console.Write(' ');
            //    Console.SetCursorPosition(25, i + 4);
            //    Inran(ran, i + 1);
            //    System.Threading.Thread.Sleep(75);
            //}
            //Console.SetCursorPosition(0, 26);
            #endregion
            static void Resangphai(List<char> ran, int j, int i)
            {
                int i0 = i;
                int j0 = j;
                for (int d = 0; d < ran.Count; d++)
                {
                    Console.SetCursorPosition(j, i0 + /*2*/1);
                    Console.Write(' ');
                    Console.SetCursorPosition(j0, i /*- 1*/+4);
                    Console.Write(ran[1]);
                    Console.Write('O');
                    i0/*--*/++;
                    j0++;
                }
            }
            static void Inran(List<char> ran, int y)
            {
                for (int i = ran.Count - 1; i >= 0; i--)
                {
                    Console.SetCursorPosition(25, y);
                    Console.Write(ran[i]);
                    y++;
                }
            }
            for (int i = 1; i < 21; i++)
            {
                Inran(ran, i);
                ran.Remove(ran[3]);
                ran[0] = ran[1];
                ran.Insert(0, 'O');
                Console.SetCursorPosition(25, i);
                Console.Write(' ');
                Console.SetCursorPosition(25, i + 4);
                Inran(ran, i + 1);
                System.Threading.Thread.Sleep(75);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        for (int j = 25; j < 46; j++)
                        {
                            Resangphai(ran, j, i);
                            System.Threading.Thread.Sleep(100);
                        }
                        return;
                    }
                }
            }
        }
    }
}