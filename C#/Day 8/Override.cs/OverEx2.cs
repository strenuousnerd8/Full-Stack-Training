using System;
class A
{
    public virtual void show()
    {
        Console.WriteLine("Greetings from A !\nHo ho ho");
    }
}
class B : A
{
    public override void show()
    {
        Console.WriteLine("Greetings from B !\nHo ho ho");
    }
}
class Test
{
    public static void Main(string[] args)
    {
        A a = new A();
        a.show();
        a = new B();
        a.show();
    }
}