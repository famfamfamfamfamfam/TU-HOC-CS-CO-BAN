using Practise5;

BankAccount dongtien = new BankAccount();
dongtien.Deposit(Convert.ToDouble(Console.ReadLine()));
dongtien.WithDraw(Convert.ToDouble(Console.ReadLine()));
dongtien.GetBalance();