using System;
using System.Collections;

class Hello
{
    public static void Main()
    {
        Stack s = new Stack();

        s.Push("Zero");
        s.Push('0');
        s.Push(1);
        s.Push(2);
        s.Push(true);
        s.Push(21.3F);

        Console.WriteLine("Number of elements in Stack:\t" + s.Count);

        foreach (object o in s) { 
            Console.WriteLine(o);
        }

        Console.WriteLine();

        Console.WriteLine(s.Contains('0'));
        Console.WriteLine(s.Pop());

        Console.WriteLine();

        foreach (object o in s)
        {
            Console.WriteLine(o);
        }
    }
}