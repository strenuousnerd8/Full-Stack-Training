using System;
using System.Collections;
 
class Test {
 
    static public void Main()
    {
 
        // Creating ArrayList
        ArrayList My_array = new ArrayList();
 
        // Adding elements in the
        // My_array ArrayList
        // This ArrayList contains elements
        // of the same types
        My_array.Add('G');
        My_array.Add('E');
        My_array.Add('E');
        My_array.Add('K');
        My_array.Add('S');
        My_array.Add('F');
        My_array.Add('O');
        My_array.Add('R');
        My_array.Add('G');
        My_array.Add('E');
        My_array.Add('E');
        My_array.Add('K');
        My_array.Add('S');
 
        Console.WriteLine("Initial number of elements : "
                                       + My_array.Count);
 
        // Remove the 'G' element
        // from the ArrayList
        // Using Remove() method
        My_array.Remove('G');
        Console.WriteLine("After Remove() method the "+
              "number of elements: " + My_array.Count);
 
        // Remove the element present at index 8
        // Using RemoveAt() method
        My_array.RemoveAt(8);
        Console.WriteLine("After RemoveAt() method the "+
                "number of elements: " + My_array.Count);
 
        // Remove 3 elements starting from index 1
        // using RemoveRange() method
        My_array.RemoveRange(1, 3);
        Console.WriteLine("After RemoveRange() method the"+
                 " number of elements: " + My_array.Count);
 
        // Remove the all element
        // present in ArrayList
        // Using Clear() method
        My_array.Clear();
        Console.WriteLine("After Clear() method the "+
            "number of elements: " + My_array.Count);
    }
}