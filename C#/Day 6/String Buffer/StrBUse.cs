using System;
using System.Text;

class Hello
{
    static void Main(string[] args)
    {
        string str = "I'm Immutable";
        StringBuilder s = new StringBuilder("I'm Mutable", 20);

        Console.WriteLine(str);
        Console.WriteLine(s);
    }
}