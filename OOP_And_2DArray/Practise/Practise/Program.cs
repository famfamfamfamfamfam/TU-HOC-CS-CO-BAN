using Practise;

Person nguoidautien = new Person();
Console.WriteLine("Cho biet ten, tuoi, dia chi nguoi dau tien:");
nguoidautien._name = Console.ReadLine();
nguoidautien._age = Convert.ToInt32(Console.ReadLine());
nguoidautien._address = Console.ReadLine();
nguoidautien.DisplayInfo();
//string ten = nguoidautien._name;
//int tuoi = nguoidautien._age;
//string diachi = nguoidautien._address;
//Console.WriteLine("Truy xuat ten, tuoi, dia chi nguoi nay:" + ten + tuoi + diachi);
