using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise11
{
    internal class TV : Appliance, IRemoteControl
    {
        public void VolumeUp()
        {
            Console.WriteLine("Dang tang am luong TV len");
        }
        public void VolumeDown()
        {
            Console.WriteLine("Dang giam am luong TV xuong");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Bat TV");
        }
        public override void TurnOff()
        {
            Console.WriteLine("Tat TV");
        }
    }
}
