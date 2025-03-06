using SDK_POS_ezAIO.ezpay.edc;

namespace EdcWinForms
{
    partial class MainForm
    {
        private System.Windows.Forms.Button btnStart;

        private void InitializeComponent()
        {
            btnStart = new Button();
            btnSendRequest = new Button();
            reqTxt = new RichTextBox();
            reqLbl = new Label();
            resLbl = new Label();
            transTypeBox = new ComboBox();
            machineModelBox = new ComboBox();
            hostIdBox = new ComboBox();
            commPortBox = new ComboBox();
            overtimeTxt = new TextBox();
            overtimeLbl = new Label();
            recieptNoLbl = new Label();
            recepitNoTxt = new TextBox();
            transAmoutLbl = new Label();
            transAmountTxt = new TextBox();
            transDateLbl = new Label();
            transDateTxt = new TextBox();
            storeIdLbl = new Label();
            storeIdTxt = new TextBox();
            batchNoLbl = new Label();
            batchNoTxt = new TextBox();
            traceNoLbl = new Label();
            traceNoTxt = new TextBox();
            walletTypeLbl = new Label();
            walletTypeTxt = new TextBox();
            walletCodeLbl = new Label();
            walletCodeTxt = new TextBox();
            posIdLbl = new Label();
            posIdTxt = new TextBox();
            refNoLbl = new Label();
            refNoTxt = new TextBox();
            apprCodeLbl = new Label();
            apprCodeTxt = new TextBox();
            orderIdLbl = new Label();
            orderIdTxt = new TextBox();
            cardInputTypeLbl = new Label();
            cardInputTypeTxt = new TextBox();
            tradeNoLbl = new Label();
            tradeNoTxt = new TextBox();
            installmentPeriodLbl = new Label();
            installmentPeriodTxt = new TextBox();
            resTxt = new RichTextBox();
            consoleLbl = new Label();
            consoleTrue = new RadioButton();
            consoleFalse = new RadioButton();
            consoleClear = new RadioButton();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(546, 263);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(135, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Listening";
            btnStart.Click += BtnStart_Click;
            // 
            // btnSendRequest
            // 
            btnSendRequest.Location = new Point(31, 615);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(95, 23);
            btnSendRequest.TabIndex = 2;
            btnSendRequest.Text = "Send Request";
            btnSendRequest.Click += BtnSendRequest_Click;
            // 
            // reqTxt
            // 
            reqTxt.Location = new Point(31, 328);
            reqTxt.Name = "reqTxt";
            reqTxt.Size = new Size(309, 281);
            reqTxt.TabIndex = 3;
            reqTxt.Text = "";
            // 
            // reqLbl
            // 
            reqLbl.AutoSize = true;
            reqLbl.Location = new Point(31, 310);
            reqLbl.Name = "reqLbl";
            reqLbl.Size = new Size(49, 15);
            reqLbl.TabIndex = 5;
            reqLbl.Text = "Request";
            // 
            // resLbl
            // 
            resLbl.AutoSize = true;
            resLbl.Location = new Point(374, 310);
            resLbl.Name = "resLbl";
            resLbl.Size = new Size(57, 15);
            resLbl.TabIndex = 6;
            resLbl.Text = "Response";
            // 
            // transTypeBox
            // 
            transTypeBox.FormattingEnabled = true;
            transTypeBox.Items.AddRange(new object[] { "Sale", "Refund", "Pre Authorization", "Pre Authorization Complete", "Pre Authorization Void", "ESVC Purchase", "ESVC Refund", "ESVC Balance Inquiry", "ESVC Cash Deposit", "ESVC Void Cash Deposit", "Void Refund", "Wallet Inquiry", "Settle", "Terimnate", "Echo Test" });
            transTypeBox.Location = new Point(31, 41);
            transTypeBox.Name = "transTypeBox";
            transTypeBox.Size = new Size(193, 23);
            transTypeBox.TabIndex = 7;
            transTypeBox.Tag = "";
            transTypeBox.Text = "Transaction Type";
            transTypeBox.SelectedIndexChanged += TransTypeBox_SelectedIndexChanged;
            // 
            // machineModelBox
            // 
            machineModelBox.FormattingEnabled = true;
            machineModelBox.Items.AddRange(new object[] { "AS350_v1.21", "AS350_v1.3.0", "AS350_v1.3.2", "AS350_v1.4.0", "AS350_v1.4.1", "AS350_v1.5.0", "AS350_v1.5.1" });
            machineModelBox.Location = new Point(31, 12);
            machineModelBox.Name = "machineModelBox";
            machineModelBox.Size = new Size(193, 23);
            machineModelBox.TabIndex = 8;
            machineModelBox.Tag = "";
            machineModelBox.Text = "Machine Model";
            machineModelBox.SelectedIndexChanged += MachineModelBox_SelectedIndexChanged;
            // 
            // hostIdBox
            // 
            hostIdBox.FormattingEnabled = true;
            hostIdBox.Items.AddRange(new object[] { "Credit Card", "Redemption", "Installment", "UPOP", "Auto Select", "Easy Card", "IPass Card", "Wallet" });
            hostIdBox.Location = new Point(237, 41);
            hostIdBox.Name = "hostIdBox";
            hostIdBox.Size = new Size(194, 23);
            hostIdBox.TabIndex = 9;
            hostIdBox.Tag = "";
            hostIdBox.Text = "Host ID";
            // 
            // commPortBox
            // 
            commPortBox.FormattingEnabled = true;
            commPortBox.Items.AddRange(new object[] { "COMM 1", "COMM 2", "COMM 3", "COMM 4", "COMM 5", "COMM 6", "COMM 7", "COMM 8", "COMM 9", "COMM 10", "COMM 11", "COMM 12", "COMM 13", "COMM 14", "COMM 15" });
            commPortBox.Location = new Point(237, 12);
            commPortBox.Name = "commPortBox";
            commPortBox.Size = new Size(194, 23);
            commPortBox.TabIndex = 10;
            commPortBox.Tag = "";
            commPortBox.Text = "Comm Port Name";
            // 
            // overtimeTxt
            // 
            overtimeTxt.Location = new Point(449, 41);
            overtimeTxt.Name = "overtimeTxt";
            overtimeTxt.Size = new Size(109, 23);
            overtimeTxt.TabIndex = 11;
            // 
            // overtimeLbl
            // 
            overtimeLbl.AutoSize = true;
            overtimeLbl.Location = new Point(449, 20);
            overtimeLbl.Name = "overtimeLbl";
            overtimeLbl.Size = new Size(59, 15);
            overtimeLbl.TabIndex = 12;
            overtimeLbl.Text = "OverTime";
            // 
            // recieptNoLbl
            // 
            recieptNoLbl.AutoSize = true;
            recieptNoLbl.Location = new Point(31, 81);
            recieptNoLbl.Name = "recieptNoLbl";
            recieptNoLbl.Size = new Size(93, 15);
            recieptNoLbl.TabIndex = 14;
            recieptNoLbl.Text = "Receipt Number";
            // 
            // recepitNoTxt
            // 
            recepitNoTxt.Location = new Point(31, 99);
            recepitNoTxt.Name = "recepitNoTxt";
            recepitNoTxt.Size = new Size(140, 23);
            recepitNoTxt.TabIndex = 13;
            // 
            // transAmoutLbl
            // 
            transAmoutLbl.AutoSize = true;
            transAmoutLbl.Location = new Point(31, 133);
            transAmoutLbl.Name = "transAmoutLbl";
            transAmoutLbl.Size = new Size(115, 15);
            transAmoutLbl.TabIndex = 16;
            transAmoutLbl.Text = "Transaction Amount";
            // 
            // transAmountTxt
            // 
            transAmountTxt.Location = new Point(31, 151);
            transAmountTxt.Name = "transAmountTxt";
            transAmountTxt.Size = new Size(140, 23);
            transAmountTxt.TabIndex = 15;
            // 
            // transDateLbl
            // 
            transDateLbl.AutoSize = true;
            transDateLbl.Location = new Point(31, 189);
            transDateLbl.Name = "transDateLbl";
            transDateLbl.Size = new Size(95, 15);
            transDateLbl.TabIndex = 18;
            transDateLbl.Text = "Transaction Date";
            // 
            // transDateTxt
            // 
            transDateTxt.Location = new Point(31, 207);
            transDateTxt.Name = "transDateTxt";
            transDateTxt.Size = new Size(140, 23);
            transDateTxt.TabIndex = 17;
            // 
            // storeIdLbl
            // 
            storeIdLbl.AutoSize = true;
            storeIdLbl.Location = new Point(200, 81);
            storeIdLbl.Name = "storeIdLbl";
            storeIdLbl.Size = new Size(48, 15);
            storeIdLbl.TabIndex = 20;
            storeIdLbl.Text = "Store ID";
            // 
            // storeIdTxt
            // 
            storeIdTxt.Location = new Point(200, 99);
            storeIdTxt.Name = "storeIdTxt";
            storeIdTxt.Size = new Size(140, 23);
            storeIdTxt.TabIndex = 19;
            // 
            // batchNoLbl
            // 
            batchNoLbl.AutoSize = true;
            batchNoLbl.Location = new Point(200, 133);
            batchNoLbl.Name = "batchNoLbl";
            batchNoLbl.Size = new Size(84, 15);
            batchNoLbl.TabIndex = 22;
            batchNoLbl.Text = "Batch Number";
            // 
            // batchNoTxt
            // 
            batchNoTxt.Location = new Point(200, 151);
            batchNoTxt.Name = "batchNoTxt";
            batchNoTxt.Size = new Size(140, 23);
            batchNoTxt.TabIndex = 21;
            // 
            // traceNoLbl
            // 
            traceNoLbl.AutoSize = true;
            traceNoLbl.Location = new Point(200, 189);
            traceNoLbl.Name = "traceNoLbl";
            traceNoLbl.Size = new Size(82, 15);
            traceNoLbl.TabIndex = 24;
            traceNoLbl.Text = "Trace Number";
            // 
            // traceNoTxt
            // 
            traceNoTxt.Location = new Point(200, 207);
            traceNoTxt.Name = "traceNoTxt";
            traceNoTxt.Size = new Size(140, 23);
            traceNoTxt.TabIndex = 23;
            // 
            // walletTypeLbl
            // 
            walletTypeLbl.AutoSize = true;
            walletTypeLbl.Location = new Point(372, 245);
            walletTypeLbl.Name = "walletTypeLbl";
            walletTypeLbl.Size = new Size(68, 15);
            walletTypeLbl.TabIndex = 30;
            walletTypeLbl.Text = "Wallet Type";
            // 
            // walletTypeTxt
            // 
            walletTypeTxt.Location = new Point(372, 263);
            walletTypeTxt.Name = "walletTypeTxt";
            walletTypeTxt.Size = new Size(140, 23);
            walletTypeTxt.TabIndex = 29;
            // 
            // walletCodeLbl
            // 
            walletCodeLbl.AutoSize = true;
            walletCodeLbl.Location = new Point(372, 189);
            walletCodeLbl.Name = "walletCodeLbl";
            walletCodeLbl.Size = new Size(71, 15);
            walletCodeLbl.TabIndex = 28;
            walletCodeLbl.Text = "Wallet Code";
            // 
            // walletCodeTxt
            // 
            walletCodeTxt.Location = new Point(372, 207);
            walletCodeTxt.Name = "walletCodeTxt";
            walletCodeTxt.Size = new Size(140, 23);
            walletCodeTxt.TabIndex = 27;
            // 
            // posIdLbl
            // 
            posIdLbl.AutoSize = true;
            posIdLbl.Location = new Point(372, 81);
            posIdLbl.Name = "posIdLbl";
            posIdLbl.Size = new Size(43, 15);
            posIdLbl.TabIndex = 26;
            posIdLbl.Text = "POS ID";
            // 
            // posIdTxt
            // 
            posIdTxt.Location = new Point(372, 99);
            posIdTxt.Name = "posIdTxt";
            posIdTxt.Size = new Size(140, 23);
            posIdTxt.TabIndex = 25;
            // 
            // refNoLbl
            // 
            refNoLbl.AutoSize = true;
            refNoLbl.Location = new Point(546, 189);
            refNoLbl.Name = "refNoLbl";
            refNoLbl.Size = new Size(106, 15);
            refNoLbl.TabIndex = 36;
            refNoLbl.Text = "Reference Number";
            // 
            // refNoTxt
            // 
            refNoTxt.Location = new Point(546, 207);
            refNoTxt.Name = "refNoTxt";
            refNoTxt.Size = new Size(140, 23);
            refNoTxt.TabIndex = 35;
            // 
            // apprCodeLbl
            // 
            apprCodeLbl.AutoSize = true;
            apprCodeLbl.Location = new Point(31, 245);
            apprCodeLbl.Name = "apprCodeLbl";
            apprCodeLbl.Size = new Size(86, 15);
            apprCodeLbl.TabIndex = 34;
            apprCodeLbl.Text = "Approval Code";
            // 
            // apprCodeTxt
            // 
            apprCodeTxt.Location = new Point(31, 263);
            apprCodeTxt.Name = "apprCodeTxt";
            apprCodeTxt.Size = new Size(140, 23);
            apprCodeTxt.TabIndex = 33;
            // 
            // orderIdLbl
            // 
            orderIdLbl.AutoSize = true;
            orderIdLbl.Location = new Point(546, 81);
            orderIdLbl.Name = "orderIdLbl";
            orderIdLbl.Size = new Size(51, 15);
            orderIdLbl.TabIndex = 32;
            orderIdLbl.Text = "Order ID";
            // 
            // orderIdTxt
            // 
            orderIdTxt.Location = new Point(546, 99);
            orderIdTxt.Name = "orderIdTxt";
            orderIdTxt.Size = new Size(140, 23);
            orderIdTxt.TabIndex = 31;
            // 
            // cardInputTypeLbl
            // 
            cardInputTypeLbl.AutoSize = true;
            cardInputTypeLbl.Location = new Point(374, 133);
            cardInputTypeLbl.Name = "cardInputTypeLbl";
            cardInputTypeLbl.Size = new Size(91, 15);
            cardInputTypeLbl.TabIndex = 42;
            cardInputTypeLbl.Text = "Card Input Type";
            // 
            // cardInputTypeTxt
            // 
            cardInputTypeTxt.Location = new Point(374, 151);
            cardInputTypeTxt.Name = "cardInputTypeTxt";
            cardInputTypeTxt.Size = new Size(140, 23);
            cardInputTypeTxt.TabIndex = 41;
            // 
            // tradeNoLbl
            // 
            tradeNoLbl.AutoSize = true;
            tradeNoLbl.Location = new Point(200, 244);
            tradeNoLbl.Name = "tradeNoLbl";
            tradeNoLbl.Size = new Size(83, 15);
            tradeNoLbl.TabIndex = 40;
            tradeNoLbl.Text = "Trade Number";
            // 
            // tradeNoTxt
            // 
            tradeNoTxt.Location = new Point(200, 262);
            tradeNoTxt.Name = "tradeNoTxt";
            tradeNoTxt.Size = new Size(140, 23);
            tradeNoTxt.TabIndex = 39;
            // 
            // installmentPeriodLbl
            // 
            installmentPeriodLbl.AutoSize = true;
            installmentPeriodLbl.Location = new Point(546, 133);
            installmentPeriodLbl.Name = "installmentPeriodLbl";
            installmentPeriodLbl.Size = new Size(103, 15);
            installmentPeriodLbl.TabIndex = 38;
            installmentPeriodLbl.Text = "Installment Period";
            // 
            // installmentPeriodTxt
            // 
            installmentPeriodTxt.Location = new Point(546, 151);
            installmentPeriodTxt.Name = "installmentPeriodTxt";
            installmentPeriodTxt.Size = new Size(140, 23);
            installmentPeriodTxt.TabIndex = 37;
            // 
            // resTxt
            // 
            resTxt.Location = new Point(372, 328);
            resTxt.Name = "resTxt";
            resTxt.Size = new Size(309, 281);
            resTxt.TabIndex = 43;
            resTxt.Text = "";
            // 
            // consoleLbl
            // 
            consoleLbl.AutoSize = true;
            consoleLbl.Location = new Point(572, 20);
            consoleLbl.Margin = new Padding(3, 0, 0, 0);
            consoleLbl.Name = "consoleLbl";
            consoleLbl.Size = new Size(56, 15);
            consoleLbl.TabIndex = 44;
            consoleLbl.Text = "Console :";
            // 
            // consoleTrue
            // 
            consoleTrue.AutoSize = true;
            consoleTrue.Location = new Point(631, 20);
            consoleTrue.Name = "consoleTrue";
            consoleTrue.Size = new Size(46, 19);
            consoleTrue.TabIndex = 45;
            consoleTrue.TabStop = true;
            consoleTrue.Text = "true";
            consoleTrue.UseVisualStyleBackColor = true;
            // 
            // consoleFalse
            // 
            consoleFalse.AutoSize = true;
            consoleFalse.Location = new Point(631, 45);
            consoleFalse.Name = "consoleFalse";
            consoleFalse.Size = new Size(49, 19);
            consoleFalse.TabIndex = 46;
            consoleFalse.TabStop = true;
            consoleFalse.Text = "false";
            consoleFalse.UseVisualStyleBackColor = true;
            // 
            // consoleClear
            // 
            consoleClear.AutoSize = true;
            consoleClear.Location = new Point(575, 44);
            consoleClear.Name = "consoleClear";
            consoleClear.Size = new Size(50, 19);
            consoleClear.TabIndex = 47;
            consoleClear.TabStop = true;
            consoleClear.Text = "clear";
            consoleClear.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            ClientSize = new Size(710, 656);
            Controls.Add(consoleClear);
            Controls.Add(consoleFalse);
            Controls.Add(consoleTrue);
            Controls.Add(consoleLbl);
            Controls.Add(resTxt);
            Controls.Add(cardInputTypeLbl);
            Controls.Add(cardInputTypeTxt);
            Controls.Add(tradeNoLbl);
            Controls.Add(tradeNoTxt);
            Controls.Add(installmentPeriodLbl);
            Controls.Add(installmentPeriodTxt);
            Controls.Add(refNoLbl);
            Controls.Add(refNoTxt);
            Controls.Add(apprCodeLbl);
            Controls.Add(apprCodeTxt);
            Controls.Add(orderIdLbl);
            Controls.Add(orderIdTxt);
            Controls.Add(walletTypeLbl);
            Controls.Add(walletTypeTxt);
            Controls.Add(walletCodeLbl);
            Controls.Add(walletCodeTxt);
            Controls.Add(posIdLbl);
            Controls.Add(posIdTxt);
            Controls.Add(traceNoLbl);
            Controls.Add(traceNoTxt);
            Controls.Add(batchNoLbl);
            Controls.Add(batchNoTxt);
            Controls.Add(storeIdLbl);
            Controls.Add(storeIdTxt);
            Controls.Add(transDateLbl);
            Controls.Add(transDateTxt);
            Controls.Add(transAmoutLbl);
            Controls.Add(transAmountTxt);
            Controls.Add(recieptNoLbl);
            Controls.Add(recepitNoTxt);
            Controls.Add(overtimeLbl);
            Controls.Add(overtimeTxt);
            Controls.Add(commPortBox);
            Controls.Add(hostIdBox);
            Controls.Add(machineModelBox);
            Controls.Add(transTypeBox);
            Controls.Add(resLbl);
            Controls.Add(reqLbl);
            Controls.Add(reqTxt);
            Controls.Add(btnSendRequest);
            Controls.Add(btnStart);
            Name = "MainForm";
            Text = "RabbitMQ Listener";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnSendRequest;
        private RichTextBox reqTxt;
        private Label reqLbl;
        private Label resLbl;
        private ComboBox transTypeBox;
        private ComboBox machineModelBox;
        private ComboBox hostIdBox;
        private ComboBox commPortBox;
        private TextBox overtimeTxt;
        private Label overtimeLbl;
        private Label recieptNoLbl;
        private TextBox recepitNoTxt;
        private Label transAmoutLbl;
        private TextBox transAmountTxt;
        private Label transDateLbl;
        private TextBox transDateTxt;
        private Label storeIdLbl;
        private TextBox storeIdTxt;
        private Label batchNoLbl;
        private TextBox batchNoTxt;
        private Label traceNoLbl;
        private TextBox traceNoTxt;
        private Label walletTypeLbl;
        private TextBox walletTypeTxt;
        private Label walletCodeLbl;
        private TextBox walletCodeTxt;
        private Label posIdLbl;
        private TextBox posIdTxt;
        private Label refNoLbl;
        private TextBox refNoTxt;
        private Label apprCodeLbl;
        private TextBox apprCodeTxt;
        private Label orderIdLbl;
        private TextBox orderIdTxt;
        private Label cardInputTypeLbl;
        private TextBox cardInputTypeTxt;
        private Label tradeNoLbl;
        private TextBox tradeNoTxt;
        private Label installmentPeriodLbl;
        private TextBox installmentPeriodTxt;
        private RichTextBox resTxt;
        private Label consoleLbl;
        private RadioButton consoleTrue;
        private RadioButton consoleFalse;
        private RadioButton consoleClear;
    }
}