﻿using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Direct_Consumer_2
{
    internal class QueueConsumer
    {
        public static void Consume(IModel channel)
        {
            channel.QueueDeclare("DirectQueue", durable: true, exclusive: false, autoDelete: false, arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(message);
            };

            channel.BasicConsume("DirectQueue", true, consumer);
            Console.WriteLine("Consumer started");

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
