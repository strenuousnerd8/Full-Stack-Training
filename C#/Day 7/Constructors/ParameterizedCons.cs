using System;

class Greetings
{
    public Greetings(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}

class Hello
{
    static void Main(string[] args)
    {
        Greetings greet = new Greetings("Faiz");
    }
}