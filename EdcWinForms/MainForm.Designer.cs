namespace EdcWinForms
{
    partial class MainForm
    {
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStart;

        private void InitializeComponent()
        {
            lblStatus = new Label();
            btnStart = new Button();
            btnPublisher = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblStatus.Location = new Point(30, 30);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(184, 19);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Waiting for messages...";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(30, 70);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Listening";
            btnStart.Click += btnStart_Click;
            // 
            // btnPublisher
            // 
            btnPublisher.Location = new Point(30, 99);
            btnPublisher.Name = "btnPublisher";
            btnPublisher.Size = new Size(75, 23);
            btnPublisher.TabIndex = 2;
            btnPublisher.Text = "Open Publisher";
            btnPublisher.Click += BtnOpenPublisher_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(300, 150);
            Controls.Add(btnPublisher);
            Controls.Add(lblStatus);
            Controls.Add(btnStart);
            Name = "MainForm";
            Text = "RabbitMQ Listener";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnPublisher;
    }
}