using System;

class Tank
{
    double t_radius;
    double t_height;
    public double Radius
    {
        get
        {
            return t_radius;
        }
        set
        {
            t_radius = value < 0 ? -value : value;
        }
    }

    public double Height
    {
        get
        {
            return t_height;
        }
        set
        {
            t_height = value < 0 ? -value : value;
        }
    }

    public void DisplayDimension()
    {
        Console.WriteLine("The radius of tank is:\t" + Radius
                + " and the height of tank is:\t" + Height);
    }
}

// A derived class AreaOfTank inheriting Tank Class
class AreaOfTank : Tank
{
    string Color;
    public AreaOfTank(string c, double r, double h)
    {
        Radius = r;
        Height = h;
        Color = c;
    }

    public double Area()
    {
        return 2 * 3.14 * Radius * Height;
    }

    public void DisplayColor()
    {
        Console.WriteLine("The Color of tank is "
                                        + Color);
    }
}

class Driver
{
    static void Main()
    {
        // Create and initialize the object of AreaOfTank
        AreaOfTank t1 = new AreaOfTank("Green", 6.0, 12.0);
        t1.DisplayColor();
        t1.DisplayDimension();
        Console.WriteLine("Area is " + t1.Area());
    }
}