using System;

class Calculator
{
    public int addTwo(int x, int y)
    {
        return x + y;
    }
    public double addTwo(double x, double y)
    {
        return x + y;
    }
    public float addTwo(float x, float y)
    {
        return x + y;
    }
}

class Hello
{
    static void Main(string[] args)
    {
        Calculator calculate = new Calculator();

        Console.WriteLine("Integers:\t" + calculate.addTwo(34, 15));
        Console.WriteLine("Double Values:\t" + calculate.addTwo(232.32, 432.23));
        Console.WriteLine("Float Values:\t" + calculate.addTwo(58.23F, 19.36F));
    }
}