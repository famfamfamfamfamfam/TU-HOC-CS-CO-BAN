using Practise2;

Dog chocon = new Dog();
Console.WriteLine("Ten, tuoi, giong cho la gi?");
chocon._name = Console.ReadLine();
chocon._age = Convert.ToInt32(Console.ReadLine());
chocon._breed = Console.ReadLine();
chocon.DisplayInfo();
chocon.MakeSound();