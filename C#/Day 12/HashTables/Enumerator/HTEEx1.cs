using System;
using System.Collections;

class Hello
{
    public static void Main()
    {
        Hashtable myhash = new Hashtable();

        myhash.Add("A", "Apple");
        myhash.Add("B", "Banana");
        myhash.Add("C", "Cat");
        myhash.Add("D", "Dog");
        myhash.Add("E", "Elephant");
        myhash.Add("F", "Fish");

        IDictionaryEnumerator myEnumerator = myhash.GetEnumerator();

        while (myEnumerator.MoveNext())
            Console.WriteLine(myEnumerator.Key + " --> "
                              + myEnumerator.Value);
    }
}