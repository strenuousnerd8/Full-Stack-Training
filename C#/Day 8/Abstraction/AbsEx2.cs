using System;
public abstract class Shape
{
    public abstract void draw();
}
public class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing Rectangle!");
    }
}
public class Circle : Rectangle
{
    public override void draw()
    {
        Console.WriteLine("Drawing Circle!");
    }
}
class Test
{
    public static void Main(string[] args)
    {
        Shape s;
        s = new Rectangle();
        s.draw();
        s = new Circle();
        s.draw();
    }
}