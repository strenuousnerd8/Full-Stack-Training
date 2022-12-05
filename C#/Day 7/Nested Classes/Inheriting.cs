using System;

public class OuterClass
{
    public void display()
    {
        Console.WriteLine("This is the outer class!");
    }
    public class InnerClass
    {
        public InnerClass()
        {
            Console.WriteLine("Inner Class Constructor Invoked!");
        }
        public void display()
        {
            Console.WriteLine("This is the inner class!");
        }
    }
}

public class Exclass : OuterClass
{
    public void meth()
    {
        Console.WriteLine("Ex Class Method");
    }
}

class DriverClass
{
    public static void Main(string[] args)
    {
        Exclass obj = new Exclass();
        obj.meth();
        obj.display();
    }
}