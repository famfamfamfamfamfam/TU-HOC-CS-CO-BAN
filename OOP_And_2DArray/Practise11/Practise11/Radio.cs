using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise11
{
    internal class Radio : Appliance, IRemoteControl
    {
        public void VolumeUp()
        {
            Console.WriteLine("Dang tang am luong Radio len");
        }
        public void VolumeDown()
        {
            Console.WriteLine("Dang giam am luong Radio xuong");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Bat Radio");
        }
        public override void TurnOff()
        {
            Console.WriteLine("Tat Radio");
        }
    }
}
