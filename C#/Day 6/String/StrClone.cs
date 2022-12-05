using System;

class Hello
{
    static void Main(string[] args)
    {
        string name = "Omnicom Media Group";
        string another = (string) name.Clone();

        Console.WriteLine(another);
    }
}