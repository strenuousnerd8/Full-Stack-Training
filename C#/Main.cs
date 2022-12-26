using System;
namespace PrototypeExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Man m1 = new Man("Rony");
            Man m2 = (Man)m1.Clone();
            Console.WriteLine($"Cloned: {m1.Name}");
            Woman w1 = new Woman("Monica");
            Woman w2 = (Woman)w1.Clone();
            Console.WriteLine($"Cloned: {w1.Name}");
        }
    }

    public abstract class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
        public abstract Person Clone();
    }

    public class Man : Person
    {
        public Man(string name)
            : base(name)
        {
        }
        public override Person Clone()
        {
            return (Person)this.MemberwiseClone();
        }
    }

    public class Woman : Person
    {
        public Woman(string name)
            : base(name)
        {
        }
        public override Person Clone()
        {
            return (Person)this.MemberwiseClone();
        }
    }
}