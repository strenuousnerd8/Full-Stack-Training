using System;

class Hello
{
    static void Main(string[] args)
    {
        char c = '$';
        int i = 127;
        Console.WriteLine("Decimal: {0:D}", i);
        Console.WriteLine("Scientific : {0:E}", i);
        Console.WriteLine("Currency : {0:C} {1}", c, i);
        Console.WriteLine("Percentage : {0:P}", i);
        Console.WriteLine("Hexadecimal : {0:X}", i);
    }
}