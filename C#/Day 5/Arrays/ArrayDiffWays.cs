using System;

class Hello
{
    public static void Main(string[] args)
    {
        // Different ways of initializing
        int[][] newArr = new int[2][];
        newArr[0] = new int[] { 4, 5 };
        newArr[1] = new int[] { 1, 2, 3 };

        int[][] newArray = 
        { 
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 }
        };

        // Printing these multi-dimensional array
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write("Row " + i + ": ");

            for (int j = 0; j < newArray[i].Length; j++)
            {
                Console.Write(newArray[i][j] + " ");

            }
            Console.WriteLine();
        }

        // Another Array
        for (int i = 0; i < newArr.Length; i++)
        {
            Console.Write("Row " + i + ": ");

            for (int j = 0; j < newArr[i].Length; j++)
            {
                Console.Write(newArr[i][j] + " ");

            }
            Console.WriteLine();
        }
    }
}