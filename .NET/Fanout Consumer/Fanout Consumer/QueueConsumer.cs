using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Fanout_Consumer
{
    internal class QueueConsumer
    {
        public static void Consume(IModel channel)
        {
            channel.QueueDeclare("FanoutQueue", durable: true, exclusive: false, autoDelete: false, arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(message);
            };

            channel.BasicConsume("FanoutQueue", true, consumer);
            Console.WriteLine("Consumer started");

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
