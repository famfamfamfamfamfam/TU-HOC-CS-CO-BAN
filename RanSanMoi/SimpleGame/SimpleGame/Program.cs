using System;
namespace RANSANMOI
{
    public class TheGame
    {
        public static void Main(string[] args)
        {
            List<char> list = new List<char>() { 'O', 'o', 'o', 'o', 'o' };
            RePhai(list, 10, 1,30);
        }
        static char[,] Khung(out int chieurong, out int chieucao)
        {
            chieurong = 40;
            chieucao = 20;
            char[,] khung = new char[chieucao, chieurong];
            for (int i = 0; i < chieucao; i++)
            {
                for (int j = 0; j < chieurong; j++)
                {
                    if (j == 0 || j == chieurong - 1 || i == 0 || i == chieucao - 1)
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
            return khung;
        }
        static List<char> ConRan()
        {
            List<char> conran = new List<char>();
            for (int i = 0; i <= conran.Count; i++)
            {
                if (i != 0)
                {
                    conran[i] = 'o';
                    conran.Add(conran[i]);
                }
                else
                {
                    conran.Add('O');
                    break;
                }
            }
            return conran;
        }
        static void RePhai(List<char> conran, int docaore, int dorongretrai, int dorongrephai)
        {
            int chieurong, chieucao;
            char[,] khung = Khung(out chieurong, out chieucao);
            for (int i = dorongretrai; i < conran.Count + dorongretrai; i++)
            {
                khung[docaore, i] = conran[0];
                Console.SetCursorPosition(i, docaore);
                Console.Write(khung[docaore, i]);
                if (i > dorongretrai)
                {
                    for (int j = dorongretrai; j < i; j++)
                    {
                        khung[docaore, j] = conran[1];
                        Console.SetCursorPosition(j, docaore);
                        Console.Write(khung[docaore, j]);
                    }
                }
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                Khung(out chieurong, out chieucao);

            }
            for (int i = conran.Count + dorongretrai; i <= dorongrephai; i++)
            {
                for (int j = 0; j < conran.Count; j++)
                {
                    khung[docaore, i - j] = conran[j];
                    Console.SetCursorPosition(i - j, docaore);
                    Console.Write(khung[docaore, i - j]);
                }
                System.Threading.Thread.Sleep(100);
                if (i == dorongrephai) break;
                Console.Clear();
                Khung(out chieurong, out chieucao);
            }
            for(int i = dorongrephai - conran.Count; i <= dorongrephai; i++) //fixing
            {
                khung[docaore, dorongrephai] = conran[1];
                Console.SetCursorPosition(dorongrephai, docaore);
                Console.Write(khung[docaore, dorongrephai]);
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                Khung(out chieurong, out chieucao);
            }
        }
        static void AnMoi()
        {
            //goi ham DiChuyen
            Random moi = new Random();
            //RE:xmoi = moi.Next(1,chieurong);
            //ymoi = moi.Next(1,chieucao);
            //if (khung[ymoi,xmoi]==" ") khung[ymoi,xmoi]="o";
            //else goto RE;
        }
    }
}