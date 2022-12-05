using System;

class UserDefineException: Exception
{

    public UserDefineException(string str)
    {
        Console.WriteLine(str);
    }
}

class Program
{
    static void Main()
    {
        UserDefineException M = new UserDefineException("User Defined Exception!");

        try
        {
            throw M;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}