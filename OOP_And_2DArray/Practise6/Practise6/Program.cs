using Practise6;

//Car xeoto = new Car();
//Bicycle xedap = new Bicycle();
//xeoto.Move();
//xedap.Move();
IMovable[] cacdoituong = { new Car(), new Bicycle() };
foreach (IMovable item in cacdoituong)
{
    item.Move();
}