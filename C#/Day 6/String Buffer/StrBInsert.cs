using System;
using System.Text;

class Hello
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hey, ", 15);

        Console.WriteLine(s);
        s.Insert(5, "how are you doing?");
        Console.WriteLine(s);
    }
}