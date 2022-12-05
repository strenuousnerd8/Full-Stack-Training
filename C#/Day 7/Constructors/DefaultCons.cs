using System;

class Greetings
{
    public Greetings()
    {
        Console.WriteLine("Hello!");
    }
}

class Hello
{
    static void Main(string[] args)
    {
        Greetings greet = new Greetings();
    }
}