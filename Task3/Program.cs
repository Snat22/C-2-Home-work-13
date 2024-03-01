
using Task3;

var dog = new Dog();
System.Console.Write("Dog name: ");
dog.SetName(Console.ReadLine());
System.Console.WriteLine(dog.GetName());
dog.Eat();