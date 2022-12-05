using System;
using System.Threading;
public class MyThread
{
    public void Thread1()
    {
        Console.WriteLine("Task one"); 
    }
    public void Thread2()
    {
        Console.WriteLine("Task two");
    }
}
public class ThreadExample
{
    public static void Main()
    {
        MyThread mt = new MyThread();
        Thread t1 = new Thread(new ThreadStart(mt.Thread1));
        Thread t2 = new Thread(new ThreadStart(mt.Thread2));
        t1.Start();
        t2.Start();
    }
}