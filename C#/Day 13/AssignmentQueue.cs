using System;

class Hello
{
    public static void Main()
    {
        int[] al = new int[20];
        int currentCount = 0;
        int currentValue = 0;

        void enqueue(int o)
        {
            if (currentCount >= al.Length)
            {
                Console.WriteLine("Queue capacity exceeded");
                return;
            }
            al[currentCount] = o;
            currentCount++;
        }

        int dequeue()
        {
            if (currentCount == 0)
            {
                Console.WriteLine("Queue already empty");
                return 0;
            }
            currentValue = al[0];
            al[0] = al[currentCount - 1];
            currentCount--;
            return currentValue;
        }

        enqueue(23);
        enqueue(22);
        enqueue(21);

        for (int i = 0; i < currentCount; i++)
        {
            Console.WriteLine(al[i]);
        }

        Console.WriteLine("After popping:\n");

        Console.WriteLine(dequeue());

        Console.WriteLine();

        for (int i = 0; i < currentCount; i++)
        {
            Console.WriteLine(al[i]);
        }
    }
}