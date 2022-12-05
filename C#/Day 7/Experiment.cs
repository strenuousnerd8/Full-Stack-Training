using System;

class Vehicle {
    private int number = 0;
    private string name = string.Empty;
    public int Num 
    {
        get {
            return number;
        }
        set {
            number = value;
        }
    }
    public string Name 
    {
        get {
            return name;
        }
        set {
            name = value;
        }
    }
}

class Bus : Vehicle
{
    public int Wheels = 0;
    public Bus(int numb, string nam, int wheels) 
    {
        Num = numb;
        Name = nam + " Multiaxial Air Suspension";
        Wheels = wheels;
        
    }
}

class DriverClass {
    public static void Main(string[] args) {
        Bus newBus = new Bus(4318, "Mercedes", 6);
        Console.WriteLine("Bus Name:\t" + newBus.Name);
        Console.WriteLine("Bus Number:\tKA 53 E" + newBus.Num);
        Console.Write("Number of wheels:\t" + newBus.Wheels);
    }
}