using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Fanout_Consumer
{
    public static class FanoutExchangeConsumer
    {
        public static void Consume(IModel channel)
        {
            channel.ExchangeDeclare("FanoutEx", ExchangeType.Fanout);
            channel.QueueDeclare("FanoutQueue",
             durable: true,
             exclusive: false,
             autoDelete: false,
             arguments: null);

            channel.QueueBind("FanoutQueue", "FanoutEx", string.Empty);
            channel.BasicQos(0, 10, false);

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
        }
    }
}
