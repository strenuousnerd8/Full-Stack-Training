using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace FanoutExchange
{
    internal class QueueConsumer
    {
        public static void Consume(IModel channel)
        {
            channel.QueueDeclare("QueueAL1", durable: true, exclusive: false, autoDelete: false, arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            var message = string.Empty;
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                message = Encoding.UTF8.GetString(body);
                Console.WriteLine(message);
            };

            channel.BasicConsume("QueueAL1", true, consumer);
            Console.WriteLine("Consumer started");

            Console.ReadLine();
        }
    }
}
