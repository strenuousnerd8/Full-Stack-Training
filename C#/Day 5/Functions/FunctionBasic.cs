using System;

class Hello
{
    static string concat(string s1, string s2)
    {
        return s1 + s2;
    }
    public static void Main(string[] args)
    {
        // Creating two strings
        string firstName = "Faizahamed ";
        string lastName = "Akkiwat";
        string fullName = concat(firstName, lastName);
        Console.Write(fullName);
    }
}