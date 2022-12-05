using System;
using System.Collections;
using System.Collections.Generic;

class Hello
{
    public static void Main()
    {
        Stack<float> temperatures = new Stack<float>();
        temperatures.Push(15.6F);
        temperatures.Push(34.4F);
        temperatures.Push(42.2F);
        temperatures.Push(12.3F);
        temperatures.Push(26.8F);

        Console.WriteLine("No of elements in Stack:\t" + temperatures.Count);
        Console.WriteLine();

        foreach (float f in temperatures)
        {
            Console.WriteLine(f + "deg Celcius");
        }
    }
}