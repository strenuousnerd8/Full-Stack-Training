using System;
using System.Collections;
using System.Collections.Generic;

class Hello
{
    public static void Main(string[] args)
    {
        LinkedList<string> ll = new LinkedList<string>();
        ll.AddFirst("Hello");
        ll.AddFirst("How are you?");
        ll.AddLast("I'm fine, what about you?");
        foreach (object obj in ll) { 
            Console.WriteLine(obj);
        }

        Console.WriteLine(ll.Count);

        ll.Clear();
    }
}