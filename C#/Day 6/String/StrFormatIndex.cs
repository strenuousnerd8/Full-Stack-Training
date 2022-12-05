using System;

class Hello
{
    static void Main(string[] args)
    {
        int oranges = 2;
        int bananas = 3;
        string apples = "four";

        float x = 5.50F;
        int y = 612;
        int z = 72131;

        Console.WriteLine("{0} oranges, {1} bananas, {2} apples.", oranges, bananas, apples);
        Console.WriteLine("{1} oranges, {2} bananas, {0} apples.", oranges, bananas, apples);

        Console.WriteLine("{0} oranges, {2} bananas, {2} apples.", x, y, z);
        Console.WriteLine();

        Console.WriteLine(1);
        Console.WriteLine(123);
        Console.WriteLine(12345);
        Console.WriteLine("{0, 10}", x);
        Console.WriteLine("{0, 10}", y);
        Console.WriteLine("{0, 10}", z);
    }
}