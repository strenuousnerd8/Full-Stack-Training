using System;

// Using different loops
class Hello
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        int j = 0;
        int k = 0;
        Console.Write("Elements via while loop:\t");
        while (j < numbers.Length)
        {
            Console.Write(numbers[j] + " ");
            j++;
        }
        Console.WriteLine();

        Console.Write("Elements via do-while loop:\t");
        do
        {
            Console.Write(numbers[k] + " ");
            k++;
        } while (k < numbers.Length);
        Console.WriteLine();

        Console.Write("Elements via for-each loop:\t");
        foreach (int x in numbers)
        {
            Console.Write(x + " ");
        }
    }
}