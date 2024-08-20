using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise5
{
    internal class BankAccount
    {
        public ulong AccountNumber { get; set; }
        protected double Balance;

        protected double SetBalance(double value)
        {
            if (value <= Balance)
                Balance = Balance - value;
            return Balance;
        }

        public string OwnerName { get; set; }

        public double Deposit(double money)
        {
            if (money>0)
            Balance = Balance + money;
            return Balance;
        }

        public void WithDraw(double money)
        {
            if (Balance < money)
            {
                Console.WriteLine("Khong hop le");
            }
            SetBalance(money);
        }

        public void GetBalance()
        {
            Console.WriteLine("So du cua tai khoan hien tai la: "+Balance);
        }

    }
}
