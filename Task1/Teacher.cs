namespace Task1;

public class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }

    public string Explain()
    {
        return "The teacher is explaining";
    }
}

