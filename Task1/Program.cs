
using Task1;

try
{
    

System.Console.Write("Write your name: ");
var teacher1 = new Teacher(Console.ReadLine());
// teacher1.Name = Console.ReadLine();
System.Console.WriteLine(teacher1.Explain());


var std1 = new Student(" ");
System.Console.Write("Write your name: ");
std1.Name = Console.ReadLine();
System.Console.WriteLine(std1.Study());


var std2 = new Student(" ");
System.Console.Write("Write your name: ");
std2.Name = Console.ReadLine();
System.Console.WriteLine(std2.Study());
}
catch (System.Exception)
{
    
    System.Console.WriteLine("Uncorec format: ");
}
