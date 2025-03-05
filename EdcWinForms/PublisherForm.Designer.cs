namespace EdcWinForms
{
    partial class PublisherForm
    {
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;

        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();

            this.txtMessage.Location = new System.Drawing.Point(20, 20);
            this.txtMessage.Size = new System.Drawing.Size(250, 30);

            this.btnSend.Location = new System.Drawing.Point(20, 60);
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
        }
    }
}