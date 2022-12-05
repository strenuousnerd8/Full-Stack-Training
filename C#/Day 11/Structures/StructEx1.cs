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
        P1.Name = "Vishal Kuntrapakam";
        P1.Age = 23;
        P1.Weight = 80;

        Console.WriteLine("Data Stored in P1 is " +
                           P1.Name + ", age is " +
                           P1.Age + " and weight is " +
                           P1.Weight);
 
    }
}