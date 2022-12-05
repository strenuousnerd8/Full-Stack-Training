using System;
using System.Collections;
 
class Test {
    public static void Main() {
        
        // Creating an ArrayList
        ArrayList myList = new ArrayList();
        
        // Adding elements to ArrayList
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);
        
        // Displaying count of elements of ArrayList
        Console.WriteLine("Number of elements: " + myList.Count);
        
        // Displaying Current capacity of ArrayList
        Console.WriteLine("Current capacity: " + myList.Capacity);
    }
}