using System;

class Hello
{
    static void Main(string[] args)
    {
        DateTime time = DateTime.Now;

        Console.WriteLine("Short Time : {0:t}", time);
        Console.WriteLine("Long Time : {0:T}", time);
        Console.WriteLine("Short Date : {0:d}", time);
        Console.WriteLine("Long Date : {0:D}", time);
        Console.WriteLine("Month : {0:M}", time);
        Console.WriteLine("Year: {0:Y}", time);
    }
}