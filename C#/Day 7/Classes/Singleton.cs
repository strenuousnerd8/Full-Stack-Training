using System;

class Alert
{
    public static readonly Alert Instance = new Alert();

    public void Show()
    {
        Console.WriteLine("Singleton - Single Instance of a Class");
    }
    private Alert() { }
}

class Hello
{
    static void Main(string[] args)
    {
        Alert.Instance.Show();
    }
}