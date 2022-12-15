using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerExchange
{
    internal class QueueConsumer
    {
        public static void Consume(IModel channel)
        {
            channel.QueueDeclare("QueueAL", durable: true, exclusive: false, autoDelete: false, arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(message);
            };

            channel.BasicConsume("QueueAL", true, consumer);
            Console.WriteLine("Consumer started");

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
