using System;

interface firstinterface
{
    void myfun1();
}
  
interface secondinterface
{
    void myfun2();
}
  
interface thirdinterface
{
    void myfun3();
}
  
class Int_Class : firstinterface, secondinterface, thirdinterface
{
      
    public void myfun1()
    {
        Console.WriteLine("First interface");
    }
      
    public void myfun2()
    {
        Console.WriteLine("Second interface");
    }   
      
    public void myfun3()
    {
        Console.WriteLine("Third interface");
    }
}
  
class Test{
  
public static void Main(String[] args)
{
      
    firstinterface obj1;
    secondinterface obj2;
    thirdinterface obj3;
      
    obj1 = new Int_Class();
    obj2 = new Int_Class();
    obj3 = new Int_Class();
      
    obj1.myfun1();
    obj2.myfun2();
    obj3.myfun3();
}
}