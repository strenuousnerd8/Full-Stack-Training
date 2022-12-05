using System;

class Hello
{
    static void value(string s1)
    {
       if (s1 == "Dog")
        {
            Console.WriteLine("Value is Dog before changing");
        }
        s1 = "Cat";
    }
    public static void Main(string[] args)
    {
        // Creating a string
        string name = "Dog";
        value(name);
        Console.Write("The value is still " + name);
    }
}