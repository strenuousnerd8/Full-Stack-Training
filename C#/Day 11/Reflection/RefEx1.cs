using System;  
public class ReflectionExample  
{  
   public static void Main()  
    {  
        int a = 10;  
        Type type = a.GetType();  
        Console.WriteLine(type);  
    }  
}  