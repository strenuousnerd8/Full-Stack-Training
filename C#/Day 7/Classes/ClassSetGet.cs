using System;

class Box
{
    public double height;
    public double width;
    public double length;

    // Setters
    public void setHeight(double height)
    {
        this.height = height;
    }
    public void setWidth(double width)
    {
        this.width = width;
    }
    public void setLength(double length)
    {
        this.length = length;
    }

    // Getters
    public double getHeight()
    {
        return this.height;
    }
    public double getWidth()
    {
        return this.width;
    }
    public double getLength()
    {
        return this.length;
    }
}

class Hello
{
    static void Main(string[] args)
    {
        Box newBox = new Box();
        newBox.setHeight(10.34);
        newBox.setWidth(22.23);
        newBox.setLength(12.5311);

        Console.WriteLine(newBox.getHeight() * newBox.getWidth() * newBox.getLength());
    }
}