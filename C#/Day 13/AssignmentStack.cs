using System;

class Hello
{
    public static void Main()
    {
        int[] al = new int[20];
        int currentCount = 0;
        int currentValue = 0;

        void push(int o)
        {
            if (currentCount >= al.Length)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            al[currentCount] = o;
            currentCount++;
        }

        int pop()
        {
            if (currentCount == 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            currentValue = al[currentCount - 1];
            al[currentCount] = 0;
            currentCount--;
            return currentValue;
        }

        push(23);
        push(22);
        push(21);

        for (int i = 0; i < currentCount; i++)
        {
            Console.WriteLine(al[i]);
        }

        Console.WriteLine("After popping:\n");

        Console.WriteLine(pop());

        Console.WriteLine();

        for (int i = 0; i < currentCount; i++)
        {
            Console.WriteLine(al[i]);
        }
    }
}