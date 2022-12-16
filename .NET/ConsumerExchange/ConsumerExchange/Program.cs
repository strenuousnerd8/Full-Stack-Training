// See https://aka.ms/new-console-template for more information
using ConsumerExchange;
using RabbitMQ.Client;
using System.Text;

Console.WriteLine("Hello, World!");

var factory = new ConnectionFactory
{
    Uri = new Uri("amqp://guest:guest@localhost:5672")
};

var connection = factory.CreateConnection();
var channel = connection.CreateModel();

QueueConsumer.Consume(channel);

channel.QueueDeclare("QueueAL1", durable: true, exclusive: false, autoDelete: false, arguments: null);

Console.Write("Type a message back:\t");
string? msg = Console.ReadLine();

var body = Encoding.UTF8.GetBytes(msg);
Thread.Sleep(5000);
channel.BasicPublish("", "QueueAL1", null, body);
Console.WriteLine(msg);

Console.ReadLine();