
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Channels;
using EdcWinForms.Services;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace EdcWinForms
{
    public partial class MainForm : Form
    {
        private IConnection _connection;
        private IChannel _channel;
        private const string QueueName = "payment";
        private string transType;
        private string machineModel;
        private string hostId;
        private string commPort;

        public MainForm()
        {
            InitializeComponent();
            InitializeRabbitMQ();
            LoadAvailablePorts();
        }

        private async void InitializeRabbitMQ()
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            _connection = await factory.CreateConnectionAsync();
            _channel = await _connection.CreateChannelAsync();

            await _channel.QueueDeclareAsync(queue: QueueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
        }

        private void LoadAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();

            commPortBox.Items.Clear();
            commPortBox.Items.AddRange(ports);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            resTxt.Text = "Waiting for start...";
        }

        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_channel != null)
                await _channel.CloseAsync();

            if (_connection != null)
                await _connection.CloseAsync();
        }

        private async void BtnStartListen_Click(object sender, EventArgs e)
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
            resTxt.Text = "Listening...";
        }

        private async void BtnSendRequest_Click(object sender, EventArgs e)
        {
            if (_channel == null)
            {
                MessageBox.Show("RabbitMQ connection is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = reqTxt.Text.Trim();
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a message!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            message += $@"
ReceiptNumber={recepitNoTxt.Text}
TransactionAmount={transAmountTxt.Text}
TransactionDate={transDateTxt.Text}
StoreID={storeIdTxt.Text}
BatchNo={batchNoTxt.Text}
TraceNo={traceNoTxt.Text}
WalletType={walletTypeTxt.Text}
WalletCode={walletCodeTxt.Text}
POSID={posIdTxt.Text}
RefNo={refNoTxt.Text}
ApprovalCode={apprCodeTxt.Text}
OrderID={orderIdTxt.Text}
CardInputType={cardInputTypeTxt.Text}
TradeNo={tradeNoTxt.Text}
InstallmentPeriod={installmentPeriodTxt.Text}";

            var body = Encoding.UTF8.GetBytes(message);

            try
            {
                await _channel.BasicPublishAsync(exchange: "notification", routingKey: QueueName, body: body);
                MessageBox.Show("Message sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateIndicator(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateIndicator), message);
                return;
            }

            resTxt.Text = "Received: " + message;
            resTxt.ForeColor = System.Drawing.Color.Green;
        }

        private void UpdateRequest(string model, string message)
        {
            reqTxt.Text += model + "=" + message + Environment.NewLine;
        }


        #region attribute
        private void MachineModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedMachineModel = machineModelBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedMachineModel))
            {
                machineModel = selectedMachineModel;
                UpdateRequest("MachineModel", selectedMachineModel);
            }
        }

        private void TransTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedTransType = transTypeBox.SelectedItem?.ToString() ?? "Test";
            string transactionType = selectedTransType switch
            {
                "Sale" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_Sale,
                "Refund" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_Refund,
                "Pre Authorization" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_PreAuthorization,
                "Pre Authorization Complete" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_PreAuthorizationComplete,
                "Pre Authorization Void" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_PreAuthorizationVoid,
                "ESVC Purchase" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_ESVCPurchase,
                "ESVC Refund" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_ESVCRefund,
                "ESVC Balance Inquiry" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_ESVCBalanceInquiry,
                "ESVC Cash Deposit" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_ESVCCashDeposit,
                "ESVC Void Cash Deposit" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_ESVCVoidCashDeposit,
                "Void Refund" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_VoidRefund,
                "Wallet Inquiry" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_WalletInquiry,
                "Settle" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_Settle,
                "Terimnate" => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_Terminate,
                _ => SDK_POS_ezAIO.ezpay.edc.Constants.transactionType_EchoTest,
            };
            transType = transactionType;
            UpdateRequest("TransactionType", selectedTransType);
        }

        private void HostIdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedHostId = hostIdBox.SelectedItem?.ToString() ?? "Test";
            string hostIdItem = selectedHostId switch
            {
                "Auto Select" => SDK_POS_ezAIO.ezpay.edc.Constants.hostID_AutoSelect,
                "Credit Card" => SDK_POS_ezAIO.ezpay.edc.Constants.hostID_CreditCard,
                "Easy Card" => SDK_POS_ezAIO.ezpay.edc.Constants.hostID_EasyCard,
                "Installment" => SDK_POS_ezAIO.ezpay.edc.Constants.hostID_Installment,
                "IPass Card" => SDK_POS_ezAIO.ezpay.edc.Constants.hostID_IPassCard,
                "Redemption" => SDK_POS_ezAIO.ezpay.edc.Constants.hostID_Redemption,
                "UPOP" => SDK_POS_ezAIO.ezpay.edc.Constants.hostID_UPOP,
                "Wallet" => SDK_POS_ezAIO.ezpay.edc.Constants.hostID_Wallet,
                _ => "Test",
            };
            hostId = hostIdItem;
            UpdateRequest("HostId", selectedHostId);
        }

        private void CommPortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedCommPort = commPortBox.SelectedItem?.ToString() ?? "COM4";
            UpdateRequest("COMM", selectedCommPort);
            commPort = selectedCommPort;
        }

        private void ConsoleClear_CheckedChanged(object sender, EventArgs e)
        {
            consoleClear.Checked = false;
            consoleTrue.Checked = false;
            consoleFalse.Checked = false;
        }
        #endregion
    }
}
