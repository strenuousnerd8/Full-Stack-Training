using System;

class Stats
{
    public static int s = 127;
    public string name = "Gary";
}

class Hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Here is a static member:\t" + Stats.s);

        Stats statistics = new Stats();
        Console.WriteLine("Accessing non-static member using Instance:\t" + statistics.name);
    }
}