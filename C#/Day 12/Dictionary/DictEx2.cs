using System;
using System.Collections.Generic;

class Hello
{

    static public void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("FirstKey", "FirstValue");
        dict.Add("SecondKey", "SecondValue");
        dict.Add("ThirdKey", "ThirdValue");

        foreach (KeyValuePair<string, string> kv in dict)
        {
            Console.WriteLine(kv.Key + ", " + kv.Value);
        }

        Console.WriteLine(dict.Count);

        dict.Remove("SecondKey");
        Console.WriteLine();

        foreach (KeyValuePair<string, string> kv in dict)
        {
            Console.WriteLine(kv.Key + ", " + kv.Value);
        }

        dict.Clear();
    }
}