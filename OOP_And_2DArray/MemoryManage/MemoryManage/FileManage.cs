using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManage
{
    internal class FileManage : IDisposable
    {
        public FileManage()
        {
            Console.WriteLine("Tao tai nguyen");
        }
        ~FileManage()
        {
            Dispose();
        }
        public string status {  get; private set; }
        public string OpenFile()
        {
            status = "Tap tin dang duoc mo";
            return status;
        }
        public string CloseFile()
        {
            status = "Tap tin da duoc dong";
            return status;
        }
        public void Dispose()
        {
            if (status=="Tap tin dang duoc mo")
            {
                Console.WriteLine(CloseFile());
            }
            Console.WriteLine("Giai phong tai nguyen");
            GC.SuppressFinalize(this);
        }
    }
}
