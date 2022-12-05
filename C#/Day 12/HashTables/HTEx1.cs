using System;
using System.Collections;
 
class Hello {
    static public void Main()
    {
        
        Hashtable my_hashtable1 = new Hashtable();
        
        my_hashtable1.Add("A1", "Welcome");
        my_hashtable1.Add("A2", "to");
        my_hashtable1.Add("A3", "Hashtables");
 
        Console.WriteLine("Key and Value pairs from my_hashtable1:");
 
        foreach(DictionaryEntry ele1 in my_hashtable1)
        {
            Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
        }
        
        Hashtable my_hashtable2 = new Hashtable() {
                                      {1, "hello"},
                                          {2, 234},
                                        {3, 230.45},
                                         {4, null}};
 
        Console.WriteLine("Key and Value pairs from my_hashtable2:");
 
        foreach(var ele2 in my_hashtable2.Keys)
        {
            Console.WriteLine("{0}and {1}", ele2,
                            my_hashtable2[ele2]);
        }
    }
}