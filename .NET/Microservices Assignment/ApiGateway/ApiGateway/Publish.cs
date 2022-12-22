using RabbitMQ.Client;

namespace ApiGateway
{
    public class Publish
    {
        internal static void pub()
        {
            Console.WriteLine("Producer Started!");
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };

            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            FanoutExchangePublisher.Publish(channel);
        }
    }
}
