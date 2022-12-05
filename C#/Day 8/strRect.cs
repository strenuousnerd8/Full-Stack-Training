using System;

class Rectangle
{
    public double length;
    private double width;
    internal double width1;

    public void AcceptDetails()
    {
        Console.WriteLine("Enter Length:\t");
        length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Width:\t");
        width = Convert.ToDouble(Console.ReadLine());
    }
    
    public double GetArea()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Area: {GetArea()}");
    }
}

class StringProg
{
    public static void Main(string[] args)
    {
        string str = "This is test";

        if (str.Contains("This is test"))
        {
            Console.WriteLine("The sequence was found.");
        }

        string s1 = "Hello";
        string s2 = (string)s1.Clone();
        Console.WriteLine(s1);
        Console.WriteLine(s2);

        Rectangle r = new Rectangle();
        r.AcceptDetails();
        r.Display();

        Console.WriteLine(r.length);
        Console.WriteLine(r.width1);
    }
}