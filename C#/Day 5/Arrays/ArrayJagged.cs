using System;

class Hello
{
    public static void Main(string[] args)
    {
        // Initializing a jagged array of 4 elements
        int[][] jagged_arr = new int[4][];
        jagged_arr[0] = new int[] { 1, 2, 3, 4 };
        jagged_arr[1] = new int[] { 5, 6, 7, 8 };
        jagged_arr[2] = new int[] { 9, 10, 11, 12 };
        jagged_arr[3] = new int[] { 13, 14, 15, 16 };

        // Printing the jagged array
        for (int i = 0; i < jagged_arr.Length; i++)
        {
            Console.Write("Row " + i + ": ");

            for (int j = 0; j < jagged_arr[i].Length; j++)
            {
                Console.Write(jagged_arr[i][j] + " ");

            }
            Console.WriteLine();
        }
    }
}