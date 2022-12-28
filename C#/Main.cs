using System;

namespace Proxy.Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Call();
        }
    }

    public abstract class Client
    {
        public abstract void Call();
    }

    public class Target : Client
    {
        public override void Call()
        {
            Console.WriteLine("Invoked target's Call()");
        }
    }
    
    public class Proxy : Client
    {
        private Target target = new Target();

        public override void Call()
        {
            target.Call();
        }
    }
}