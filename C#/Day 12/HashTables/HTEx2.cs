using System;
using System.Collections;

class Hello
{

    static public void Main()
    {
        Hashtable my_hashtable = new Hashtable();

        my_hashtable.Add("A1", "Welcome");
        my_hashtable.Add("A2", "to");
        my_hashtable.Add("A3", "Hashtables");

        Console.WriteLine(my_hashtable.Contains("A3"));
        Console.WriteLine(my_hashtable.Contains(12));
        Console.WriteLine();

        Console.WriteLine(my_hashtable.ContainsKey("A1"));
        Console.WriteLine(my_hashtable.ContainsKey(1));
        Console.WriteLine();

        Console.WriteLine(my_hashtable.ContainsValue("geeks"));
        Console.WriteLine(my_hashtable.ContainsValue("to"));
    }
}