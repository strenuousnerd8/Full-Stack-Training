using System;

class Hello
{
    static void Main(string[] args)
    {
        string first = "This is a test string";
        string second = "This is a text string";
        string third = "This is a text string";

        int i = 1;

        Console.WriteLine($"{i}, {first}");

        if (first.Equals(second))
        {
            Console.WriteLine("Yes");
        } else
        {
            Console.WriteLine("No");
        }
        if (third == second) {
            Console.WriteLine("Matched!");
        } else
        {
            Console.WriteLine("Not Matched!");
        }
        Console.WriteLine(string.Compare(first, second));
    }
}