using MemoryManage;

FileManage file1 = new FileManage();
Console.WriteLine(file1.OpenFile());
file1.Dispose(); //Nên sử dụng using (FileMange obj = new...) hơn là gọi thủ công thế này