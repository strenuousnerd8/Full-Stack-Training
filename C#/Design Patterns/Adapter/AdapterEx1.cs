using System;
namespace AdapterExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
        }
    }

    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }

    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}