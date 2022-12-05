using System;

class Hello
{
    static string stringReverse(string s)
    {
        string res = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            res += s[i];
        }
        return res;
    }
    
    static void CharsAndNums(string s)
    {
        int numbers = 0;
        foreach (char c in s)
        {
            if (c >= '0' && c <= '9')
            {
                numbers += 1;
            }
        }
        Console.WriteLine(
            "The string has {0} characters and {1} numerical values", s.Length - numbers, numbers
            );
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a string:\t");
        string a = Console.ReadLine();
        
        string s = stringReverse(a);
        Console.WriteLine(s);

        CharsAndNums(s);
    }
}