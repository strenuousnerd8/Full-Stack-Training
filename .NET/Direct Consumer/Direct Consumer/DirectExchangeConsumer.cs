using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Direct_Consumer
{
    internal class DirectExchangeConsumer
    {
        public static void Consume(IModel channel)
        {
            channel.ExchangeDeclare("DirectEx", ExchangeType.Direct);
            channel.QueueDeclare("DirectQueue",
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null
            );
            channel.QueueBind("DirectQueue", "DirectEx", "account.init");
            channel.BasicQos(0, 10, false);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(message);
            };

            channel.BasicConsume("DirectQueue", true, consumer);
            Console.WriteLine("Direct Queue Consumer started");
            Console.ReadLine();
        }
    }
}
