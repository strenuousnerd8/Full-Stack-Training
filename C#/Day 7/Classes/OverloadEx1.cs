using System;

class Calculator
{
    public int addNums(int x, int y)
    {
        return x + y;
    }
    public int addNums(int x, int y, int z)
    {
        return x + y + z;
    }
}

class Hello
{
    static void Main(string[] args)
    {
        Calculator calculate = new Calculator();
        Console.WriteLine(calculate.addNums(1, 2));
        Console.WriteLine(calculate.addNums(1, 2, 3));
    }
}