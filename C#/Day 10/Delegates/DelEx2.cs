using System;

delegate int Calculator(int n);

class Arithmetic
{

    public static int doubler(int n)
    {
        return n * n;
    }

    public static int halfer(int n)
    {
        return n / 2;
    }


    public static void Main(String[] args)
    {
        Arithmetic calculate = new Arithmetic();

        Calculator doubleit = new Calculator(doubler);
        Calculator halfit = new Calculator(halfer);

        int d = doubleit(5);
        int h = halfit(d);
        Console.WriteLine("Double is: {0}", d);
        Console.WriteLine("Half is: {0} ", h);
    }
}