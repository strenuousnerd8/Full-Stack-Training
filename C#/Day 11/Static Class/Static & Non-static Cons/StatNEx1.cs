using System;
  
class Test{
    static Test()
    {
        Console.WriteLine("It is static constructor");
    }
    public Test()
    {
        Console.WriteLine("It is non-static constructor");
    }
    static void Main(string[] args)
    {
        Test obj = new Test();
    }
}