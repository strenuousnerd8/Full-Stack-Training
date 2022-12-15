// See https://aka.ms/new-console-template for more information
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

string msg = "Hi Team, new Message Queue2";
var body = Encoding.UTF8.GetBytes(msg);

channel.BasicPublish("", "QueueAL", null, body);
Console.WriteLine(msg);

channel.QueueDeclare("QueueAL", durable: true, exclusive: false, autoDelete: false, arguments: null);

string msg1 = "Hi Team, new Message, Queue1";
var body1 = Encoding.UTF8.GetBytes(msg1);

channel.BasicPublish("", "QueueAL", null, body);
Console.WriteLine(msg);