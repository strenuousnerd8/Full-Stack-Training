using System;

class Hello
{
    static void calculator(int choice, int a, int b)
    {
        int res = 0;
        if (choice == 1) {
            res = a + b;
            Console.WriteLine("Sum is :\t" + res);
        }
        else if (choice == 2)
        {
            res = a - b;
            Console.WriteLine("Difference is :\t" + res);
        }
        else if (choice == 3)
        {
            res = a * b;
            Console.WriteLine("Product is :\t" + res);
        }
        else if (choice == 4)
        {
            res = a / b;
            Console.WriteLine("Division is :\t" + res);
        }
        else {
            Console.WriteLine("Please enter a valid choice.");
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Value 1 :\t");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Value 2 :\t");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter");
        Console.WriteLine("1 to Add");
        Console.WriteLine("2 to Substract");
        Console.WriteLine("3 to Multiply");
        Console.WriteLine("4 to Divide");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        calculator(choice, num1, num2);
    }
}