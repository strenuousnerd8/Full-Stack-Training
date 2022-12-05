using System;
using System.Threading;
 
class ExampleofThread {
 
    // Non-Static method
    public void thread()
    {
        for (int x = 0; x < 3; x++) {
            Console.WriteLine(x);
        }
    }
}
 
// Driver Class
class ThreadExample {
 
    // Main method
    public static void Main()
    {
 
        // Creating instance for mythread() method
        ExampleofThread obj = new ExampleofThread();
 
        // Creating and initializing threads
        Thread thr = new Thread(new ThreadStart(obj.thread));
        thr.Start();
 
        Console.WriteLine("Thread is abort");
 
        // Abort the thread
        // Using Abort() method
        thr.Abort();
    }
}