using System;

public class Hello<T>
{
    private T data;

    public T value
    {
        get
        {
            return this.data;
        }
        set
        {
            this.data = value;
        }
    }
}

class Test
{
    static void Main(string[] args)
    {
        Hello<string> name = new Hello<string>();
        name.value = "Hello!";

        Hello<float> version = new Hello<float>();
        version.value = 5.0F;

        Console.WriteLine(name.value);

        Console.WriteLine(version.value);
    }
}