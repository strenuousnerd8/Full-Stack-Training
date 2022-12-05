using System;

public class OuterClass
{
    public string greet = "This is the outer class";
    public void Display()
    {
        Console.WriteLine(greet);
    }
    public class InnerClass
    {
        public InnerClass()
        {
            OuterClass obj = new OuterClass();
            obj.Display();
        }
    }
}


class DriverClass
{
    public static void Main(string[] args)
    {
        OuterClass.InnerClass obj = new OuterClass.InnerClass();
    }
}