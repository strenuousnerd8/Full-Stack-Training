using System;

class Test
{
    static void Main(string[] args)
    {
        try {
            string str = "757657657657657";
            int res = int.Parse(str);
        } catch(OverflowException) {
            Console.Write("Error! The value is too large for an Int32");
        }
    }
}