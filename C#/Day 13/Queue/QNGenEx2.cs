using System;
using System.Collections;

class Hello
{
    public static void Main()
    {
        Queue q = new Queue();
        q.Enqueue(1);
        q.Enqueue("Two");
        q.Enqueue('3');
        q.Enqueue(true);

        Console.WriteLine(q.Count);
        Console.WriteLine("The last element is:\t" + q.Peek());

        foreach (object s in q)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine(q.Contains(true));

        
        Console.WriteLine();

        Console.WriteLine(q.Contains("Two"));
        Console.WriteLine(q.Dequeue());

        Console.WriteLine();

        foreach (object o in q)
        {
            Console.WriteLine(o);
        }
    }
}