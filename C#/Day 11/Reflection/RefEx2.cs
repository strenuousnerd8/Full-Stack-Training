using System;  
using System.Reflection;  
public class ReflectionExample  
{  
   public static void Main()  
    {  
        Type t = typeof(System.String);  
        Console.WriteLine(t.Assembly);   
   }  
}  