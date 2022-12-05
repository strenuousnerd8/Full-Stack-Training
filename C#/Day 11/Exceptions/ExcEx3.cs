using System;
 
class Program {
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
 
        for (int i = 0; i < arr.Length; i++) {
            Console.WriteLine(arr[i]);
        }
 
        try {
            Console.WriteLine(arr[7]);
        }
        catch (IndexOutOfRangeException e) {
            Console.WriteLine("An Exception has occurred : {0}", e.Message);
        }
    }
}