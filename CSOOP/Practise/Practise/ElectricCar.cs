using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class ElectricCar : Car
    {
        //Tạo một lớp ElectricCar kế thừa từ lớp Car.
        //    Thêm thuộc tính BatteryCapacity và phương thức DisplayBatteryInfo để in dung lượng pin của xe.
        //    Tạo một đối tượng của lớp ElectricCar và gọi cả DisplayInfo và DisplayBatteryInfo.
        private int BatteryCapacity;
        public int _batto
        {
            get { return BatteryCapacity; }
            set {BatteryCapacity = value;}
        }
        public void DisplayBatteryInfo(int batto)
        {
            BatteryCapacity = batto;
            Console.WriteLine(BatteryCapacity);
        }

    }
}
