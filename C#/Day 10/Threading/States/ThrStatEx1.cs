using System;
using System.Threading;
 
public class MyThread {
 
    // Non-Static method
    public void thread()
    {
        for (int x = 0; x < 2; x++) {
            Console.WriteLine("My Thread");
        }
    }
}
 
public class ThreadExample {
 
    // Main method
    public static void Main()
    {
 
        // Creating instance for
        // mythread() method
        MyThread obj = new MyThread();
 
        // Creating and initializing
        // threads Unstarted state
        Thread thr1 = new Thread(new ThreadStart(obj.thread));
 
        Console.WriteLine("ThreadState: {0}",
                          thr1.ThreadState);
 
        // Running state
        thr1.Start();
        Console.WriteLine("ThreadState: {0}",
                           thr1.ThreadState);
 
        // thr1 is in suspended state
        thr1.Suspend();
        Console.WriteLine("ThreadState: {0}",
                           thr1.ThreadState);
 
        // thr1 is resume to running state
        thr1.Resume();
        Console.WriteLine("ThreadState: {0}",
                          thr1.ThreadState);
    }
}