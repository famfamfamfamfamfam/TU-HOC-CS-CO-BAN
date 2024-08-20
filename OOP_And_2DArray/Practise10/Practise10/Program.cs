using Practise10;

/*double maluc = Convert.ToDouble(Console.ReadLine());
string dongxe = Console.ReadLine();*/
Car xe1 = new Car(/*maluc, dongxe*/);
xe1.Engine.Type = Console.ReadLine();
xe1.Engine.HorsePower = Convert.ToDouble( Console.ReadLine() );
xe1.DisplayInfo();