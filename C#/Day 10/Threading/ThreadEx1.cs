using System;
using System.Threading;
public class MyThread
{
    public static void Thread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine(Thread.CurrentThread.Name);
        }
    }
}
public class ThreadExample {
    public static void Main()
    {
        Thread t = Thread.CurrentThread;
        t.Name = "MainThread";
        Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
        Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
        t1.Start();
        t1.Name = "t1Thread";
        t1.Name = "t2Thread";
        t2.Start();
        Console.WriteLine(t.Name);
    }  
}