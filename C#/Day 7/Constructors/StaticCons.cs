using System;

class Stats
{
    public Stats()
    {
        Console.WriteLine("Public constructor invoked!");
    }

    static Stats()
    {
        Console.WriteLine("Static constructor invoked!");
    }
}

class Hello
{
    static void Main(string[] args)
    {
        Stats statistics = new Stats();
    }
}