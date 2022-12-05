using System;

class Hello
{
    enum Months
    {
        January, February, March, April, May, June, July, August
    }
    public static void Main(string[] args)
    {
        int myVar = (int)Months.May;
        Console.WriteLine(myVar);
    }
}