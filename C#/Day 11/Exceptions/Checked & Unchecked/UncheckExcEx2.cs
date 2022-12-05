using System;
namespace CSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
        }
    }
}