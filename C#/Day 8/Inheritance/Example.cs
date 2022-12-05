using System;
class A
{
    public void F()
    {
        Console.WriteLine("A.F");
    }
}
class B : A
{
    public void G()
    {
        Console.WriteLine("B.G");
    }
}
class Test
{
    public static void Main(string[] args)
    {
        B b = new B();
        b.F();
        b.G();
        A a = new A();
        a.F();
    }
}