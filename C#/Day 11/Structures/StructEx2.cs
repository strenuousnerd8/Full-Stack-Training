using System;
 
public struct Person
{
    public string Name;
    public int Age;
    public int Weight;
 
}
 
class Test {
    static void Main(string[] args)
    {
        Person P1;
 
        P1.Name = "Anil Chaurasiya";
        P1.Age = 23;
        P1.Weight = 80;
         
        Person P2;
         
         P2 = P1;
 
        Console.WriteLine("Values Stored in P1");
        Console.WriteLine("Name: " +P1.Name);
        Console.WriteLine("Age: " +P1.Age);
        Console.WriteLine("Weight: " +P1.Weight);
        Console.WriteLine("");
         
        Console.WriteLine("Values Stored in P2");
        Console.WriteLine("Name: " +P2.Name);
        Console.WriteLine("Age: " +P2.Age);
        Console.WriteLine("Weight: " +P2.Weight);
                            
    }
}