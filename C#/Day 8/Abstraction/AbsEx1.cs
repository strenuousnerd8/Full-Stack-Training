using System;
abstract class Base
{
    public abstract void baseSound();
}

class derived : Base
{
    public override void baseSound()
    {
        Console.WriteLine("The derived says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        derived myderived = new derived();
        myderived.baseSound();
    }
}