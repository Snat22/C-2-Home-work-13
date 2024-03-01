abstract class Animal
{
    public string Name { get; private set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract void Eat();
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Собака кушает");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите имя собаки:");
        string dogName = Console.ReadLine();

        Dog dog = new Dog();
        dog.SetName(dogName);

        Console.WriteLine("Имя собаки: " + dog.GetName());
        dog.Eat();
    }
}
