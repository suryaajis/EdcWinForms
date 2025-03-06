using RabbitMQ.Client;

namespace EdcWinForms
{
    class RabbitMQListener
    {
        private IConnection _connection;
        private IChannel _channel;
        private string host;
        private string queue;

        public RabbitMQListener(string host, string queue)
        {
            this.host = host;
            this.queue = queue;
        }

        public async void InitializeRabbitMQ()
        {
            var factory = new ConnectionFactory { HostName = host };
            _connection = await factory.CreateConnectionAsync();
            _channel = await _connection.CreateChannelAsync();

            await _channel.QueueDeclareAsync(queue: queue, durable: true, exclusive: false, autoDelete: false, arguments: null);
        }
    }
}
