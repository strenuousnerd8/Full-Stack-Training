using System;

class Greetings
{
    public string name = string.Empty;
    public Greetings(string name)
    {
        this.name = name;
    }
    public void greet()
    {
        Console.WriteLine("Hello, " + this.name + "!");
    }
    ~Greetings()
    {
        Console.Write("Destructed allocations");
    }
}

class Hello
{
    static void Main(string[] args)
    {
        Greetings person = new Greetings("Jacob");
        person.greet();
    }
}