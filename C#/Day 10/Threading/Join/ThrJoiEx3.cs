using System;
using System.Threading;
public class MyThread
{
    static TimeSpan mytime = new TimeSpan(0, 0, 1);

    public static void Main()
    {
        Thread thr = new Thread(mywork);
        thr.Start();
        
        if (thr.Join(mytime + mytime))
                {
                Console.WriteLine("New thread is terminated");
            }
            else
            {
                Console.WriteLine("Join timed out");
            }
    }
    static void mywork()
    {
        Thread.Sleep(mytime);
    }
}