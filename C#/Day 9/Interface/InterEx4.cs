using System;

interface Race
{
    void speed();
    void distance();
}

class car1 : Race
{

    public void speed() {
        Console.WriteLine("Speed:\t173MPH");
    }
    public void distance()
    {
        Console.WriteLine("Distance:\t92MPH");
    }
}

class car2 : Race
{

    public void speed()
    {
        Console.WriteLine("Speed:\t150MPH");
    }
    public void distance()
    {
        Console.WriteLine("Distance:\t120MPH");
    }
}

class Test
{

    public static void Main(String[] args)
    {

        Race r;
        r = new car1();
        r.speed();
        r.distance();
        r = new car2();
        r.speed();
        r.distance();
    }
}