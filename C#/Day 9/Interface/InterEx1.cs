using System;

interface Animal
{
    void animalSound();
}

class Cow : Animal
{
    public void animalSound()
    {
        Console.WriteLine("The cow says: mooooo");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cow newCow = new Cow();
        newCow.animalSound();
    }
}