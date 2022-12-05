using System;

// Using different loops
class Hello
{
    public static void Main(string[] args)
    {
        // Two Dimensional Array
        int[,] intArr = new int[4, 2]
        {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 },
            { 7, 8 }
        };

        // Using Auto-size
        int[,] intArrAuto = new int[,]
        {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 },
            { 7, 8 }
        };

        // Three Dimensional Array
        int[,,] intArray = new int[,,]
        {
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            },
            {
                { 7, 8, 9 },
                { 10, 11, 12 }
            }
        };

        // Three Dimensional Array using Auto-size
        int[,,] intArrayThreeAuto = new int[2, 2, 3]
        {
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            },
            {
                { 7, 8, 9 },
                { 10, 11, 12 }
            }
        };

        
    }
}