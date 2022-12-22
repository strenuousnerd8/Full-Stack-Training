using Fanout_Consumer;
using RabbitMQ.Client;

Console.WriteLine("Hello, World!");

var factory = new ConnectionFactory
{
    Uri = new Uri("amqp://guest:guest@localhost:5672")
};

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

// QueueConsumer.Consume(channel);

FanoutExchangeConsumer.Consume(channel);