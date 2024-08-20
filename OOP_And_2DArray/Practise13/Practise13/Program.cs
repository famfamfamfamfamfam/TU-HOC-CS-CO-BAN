using Practise13;

//Resource test1 = new Resource();
//test1.Thaotacvoidoituong();
//test1 = null;
//GC.Collect();
//GC.WaitForPendingFinalizers();
using (Resource test1 = new Resource()) //Phương thức Dispose của IDisposable được gọi thông qua khối using, kết thúc using tức đối tượng không còn dùng nữa và phương thức sẽ tự động được gọi
{
    test1.Thaotacvoidoituong();
}
//test1.Dispose(); // Phương thức Dispose của IDisposable được gọi thông qua lệnh gọi thông thường
