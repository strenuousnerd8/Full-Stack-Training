using System;

class Hello
{
    static void compute(string name, int usn, string bgroup = "O+", string dept = "Human Resource")
    {
        Console.WriteLine("Employee Name:\t" + name + "\n" + 
            "User Number:\t" + usn + "\n" + 
            "Blood Group:\t" + bgroup + "\n" + 
            "Department:\t" + dept);
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        // Concatenating strings using named parameters
        compute("Faizahamed Akkiwat", 23);
        compute("Darshan Hiremat", 27, "A-");
        compute("Azim Talikoti", 92, "A+", "Development");
    }
}