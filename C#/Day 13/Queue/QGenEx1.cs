using System;
using System.Collections;
using System.Collections.Generic;

class Hello
{
    public static void Main()
    {
        Queue<string> q = new Queue<string>();
        q.Enqueue("Hello");
        q.Enqueue(", Welcome");
        q.Enqueue("to");
        q.Enqueue("Queues");

        Console.WriteLine(q.Count);
        Console.WriteLine("The last element is:\t" + q.Peek());

        foreach (string s in q)
        {
            Console.WriteLine(s);
        }
    }
}