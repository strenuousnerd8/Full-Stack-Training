using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RPCServerEx
{
    internal class RPCServer
    {
        public static void Consume()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "rpcQueue", durable: false, exclusive: false, autoDelete: false, arguments: null);
                channel.BasicQos(0, 1, false);
                var consumer = new EventingBasicConsumer(channel);
                channel.BasicConsume(queue: "rpcQueue", autoAck: false, consumer: consumer);
                Console.WriteLine("[x] Awaiting RPC requests");

                consumer.Received += (model, ea) =>
                {
                    string response = null;
                    var body = ea.Body.ToArray();
                    var props = ea.BasicProperties;
                    var replyProps = channel.CreateBasicProperties();
                    replyProps.CorrelationId = props.CorrelationId;

                    try
                    {
                        var message = Encoding.UTF8.GetString(body);
                        int n = int.Parse(message);
                        Console.WriteLine("[.] fib({0})", message);
                        response = fib2(n).ToString();
                        Console.WriteLine("1111");
                    } catch (Exception e) {
                        Console.WriteLine("222");
                        Console.WriteLine("[.]" + e.Message);
                        response = "";
                    } finally
                    {
                        Console.WriteLine("3333");
                        var responseBytes = Encoding.UTF8.GetBytes(response);
                        channel.BasicPublish(exchange: "", routingKey: props.ReplyTo, basicProperties: replyProps, body: responseBytes);
                        Console.WriteLine("4444");
                        channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                    }
                };

                Console.WriteLine("Press [enter] to exit.");
                Console.ReadLine();

            }

        }

        private static int fib(int n) { 
            if (n == 0 || n == 1)
            {
                return n;
            }
            Console.WriteLine("5555");
            return fib(n - 1) + fib(n - 2);
        }

        private static int fib2(int n)
        {
            return 200;
        }
    }
}
