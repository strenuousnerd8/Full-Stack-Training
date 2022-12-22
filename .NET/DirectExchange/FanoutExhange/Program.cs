// See https://aka.ms/new-console-template for more information
using FanoutExchange;
using RabbitMQ.Client;
using System.Text;

Console.WriteLine("Hello, World!");
var factory = new ConnectionFactory
{
    Uri = new Uri("amqp://guest:guest@localhost:5672")
};

var connection = factory.CreateConnection();
var channel = connection.CreateModel();
channel.QueueDeclare("QueueAL", durable: true, exclusive: false, autoDelete: false, arguments: null);

string msg = "message from producer";
var body = Encoding.UTF8.GetBytes(msg);

channel.BasicPublish("", "QueueAL", null, body);
Console.WriteLine(msg);
Thread.Sleep(5000);
QueueConsumer.Consume(channel);