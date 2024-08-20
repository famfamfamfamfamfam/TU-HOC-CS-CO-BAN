using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise13
{
    internal class Resource : IDisposable
    {
        public Resource()
        {
            Console.WriteLine("Doi tuong cua lop Resource da duoc tao");
        }
        public void Dispose()
        {
            Console.WriteLine("Doi tuong cua lop Resource da bi huy");
            GC.SuppressFinalize(this);
        }
        ~Resource()
        {
            //Console.WriteLine("Doi tuong cua lop Resource da bi huy");
            Dispose(); //Phương thức Dispose có thể được gọi trong hàm hủy hoặc không, nếu gọi sẽ đảm bảo lệnh khi hủy đối tượng được thực hiện kể cả có không gọi Dispose trong chương trình (hàm Main)
        }
        public void Thaotacvoidoituong()
        {
            Console.WriteLine("Nhap vao so nguyen muon so 100 tru cho:");
            int trucho = 100 - Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(trucho);
        }
    }
}
