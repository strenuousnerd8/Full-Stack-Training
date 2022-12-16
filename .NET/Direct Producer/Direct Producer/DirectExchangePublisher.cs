using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace Direct_Producer
{
    internal class DirectExchangePublisher
    {
        public static void Publish(IModel channel)
        {
            var ttl = new Dictionary<string, object>
            {
                {"x-message-ttl", 30000 }
            };
            channel.ExchangeDeclare("DirectEx", ExchangeType.Direct, arguments: ttl);
            var count = 0;
            Console.Write("Enter your name:\t");
            string? name = Console.ReadLine();
            while (true)
            {
                var message = new { Name = "Producer", Message = $"Hello! {name} Count: {count}" };
                var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

                channel.BasicPublish("DirectEx", "account.init", null, body);
                Console.WriteLine(message);
                count++;
                Thread.Sleep(1000);
            }
        }
    }
}
