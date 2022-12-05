using System;

public class Hello
{
    public void Display<T>(T msg)
    {
        Console.WriteLine("{0}", msg);
    }
}

public class Example
{
    public static int Main()
    {
        Hello p = new Hello();

        p.Display<int>(122);
        p.Display<char>('H');
        p.Display<double>(255.67);
        return 0;
    }
}