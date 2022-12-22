using Fanout_Producer;
using RabbitMQ.Client;

Console.WriteLine("Producer Started!");
var factory = new ConnectionFactory
{
    Uri = new Uri("amqp://guest:guest@localhost:5672")
};

var connection = factory.CreateConnection();
var channel = connection.CreateModel();

FanoutExchangePublisher.Publish(channel);
