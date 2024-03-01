using System.Security.Cryptography.X509Certificates;

namespace Task1;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual void ToString()
    {
        
    }
}
