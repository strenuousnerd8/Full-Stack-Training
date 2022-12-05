using System;

class Hello
{
    public static void Main(string[] args)
    {
        // Accessing the array elements using indices
        string[,,] strArray = {
            {
                { "My", "name" },
                { "is", "Faiz" }
            },
            {
                { "Nice", "to" },
                { "meet", "you" }
            }
        };

        Console.WriteLine("Element at [0][0][0]:\t" + strArray[0, 0, 0]);
        Console.WriteLine("Element at [0][0][1]:\t" + strArray[0, 0, 1]);
        Console.WriteLine("Element at [0][1][0]:\t" + strArray[0, 1, 0]);
        Console.WriteLine("Element at [0][1][1]:\t" + strArray[0, 1, 1]);

        Console.WriteLine();
        Console.WriteLine("Element at [1][0][0]:\t" + strArray[1, 0, 0]);
        Console.WriteLine("Element at [1][0][1]:\t" + strArray[1, 0, 1]);
        Console.WriteLine("Element at [1][1][0]:\t" + strArray[1, 1, 0]);
        Console.WriteLine("Element at [1][1][1]:\t" + strArray[1, 1, 1]);

    }
}