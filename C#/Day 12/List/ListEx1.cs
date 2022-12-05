using System;
using System.Collections.Generic;
  
class Hello 
{
    public static void Main(String[] args)
    {
  
        List<int> firstlist = new List<int>();
        
        firstlist.Add(1);
        firstlist.Add(2);
        firstlist.Add(3);
        firstlist.Add(4);
        
        Console.WriteLine("Capacity Is: " + firstlist.Capacity);
        
        Console.WriteLine("Count Is: " + firstlist.Count);
        
        firstlist.Add(5);
        firstlist.Add(6);
        
        Console.WriteLine("Capacity Is: " + firstlist.Capacity);
        
        Console.WriteLine("Count Is: " + firstlist.Count);
    }
}