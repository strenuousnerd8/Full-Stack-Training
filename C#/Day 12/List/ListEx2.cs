using System;
using System.Collections.Generic;
namespace GenericListCollectionDemo
{
    class Program
    {
        static void Main()
        {

            List<string> countries = new List<string>();
            
            countries.Add("INDIA");
            countries.Add("USA");

            List<string> newCountries = new List<string>();
            
            newCountries.Add("JAPAN");
            newCountries.Add("UK");
            
            countries.AddRange(newCountries);
            
            Console.WriteLine("Accessing Generic List using For Each Loop");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\nAccessing Generic List using For Loop");
            for (int i = 0; i < countries.Count; i++)
            {
                var element = countries[i];
                Console.WriteLine(element);
            }
            
            Console.WriteLine("\nAccessing Individual List Element by Index Position");
            Console.WriteLine($"First Element: {countries[0]}");
            Console.WriteLine($"Second Element: {countries[1]}");
            Console.WriteLine($"Third Element: {countries[2]}");
            Console.WriteLine($"Fourth Element: {countries[3]}");
            Console.ReadKey();
        }
    }
}