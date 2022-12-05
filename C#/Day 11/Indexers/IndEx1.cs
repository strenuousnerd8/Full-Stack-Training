using System;

class IndexerCreation
{
    private string[] val = new string[3];

    public string this[int index]
    {

        get
        {
            return val[index];
        }

        set
        {
            val[index] = value;
        }
    }
}

class main
{
    public static void Main()
    {
        IndexerCreation ic = new IndexerCreation();

        ic[0] = "C";
        ic[1] = "CPP";
        ic[2] = "CSHARP";

        Console.Write("Printing values stored in objects used as arrays\n");

        Console.WriteLine("First value = {0}", ic[0]);
        Console.WriteLine("Second value = {0}", ic[1]);
        Console.WriteLine("Third value = {0}", ic[2]);

    }
}