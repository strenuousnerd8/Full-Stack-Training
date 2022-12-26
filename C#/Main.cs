using System;
namespace PrototypeExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Man m1 = new Man("Rony");
            Man m2 = (Man)m1.Duplicate();
            Console.WriteLine($"Original: {m1.Name}");
            Console.WriteLine($"Duplicated: {m2.Name}");
            Woman w1 = new Woman("Monica");
            Woman w2 = (Woman)w1.Duplicate();
            Console.WriteLine($"Original: {w1.Name}");
            Console.WriteLine($"Duplicated: {w2.Name}");
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
        public abstract Person Duplicate();
    }

    public class Man : Person
    {
        public Man(string name)
            : base(name)
        {
        }
        public override Person Duplicate()
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
        public override Person Duplicate()
        {
            return (Person)this.MemberwiseClone();
        }
    }
}