using System;
class A
{
    public A()
    {
        Console.WriteLine("Greetings from A !\nHo ho ho");
    }
}
class B : A
{
    public B() : base() { }
}
class Test
{
    public static void Main(string[] args)
    {
        B b = new B();
    }
}