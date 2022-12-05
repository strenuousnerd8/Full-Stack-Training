using System;

class Hello
{
    static void concatenate(string a, string b, string c)
    {
        Console.Write(a + " " + b + " " + c);
    }
    public static void Main(string[] args)
    {
        // Concatenating strings using named parameters
        concatenate(a: "Conquer", b: "From", c: "Within!");
    }
}