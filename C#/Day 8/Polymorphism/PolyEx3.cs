using System;
class A
{
    public A()
    {
        Console.WriteLine("Greetings from A !\nHo ho ho");
    }
    public A(int x, int y)
    {
        Console.WriteLine("You've Entered 2 Integer Values!");
    }
}
class B : A
{
    public B() : base() { }
    public B(int x, int y) : base(x, y) { }
}
class Test
{
    public static void Main(string[] args)
    {
        B b = new B();
        B b2 = new B(12, 21);
    }
}