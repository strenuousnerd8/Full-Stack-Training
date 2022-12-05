using System;

class Hello
{
    static void Main(string[] args)
    {
        string[] strings =
        {
            "A quick brown",
            "fox jumps over",
            "the lazy dog!"
        };

        Console.WriteLine(string.Join("\n", strings));
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", strings));
    }
}