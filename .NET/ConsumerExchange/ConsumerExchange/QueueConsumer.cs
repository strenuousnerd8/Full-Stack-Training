using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace ConsumerExchange
{
    internal class QueueConsumer
    {
        public static void Consume(IModel channel)
        {
            channel.QueueDeclare("QueueAL", durable: true, exclusive: false, autoDelete: false, arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            var message = string.Empty;
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                message = Encoding.UTF8.GetString(body);
                Console.WriteLine("got " + message);
            };

            channel.BasicConsume("QueueAL", true, consumer);
            Console.WriteLine("Consumer started");
        }
    }
}
