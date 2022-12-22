using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace Fanout_Producer
{
    public static class FanoutExchangePublisher
    {
        public static void Publish(IModel channel)
        {
            var ttl = new Dictionary<string, object>
            {
                { "x-message-ttl", 30000 }
            };
            channel.ExchangeDeclare("FanoutEx", ExchangeType.Fanout, arguments: ttl);

            int count = 0;
            Console.WriteLine("Enter a name:\t");
            string? name = Console.ReadLine();
            while (true)
            {
                var message = new { Name = "Producer", Message = $"Hello! {name} Count: {count}" };
                var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

                var properties = channel.CreateBasicProperties();
                properties.Headers = new Dictionary<string, object> { { "account", "new" } };
                channel.BasicPublish("FanoutEx", string.Empty, properties, body);
                count++;
                Thread.Sleep(1000);
            }
        }
    }
}