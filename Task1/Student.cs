namespace Task1;

public class Student : Person
{
    public Student(string name) : base(name)
    {
    }

    public string Study()
    {
        return "The student is studyng";
    }
}
