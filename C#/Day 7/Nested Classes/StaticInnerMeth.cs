using System;

public class OuterClass
{
    public class InnerClass
    {
        public static bool display()
        {
            Console.WriteLine("This is the inner class!");
            return true;
        }
    }
}


class DriverClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine(OuterClass.InnerClass.display());
    }
}