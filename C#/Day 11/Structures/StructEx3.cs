using System;
public struct Address
{
    public string City;
    public string Country;
}
 
struct Person
{
    public string Name;
    public int Age;
    public Address A1;
}
 
class Test {
    static void Main(string[] args)
    {
        Person p1;
 
        p1.Name = "Kunterpukesh";
        p1.Age = 12;
         
        p1.A1.City = "Rome";
        p1.A1.Country = "Italy";
         
        Console.WriteLine("Values Stored in p1");
        Console.WriteLine("Name: " +p1.Name);
        Console.WriteLine("Age: " +p1.Age);
        Console.WriteLine("City: " +p1.A1.City);
        Console.WriteLine("State: " +p1.A1.State);
 
    }
}