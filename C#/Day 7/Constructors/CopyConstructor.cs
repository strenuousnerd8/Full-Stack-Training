using System;

class MonthAndYear
{
    public string month = string.Empty;
    public int year;
    
    // Copy Constructor
    public MonthAndYear(MonthAndYear obj)
    {
        this.month = obj.month;
        this.year = obj.year;
    }
    public MonthAndYear()
    {
        Console.WriteLine("Pass your Month and Year");
    }
}

class Hello
{
    static void Main(string[] args)
    {
        MonthAndYear abc = new MonthAndYear();
        abc.month = "January";
        abc.year = 2022;

        MonthAndYear xyz = new MonthAndYear(abc);
        // Direct copying using assignment operator
        MonthAndYear pqr = abc;

        Console.WriteLine(abc.year + " " + xyz.month);
        Console.WriteLine(xyz.year + " " + abc.month);
        Console.WriteLine(pqr.year + " " + pqr.month);
    }
}