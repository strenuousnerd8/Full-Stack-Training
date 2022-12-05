using System;

class Hello
{
    static void refer(ref string s1)
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
        refer(ref name);
        Console.Write(name);
    }
}