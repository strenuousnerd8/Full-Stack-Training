using System;
using System.Text;

class Hello
{
    static void stringConcat(string a, string b)
    {
        a = string.Concat(a, b);
    }
    static void StringBuilderConcat(StringBuilder s)
    {
        s.Append(" Media Group");
    }
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Omnicom", 15);
        string s1 = "Media";
        string s2 = "Group";

        stringConcat(s1, s2);
        Console.WriteLine(s1);

        StringBuilderConcat(s);
        Console.Write(s);
    }
}