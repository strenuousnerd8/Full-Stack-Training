using System;

class Hello
{
    static void multiply(dynamic any)
    {
        any += any;
        Console.WriteLine(any);
    }
    public static void Main(string[] args)
    {
        // Passing dynamic type values
        multiply(400);
        multiply(90);
        multiply("u");
        multiply("vv");
    }
}