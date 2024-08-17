Console.WriteLine("Nhap kich thuoc giao dien:");
int y = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
string nhapx = "";
char[,] map = new char[y,x];
for (int i = 0; i < y;  i++)
{
    nhapx = Console.ReadLine();
    string[] layx = nhapx.Split('\t');
    for(int j = 0; j < x; j++)
    {
        map[i, j] = Convert.ToChar(layx[j]);
    }
}
for(int i = 1;i < y - 1; i++)
{
    for(int j = 1;j < x - 1; j++)
    {
        if (map[i,j] != '*')
        {
            map[i, j] = '0';
            for (int k = i - 1; k < i + 2; k++)
            {
                for (int l = j - 1; l < j + 2; l++)
                {
                    if (map[k,l]=='*')
                    {
                        map[i, j]++;
                    }
                }
            }
        }
    }
}
for(int j = 1; j < x - 1; j++)
{
    if (map[0, j] != '*')
    {
        map[0,j] = '0';
        if (map[0,j+1]=='*')
        {
            map[0, j]++;
        }
        if(map[0,j-1]=='*')
        {
            map[0, j]++;
        }
    }
    if (map[y - 1,j] != '*')
    {
        map[y-1,j] = '0';
        if (map[y-1,j+1]=='*')
        {
            map[y - 1, j]++;
        }
        if (map[y-1,j-1]=='*')
        {
            map[y-1,j]++;
        }
    }
    for (int l = j -1;l < j + 2; l++)
    {
        if (map[1, l] == '*' && map[0,j]!='*')
        {
            map[0,j]++;
        }
        if(map[y-2,l] == '*' && map[y-1,j]!='*')
        {
            map[y - 1, j]++;
        }
    }
}
for(int i = 1; i < y - 1; i++)
{
    if (map[i,0]!='*')
    {
        map[i,0]='0';
        if(map[i-1,0]=='*')
        {
            map[i, 0]++;
        }
        if (map[i+1,0]=='*')
        {
            map[i,0]++;
        }
    }
    if(map[i,x-1]!='*')
    {
        map[i, x - 1] = '0';
        if(map[i-1,x-1]=='*')
        {
            map[i, x-1]++;
        }
        if (map[i+1,x-1]=='*')
        {
            map[i, x - 1]++;
        }
    }
    for(int k = i-1; k<i+2; k++)
    {
        if (map[k, x - 2] == '*' && map[i,x-1]!='*')
        {
            map[i,x-1]++;
        }
        if (map[k, 1] == '*' && map[i,0]!='*')
        {
            map[i,0]++;
        }
    }
}
if (map[0,0]!='*')
{
    map[0, 0] = '0';
    if (map[0,1]=='*')
    {
        map[0,0]++;
    }
    if (map[1,0]=='*')
    {
        map[0, 0]++;
    }
    if (map[1,1]=='*')
    {
        map[0, 0]++;
    }
}
if (map[y-1,x-1]!='*')
{
    map[y - 1, x - 1] = '0';
    if (map[y-2,x-2]=='*')
    {
        map[y-1,x-1]++;
    }
    if (map[y-1,x-2]=='*')
    {
        map[y - 1, x - 1]++;
    }
    if (map[y-2,x-1]=='*')
    {
        map[y-1,x-1]++;
    }
}
if (map[0,x-1]!='*')
{
    map[0, x - 1] = '0';
    if (map[0,x-2]=='*')
    {
        map[0, x-1]++;
    }
    if (map[1,x-2]=='*')
    {
        map[0, x-1]++;
    }
    if (map[1,x-1]=='*')
    {
        map[0,x-1]++;
    }
}
if (map[y-1,0]!='*')
{
    map[y - 1, 0] = '0';
    if(map[y-2,0]=='*')
    {
        map[y - 1, 0]++;
    }
    if (map[y-1,1]=='*')
    {
        map[y - 1, 0]++;
    }
    if(map[y-2,1]=='*')
    {
        map[y - 1, 0]++;
    }
}
for(int i = 0;i<y;i++)
{
    for(int j = 0;j<x;j++)
    {
        Console.Write(map[i,j]+"\t");
    }
    Console.WriteLine();
}