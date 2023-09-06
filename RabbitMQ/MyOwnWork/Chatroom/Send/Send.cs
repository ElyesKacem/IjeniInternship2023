using System.Text;
using RabbitMQ.Client;

var factory2 = new ConnectionFactory { HostName = "localhost" };
using var connection2 = factory2.CreateConnection();
using var channel2 = connection2.CreateModel();

channel2.QueueDeclare(queue: "hello",
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);

const string message = Console.ReadLine();;
var body = Encoding.UTF8.GetBytes(message);

channel2.BasicPublish(exchange: string.Empty,
                     routingKey: "hello",
                     basicProperties: null,
                     body: body);
Console.WriteLine($" [x] Me: {message}");

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();