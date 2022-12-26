using System;
namespace AdapterExample
{
    public class Provider
    {
        public void Interpret()
        {
            Console.WriteLine("Provider gets JSON");
        }
    }

    public class Client
    {
        public virtual void Send()
        {
            Console.WriteLine("Client sends XML");
        }
    }

    public class Translator : Client
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
            Client client = new Translator();
            client.Send();
        }
    }
}