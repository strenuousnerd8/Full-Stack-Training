using System;
namespace CSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //int val = int.MaxValue;     // Unchecked Expection
            //Console.WriteLine(val + 2);
            
            checked                       // checked Expection
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
       }
    }
}