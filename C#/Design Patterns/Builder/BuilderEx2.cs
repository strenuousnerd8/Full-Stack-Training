using System;
using System.Collections.Generic;

namespace BuilderExample
{
    public interface computerBuilder
    {
        public abstract void buildParts();
        public abstract void connectCords();
        public abstract void installOS();
    }

    public class ConcreteBuilder : computerBuilder
    {
        private Computer computer = new Computer();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.computer = new Computer();
        }

        public void buildParts()
        {
            this.computer.Add("Processor");
            this.computer.Add("Random Access Memory");
            this.computer.Add("Solid State Drive");
            this.computer.Add("Motherboard");
        }

        public void connectCords()
        {
            this.computer.connect("Processor", "Motherboard");
            this.computer.connect("Random Access Memory", "Motherboard");
            this.computer.connect("Motherboard", "PowerSupply");
            this.computer.connect("Solid State Drive", "Motherboard");
            this.computer.connect("Graphics Processing Unit", "Motherboard & PowerSupply");
            this.computer.connect("Power cords", "Cabinet & Motherboard");
        }

        public void installOS()
        {
            this.computer.Add("Windows 11");
        }

        public Computer GetComp()
        {
            Computer res = this.computer;

            this.Reset();

            return res;
        }
    }

    public class Computer
    {
        private List<object> _parts = new List<object>();
        private Dictionary<string, string> cords = new Dictionary<string, string>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public void connect(string a, string b)
        {
            this.cords.Add(a, b);
        }

        public string ListCords()
        {
            string connections = string.Empty;
            foreach (KeyValuePair<string, string> cord in cords)
            {
                connections += cord.Key + " connects to " + cord.Value + "\n";
            }
            return connections;
        }

        public string ListParts()
        {
            string str = string.Empty;
            str += "\t";

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + "\n\t\t";
            }

            return "Product parts: " + str + "\n";
        }
    }

    public class Director
    {
        private computerBuilder _builder;

        public computerBuilder Builder
        {
            set { _builder = value; }
        }

        public void AssembledComputer()
        {
            this._builder.buildParts();
            this._builder.connectCords();
        }

        public void AssembledComputerWOS()
        {
            this._builder.buildParts();
            this._builder.connectCords();
            this._builder.installOS();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("-------------------Assembled Computer-------------------");
            director.AssembledComputer();
            Console.WriteLine(builder.GetComp().ListParts());

            Console.WriteLine("--------Assembled Computer with Pre-installed OS--------");
            director.AssembledComputerWOS();
            Console.WriteLine(builder.GetComp().ListParts());

            Console.WriteLine("--------------------Connecting parts--------------------");
            director.AssembledComputerWOS();
            Console.WriteLine(builder.GetComp().ListCords());
        }
    }
}