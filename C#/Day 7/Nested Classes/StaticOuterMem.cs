using System;

public class OuterClass
{
    public int number = 10;
    public static int value = 20;
    public class InnerClass
    {
        public static bool display()
        {
            Console.WriteLine(value);
            return true;
        }
    }
}


class DriverClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine(OuterClass.InnerClass.display());
        Console.WriteLine(OuterClass.value);
    }
}