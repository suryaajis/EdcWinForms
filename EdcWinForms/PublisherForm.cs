using RabbitMQ.Client;
using System.Text;

namespace EdcWinForms
{
    public partial class PublisherForm: Form
    {
        private IConnection _connection;
        private IChannel _channel;
        private const string QueueName = "payment";

        public PublisherForm()
        {
            InitializeComponent();
            InitializeRabbitMQ();
        }

        private async void InitializeRabbitMQ()
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            _connection = await factory.CreateConnectionAsync();
            _channel = await _connection.CreateChannelAsync();

            await _channel.QueueDeclareAsync(queue: QueueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (_channel == null)
            {
                MessageBox.Show("RabbitMQ connection is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = txtMessage.Text.Trim();
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a message!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var body = Encoding.UTF8.GetBytes(message);

            try
            {
                await _channel.BasicPublishAsync(exchange: "notification", routingKey: QueueName, body: body);
                MessageBox.Show("Message sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PublisherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_channel != null)
                await _channel.CloseAsync();

            if (_connection != null)
                await _connection.CloseAsync();
        }
    }
}
