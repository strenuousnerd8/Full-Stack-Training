using System;

class Hello
{
    static void Main(string[] args)
    {
        string example = "This is a test string";

        if (example.Contains("This is"))
        {
            Console.WriteLine("Contains the 'This is' sequence");
        } else
        {
            Console.WriteLine("Does not contain the sequence given");
        }
    }
}