using System;

class Stats
{
    public static int s = 127;
    public static string Display()
    {
        return "How are you doing?";
    }
}

class Hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("We can access:\t" + Stats.s);
        Console.WriteLine(Stats.Display());
    }
}