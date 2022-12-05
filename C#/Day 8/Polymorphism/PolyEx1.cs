using System;
class A
{
    public virtual void Display()
    {
        Console.WriteLine("Greetings from A !\nHo ho ho");
    }
}
class B : A
{
    public override void Display()
    {
        Console.WriteLine("Greetings from B !\nHo ho ho");
    }
}
class Test
{
    public static void Main(string[] args)
    {
        B b = new B();
        b.Display();
    }
}