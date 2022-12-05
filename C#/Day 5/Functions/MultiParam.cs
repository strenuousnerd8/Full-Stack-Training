using System;

class Hello
{
    static int multiply(params int[] arr)
    {
        int res = 1;
        int i = 0;
        while (i < arr.Length) {
            res *= arr[i];
            i++;
        }
        return res;
    }
    public static void Main(string[] args)
    {
        // Passing multiple values
        int x = multiply(5, 4, 3, 2, 1);
        Console.WriteLine("We got the product: " + x);
        x = multiply(3, 2);
        Console.WriteLine("We got the product: " + x);
        x = multiply(5);
        Console.WriteLine("We got the product: " + x);
    }
}