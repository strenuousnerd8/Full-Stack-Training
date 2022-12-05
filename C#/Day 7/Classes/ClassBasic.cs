using System;

class Box
{
    public double height;
    public double width;
    public double length;
}

class Hello
{
    static void Main(string[] args)
    {
        Box newBox = new Box();
        newBox.height = 20;
        newBox.width = 70;
        newBox.length = 50;

        Console.WriteLine(newBox.height * newBox.width * newBox.length);
    }
}