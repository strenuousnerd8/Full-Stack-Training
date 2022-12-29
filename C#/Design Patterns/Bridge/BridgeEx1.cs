/// <summary>
/// The 'Abstraction' class
/// </summary>
public abstract class Message
{
    public IMessageSender MessageSender { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public abstract void Send();
}

/// <summary>
/// The 'RefinedAbstraction' class
/// </summary>
public class SystemMessage : Message
{
    public override void Send()
    {
        MessageSender.SendMessage(Subject, Body);
    }
}

/// <summary>
/// The 'RefinedAbstraction' class
/// </summary>
public class UserMessage : Message
{
    public string UserComments { get; set; }

    public override void Send()
    {
        string fullBody = string.Format("{0}\nUser Comments: {1}", Body, UserComments);
        MessageSender.SendMessage(Subject, fullBody);
    }
}

/// <summary>
/// The 'Bridge/Implementor' interface
/// </summary>
public interface IMessageSender
{
    void SendMessage(string subject, string body);
}

/// <summary>
/// The 'ConcreteImplementor' class
/// </summary>
public class EmailSender : IMessageSender
{
    public void SendMessage(string subject, string body)
    {
        Console.WriteLine("Email\n{0}\n{1}\n", subject, body);
    }
}

/// <summary>
/// The 'ConcreteImplementor' class
/// </summary>
public class MSMQSender : IMessageSender
{
    public void SendMessage(string subject, string body)
    {
        Console.WriteLine("MSMQ\n{0}\n{1}\n", subject, body);
    }
}

/// <summary>
/// The 'ConcreteImplementor' class
/// </summary>
public class WebServiceSender : IMessageSender
{
    public void SendMessage(string subject, string body)
    {
        Console.WriteLine("Web Service\n{0}\n{1}\n", subject, body);
    }
}

/// <summary>
/// Bridge Design Pattern Demo
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        IMessageSender email = new EmailSender();
        IMessageSender queue = new MSMQSender();
        IMessageSender web = new WebServiceSender();

        Message message = new SystemMessage();
        message.Subject = "Test Message";
        message.Body = "Hi, This is a Test Message";

        message.MessageSender = email;
        message.Send();

        message.MessageSender = queue;
        message.Send();

        message.MessageSender = web;
        message.Send();

        UserMessage usermsg = new UserMessage();
        usermsg.Subject = "Test Message";
        usermsg.Body = "Hi, This is a Test Message";
        usermsg.UserComments = "I hope you are well";

        usermsg.MessageSender = email;
        usermsg.Send();

        Console.ReadKey();
    }
}