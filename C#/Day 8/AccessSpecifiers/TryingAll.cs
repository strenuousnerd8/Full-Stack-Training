using System;
class A
{
    public int number = 127;
}
class B
{
    protected int number = 3102;

    public int getAccess()
    {
        return number;
    }
}
class C
{
    private int number = 2342;
}

class DriverClass
{
    public static void Main(string[] args)
    {
        A a = new A();
        Console.WriteLine(a.number);
        B b = new B();
        Console.WriteLine(b.getAccess());
        C c = new C();
        //Console.WriteLine(c.number);
    }
}