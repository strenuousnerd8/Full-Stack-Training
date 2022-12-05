using System;
using System.Collections;
 
class Test {
 
    // Main Method
    static public void Main()
    {
 
        // Creating ArrayList
        ArrayList My_array = new ArrayList();
 
        // Adding elements in the
        // My_array ArrayList
        // This ArrayList contains elements
        // of different types
        My_array.Add(12.56);
        My_array.Add("GeeksforGeeks");
        My_array.Add(null);
        My_array.Add('G');
        My_array.Add(1234);
 
        // Accessing the elements
        // of My_array ArrayList
        // Using foreach loop
        foreach(var elements in My_array)
        {
            Console.WriteLine(elements);
        }
    }
}