public abstract class Abstraction
{
    public Bridge Implementer { get; set; }

    public virtual void Operation()
    {
        Console.WriteLine("ImplementationBase:Operation()");
        Implementer.OperationImplementation();
    }
}

public class RefinedAbstraction : Abstraction
{
    public override void Operation()
    {
        Console.WriteLine("RefinedAbstraction:Operation()");
        Implementer.OperationImplementation();
    }
}

public interface Bridge
{
    void OperationImplementation();
}

public class ImplementationA : Bridge
{
    public void OperationImplementation()
    {
        Console.WriteLine("ImplementationA:OperationImplementation()");
    }
}

public class ImplementationB : Bridge
{
    public void OperationImplementation()
    {
        Console.WriteLine("ImplementationB:OperationImplementation()");
    }
}