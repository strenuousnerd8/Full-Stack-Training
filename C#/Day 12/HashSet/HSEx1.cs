using System;
using System.Collections;
using System.Collections.Generic;

class Hello
{
    static public void Main()
    {
        HashSet<int> hs = new HashSet<int>();

        for (int i = 1; i <= 20; i++) {
            if (i % 2 == 0) hs.Add(i);
        }

        foreach (int i in hs)
        {
            Console.WriteLine(i);
        }
    }
}