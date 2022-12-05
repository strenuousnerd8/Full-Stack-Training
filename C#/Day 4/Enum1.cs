using System;

class Hello
{
    enum Levels
    {
        Low, Medium, High
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(Levels.Medium);
    }
}