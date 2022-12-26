using System;
namespace AdapterExample
{
    public class Provider
    {
        public void Interpret()
        {
            Console.WriteLine("Provider Console");
        }
    }

    public class Client
    {
        public virtual void Send()
        {
            Console.WriteLine("Client console");
        }
    }

    public class Agent : Client
    {
        private Provider provider = new Provider();

        public override void Send()
        {
            provider.Interpret();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Agent();
            client.Send();
        }
    }
}