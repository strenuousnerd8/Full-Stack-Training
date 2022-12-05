using System;

// Using For loop
class Hello
{
    public static void Main(string[] args)
    {
        int[, ] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Row " + i + ": ");

            for (int j = 0; j < 3; j++)
            {
                Console.Write(numbers[i, j] + " ");

            }
            Console.WriteLine();

        }
    }
}