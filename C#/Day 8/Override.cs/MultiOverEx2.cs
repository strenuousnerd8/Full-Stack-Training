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
class C : B
{
    public override void show()
    {
        Console.WriteLine("Greetings from C !\nHo ho ho");
    }
}
class Test
{
    public static void Main(string[] args)
    {
        A a = new A(); 
        a.show(); // Runs method of class A
        a = new B();
        a.show(); // Runs method of class B
        a = new C();
        a.show(); // Runs method of class C
    }
}