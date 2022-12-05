using System;

class Hello
{
    static void Main(string[] args)
    {
        string s1 = "hello";
        string s2 = "HELLO";
        string s3 = "single";
        string s4 = "Multiple";
        string s5 = "hello";

        Console.WriteLine(string.Compare(s1, s2));

        Console.WriteLine(string.Compare(s2, s3));

        Console.WriteLine(string.Compare(s3, s4));

        Console.WriteLine(string.Compare(s4, s1));

        if (string.Compare(s1, s5) == 0) {
            Console.Write("Matched!");
        }
    }
}