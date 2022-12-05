using System;

class Hello
{
    static void result(int[] arr)
    {
        Console.Write("Elements in the array are:\t");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
    public static void Main(string[] args)
    {
        int[] array =
        {
            5, 4, 3, 2, 1
        };
        result(array);
    }
}