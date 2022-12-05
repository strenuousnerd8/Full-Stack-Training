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

class DriverClass
{
    public static void Main(string[] args)
    {
        OuterClass.InnerClass IC = new OuterClass.InnerClass();
        IC.display();
    }
}