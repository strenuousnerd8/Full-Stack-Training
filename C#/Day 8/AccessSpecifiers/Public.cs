using System;
namespace Sample  
{  
  
   public class ABC  
   {  
       private int Id;  
   }  
   
    public class Program  
   {  
        public static void Main(string[] args)  
        {  
            ABC abc = new ABC();  
            abc.Id = 10;//Error ,Id is private  
        }  
   }  
}  