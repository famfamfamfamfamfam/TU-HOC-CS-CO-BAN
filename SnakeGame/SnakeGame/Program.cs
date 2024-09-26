using System;
using System.Runtime.Versioning;
namespace SNAKEGAME
{
    public class TheFirst
    {
        public static void Main(string[] args)
        {
            int n = 0;
            Frame();
            if (Console.KeyAvailable)
            {//xem xet them thoi gian ngung
                for (int i = 1; i < 19; i++)
                {
                    for (int j = 1; j < 39; j++)
                    {
                        ConsoleKeyInfo k = Console.ReadKey(true);
                        while (true)
                        {
                            Move(ref k, ref i, ref j, ref n);
                        }
                    }
                }
            }

        }
        public static void Frame()
        {
            for (int i = 0; i < 20 ; i++)
            {
                for (int j = 0;j <40;j++)
                {
                    if(i == 19||j==39||i==0||j==0)
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
        }
        public static void Move(ref ConsoleKeyInfo key, ref int i, ref int j, ref int n)
        {
            if(key.Key==ConsoleKey.RightArrow)// kiem tra truong hop ran hinh vuong
            {
                int n0 = n;
                int k0 = 3 - 1 - n;
                for (int k = j; k < j + 3; k++)
                {
                    Console.SetCursorPosition(k, i);//xuat hien cap nhat ghi de, khong muot ma
                    Console.Write('O');
                    System.Threading.Thread.Sleep(100);
                    Console.Write('O');
                    Console.SetCursorPosition(k, i);
                    Console.Write('o');

                    if (i + n0 < 20)
                    {
                        if (j + k0 < 40)
                        {
                            Console.SetCursorPosition(j + k0, i + n0);
                            Console.Write(' ');
                        }
                        if (j - k0 > 0)
                        {
                            Console.SetCursorPosition(j - k0, i + n0);
                            Console.Write(' ');
                        }
                    }
                    if (i - n0 > 0)
                    {
                        if (j + k0 < 40)
                        {
                            Console.SetCursorPosition(j + k0, i - n0);
                            Console.Write(' ');
                        }
                        if (j - k0 > 0)
                        {
                            Console.SetCursorPosition(j - k0, i - n0);
                            Console.Write(' ');
                        }
                    }
                    if (n0 > 0)
                    {
                        k0--;
                    }
                    if (k0 == 0)
                    {
                        n0--;
                    }
                    System.Threading.Thread.Sleep(100);

                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey(true);
                    }
                    if (key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.LeftArrow)
                    {
                        n = k - j;
                        j = k;
                        return;
                    }
                }
                while (true)
                {

                    Console.SetCursorPosition(j + 3, i);
                    Console.Write('O');
                    Console.SetCursorPosition(j + 2, i);
                    Console.Write('o');
                    Console.SetCursorPosition(j, i);
                    Console.Write(' ');
                    j++;

                    System.Threading.Thread.Sleep(100);
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey(true);
                    }
                    if (key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.LeftArrow)
                    {
                        j += 3;
                        n = 3 - 2;
                        return;
                    }
                }

            }
            if(key.Key==ConsoleKey.LeftArrow)
            {
                int k0 = 3 - 1 - n;
                int n0 = n;
                for (int k = j; k > j - 3; k--)
                {
                    Console.SetCursorPosition(k, i);
                    Console.Write('O');
                    System.Threading.Thread.Sleep(100);
                    Console.SetCursorPosition(k - 1, i);
                    Console.Write('O');
                    Console.Write('o');

                    if (j - k0 > 0)
                    {
                        if (i + n0 < 20)
                        {
                            Console.SetCursorPosition(j - k0, i + n0);
                            Console.Write(' ');
                        }
                        if (i - n0 > 0)
                        {
                            Console.SetCursorPosition(j - k0, i - n0);
                            Console.Write(' ');
                        }
                    }
                    if (j + k0 < 40)
                    {
                        if (i + n0 < 20)
                        {
                            Console.SetCursorPosition(j + k0, i + n0);
                            Console.Write(' ');
                        }
                        if (i - n0 > 0)
                        {
                            Console.SetCursorPosition(j + k0, i - n0);
                            Console.Write(' ');
                        }
                    }
                    if (k0 == 0)
                    {
                        n0--;
                    }
                    else
                    {
                        k0--;
                    }
                    System.Threading.Thread.Sleep(100);

                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey(true);
                    }
                    if (key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.LeftArrow)
                    {

                    }
                }
                while (true)
                {
                    Console.SetCursorPosition(j - 3, i);
                    Console.Write('O');
                    Console.SetCursorPosition(j - 2, i);
                    Console.Write('o');
                    Console.SetCursorPosition(j, i);
                    Console.Write(' ');
                    j--;

                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey(true);
                    }
                    if (key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.LeftArrow)
                    {

                    }
                }
            }
        }
    }
}