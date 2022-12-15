using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Direct_Consumer_2
{
    internal class DirectExchangeConsumer
    {
        public static void Consume(IModel channel)
        {
            channel.ExchangeDeclare("DirectEx", ExchangeType.Direct);
            channel.QueueDeclare("DirectQueue1",
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null
            );
            channel.QueueBind("DirectQueue1", "DirectEx", "account.init");
            channel.BasicQos(0, 10, false);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(message);
            };

            channel.BasicConsume("DirectQueue1", true, consumer);
            Console.WriteLine("Direct Queue Consumer started");
            Console.ReadLine();
        }
    }
}
