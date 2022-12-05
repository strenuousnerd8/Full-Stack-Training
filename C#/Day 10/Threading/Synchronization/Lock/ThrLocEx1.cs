using System;  
using System.Threading;  
namespace LockDemo
{
  class LockDisplay  
  { 
    public void DisplayNum()  
    { 
        lock (this)  
        { 
            for (int i = 1; i <= 10; i++)  
            { 
                Thread.Sleep(100);  
                Console.WriteLine("i = {0}", i);  
            } 
        } 
    } 
  } 
  class Example
  { 
    public static void Main(string[] args)  
    { 
        LockDisplay obj = new LockDisplay();  
        
        Console.WriteLine("Threading using Lock"); 
       
        Thread t1 = new Thread(new ThreadStart(obj.DisplayNum));  
        Thread t2 = new Thread(new ThreadStart(obj.DisplayNum));  
        t1.Start();  
        t2.Start();  
    } 
  } 
}