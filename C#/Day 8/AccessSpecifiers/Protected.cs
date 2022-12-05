using System;
namespace Sample
{

    public class ABC
    {
        protected int Id = 100;
    }

    public class DEF : ABC
    {
        public int Display()
        {
            return Id;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            DEF de = new DEF();
            Console.WriteLine(de.Display());
        }
    }
}