using System;
using System.Threading;
public class MyThread
{
    public void Thread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running.");
        }
    }
}
public class ThreadExample
{
    public static void Main()
    {
        MyThread mt = new MyThread();
        Thread t1 = new Thread(new ThreadStart(mt.Thread1));
        Thread t2 = new Thread(new ThreadStart(mt.Thread1));
        Thread t3 = new Thread(new ThreadStart(mt.Thread1));
        t1.Name = "Player1";
        t2.Name = "Player2";
        t3.Name = "Player3";
        t1.Start();
        t2.Start();
        t3.Start();
    }
}