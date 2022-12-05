using System;

interface Animal
{
    void animalSound();
}

interface AnimalFamily 
{
    void family();
}

class Cow : Animal, AnimalFamily
{
    public void animalSound()
    {
        Console.WriteLine("The cow says: Mooooo");
    }
    public void family() 
    {
        Console.WriteLine("The cow belongs to: Herbivorous");
    }
}

class Lion : Animal, AnimalFamily
{
    public void animalSound()
    {
        Console.WriteLine("The cow says: Rawwrrrrrr");
    }
    public void family() 
    {
        Console.WriteLine("The cow belongs to: Carnivorous");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cow newCow = new Cow();
        newCow.animalSound();
        newCow.family();

        Lion newLion = new Lion();
        newLion.animalSound();
        newLion.family();
    }
}