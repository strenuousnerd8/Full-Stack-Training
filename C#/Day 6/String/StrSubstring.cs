using System;

class Hello
{
    static void Main(string[] args)
    {
        string example = "Last night I dreamt of San Pedro";

        Console.WriteLine(example.Substring(15));
        Console.WriteLine(example.Substring(0, 10));
        Console.WriteLine(example.Substring(5, 10));
    }
}