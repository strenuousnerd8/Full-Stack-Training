using System;
using System.Text;

class Hello
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("The total bill amount is: ", 15);
        char c = '$';
        Console.WriteLine(s);
        s.AppendFormat("{0:C} {1}", c, 127);
        Console.WriteLine(s);
    }
}