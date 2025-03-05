
using System.Text;
using System.Threading.Channels;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace EdcWinForms
{
    public partial class MainForm : Form
    {
        private IConnection _connection;
        private IChannel _channel;
        private const string QueueName = "payment";


        public MainForm()
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Waiting for messages...";
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (_channel == null)
            {
                MessageBox.Show("RabbitMQ connection is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var consumer = new AsyncEventingBasicConsumer(_channel);
            consumer.ReceivedAsync += async (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Invoke(new Action(() => UpdateIndicator(message))); // Ensures thread safety
                await Task.Yield(); // Ensures async compatibility
            };

            await _channel.BasicConsumeAsync(queue: QueueName, autoAck: true, consumer: consumer);
            lblStatus.Text = "Listening...";
        }

        private void UpdateIndicator(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateIndicator), message);
                return;
            }

            lblStatus.Text = "Received: " + message;
            lblStatus.ForeColor = System.Drawing.Color.Green;
        }

        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_channel != null)
                await _channel.CloseAsync();

            if (_connection != null)
                await _connection.CloseAsync();
        }

        private void BtnOpenPublisher_Click(object sender, EventArgs e)
        {
            var publisherForm = new PublisherForm();
            publisherForm.Show();
        }
    }
}
