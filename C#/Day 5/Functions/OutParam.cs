using System;

class Hello
{
    static void changeUsingOut(out int number, out int number2)
    {
        number = 40;
        number += number;
        number2 = 160;
    }
    public static void Main(string[] args)
    {
        // Creating a string
        changeUsingOut(out int n, out int m);
        Console.WriteLine("We got the out value: " + n + " for first");
        Console.Write("We got the out value: " + m + " for second");
    }
}