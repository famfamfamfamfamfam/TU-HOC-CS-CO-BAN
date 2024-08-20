Console.WriteLine("Nhap so dong cua ma tran:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap so cot cua ma tran:");
int x = Convert.ToInt32(Console.ReadLine());
char[,] map = new char[y,x];
Console.WriteLine("Nhap ma tran tro choi:");
for (int i = 0; i < y; i++)
{
    string tungdong = Console.ReadLine();
    char[] tungphantu = tungdong.ToCharArray();
    for (int j = 0; j < x; j++)
    {
        map[i,j] = tungphantu[j];
    }
}
for (int i = 0; i < y; i++)
{
    for (int j = 0; j < x; j++)
    {
        int[,] toadovunglancan =
            {
                {i-1, j-1},
                {i-1, j},
                {i-1, j+1},
                {i, j-1},
                {i, j+1},
                {i+1, j-1},
                {i+1, j},
                {i+1, j+1}
            };
        if (map[i,j]!='*')
        {
            map[i, j] = '0';
            for(int tungo = 0; tungo < toadovunglancan.GetLength(0);tungo++)
            {
                int i0 = toadovunglancan[tungo, 0];
                int j0 = toadovunglancan[tungo,1];
                if (i0 >= 0 && i0 < y && j0 >= 0 && j0 < x && map[i0,j0]=='*')
                {
                    map[i, j]++;
                }
            }
        }
    }
}
for(int i = 0; i < y; i++)
{
    for(int j = 0; j < x; j++)
    {
        Console.Write(map[i,j]);
    }
    Console.WriteLine();
}