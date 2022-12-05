using System;

interface I1
{
    void greet();
}

interface I2
{
    void greet();
}

class C : I1, I2
{
    public void greet()
    {
        Console.WriteLine("Hello, have a good day!");
    }
}

class Test
{
    public static void Main(String[] args)
    {
        I1 i1 = new C();
        I2 i2 = new C();
        
        i1.greet();
        i2.greet();
    }
}