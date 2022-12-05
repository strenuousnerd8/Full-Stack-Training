using System;
using System.Text;

class Hello
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello ", 20);

        Console.WriteLine(s);
        s.Append("Team, How are you?");
        Console.WriteLine(s);
    }
}