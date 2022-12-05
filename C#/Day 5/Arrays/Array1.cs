using System;

class Hello
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Single dimensional array");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
    }
}