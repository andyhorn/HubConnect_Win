namespace HubConnect
{
    partial class HubConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NetworkLabel = new System.Windows.Forms.Label();
            this.PwdLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NetworkTextBox = new System.Windows.Forms.TextBox();
            this.PwdTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DeviceSelectBox = new System.Windows.Forms.ComboBox();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.ScanButton = new System.Windows.Forms.Button();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(77, 70);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            // 
            // NetworkLabel
            // 
            this.NetworkLabel.AutoSize = true;
            this.NetworkLabel.Location = new System.Drawing.Point(31, 96);
            this.NetworkLabel.Name = "NetworkLabel";
            this.NetworkLabel.Size = new System.Drawing.Size(78, 13);
            this.NetworkLabel.TabIndex = 1;
            this.NetworkLabel.Text = "Network Name";
            // 
            // PwdLabel
            // 
            this.PwdLabel.AutoSize = true;
            this.PwdLabel.Location = new System.Drawing.Point(13, 122);
            this.PwdLabel.Name = "PwdLabel";
            this.PwdLabel.Size = new System.Drawing.Size(96, 13);
            this.PwdLabel.TabIndex = 2;
            this.PwdLabel.Text = "Network Password";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(115, 67);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(157, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // NetworkTextBox
            // 
            this.NetworkTextBox.Location = new System.Drawing.Point(115, 93);
            this.NetworkTextBox.Name = "NetworkTextBox";
            this.NetworkTextBox.Size = new System.Drawing.Size(157, 20);
            this.NetworkTextBox.TabIndex = 4;
            // 
            // PwdTextBox
            // 
            this.PwdTextBox.Location = new System.Drawing.Point(115, 119);
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.Size = new System.Drawing.Size(157, 20);
            this.PwdTextBox.TabIndex = 5;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.Location = new System.Drawing.Point(197, 239);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 25);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DeviceSelectBox
            // 
            this.DeviceSelectBox.FormattingEnabled = true;
            this.DeviceSelectBox.Items.AddRange(new object[] {
            "Select a device"});
            this.DeviceSelectBox.Location = new System.Drawing.Point(115, 21);
            this.DeviceSelectBox.Name = "DeviceSelectBox";
            this.DeviceSelectBox.Size = new System.Drawing.Size(157, 21);
            this.DeviceSelectBox.TabIndex = 7;
            this.DeviceSelectBox.SelectedIndexChanged += new System.EventHandler(this.DeviceSelectBox_SelectedIndexChanged);
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.AutoSize = true;
            this.DeviceLabel.Location = new System.Drawing.Point(68, 24);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(41, 13);
            this.DeviceLabel.TabIndex = 8;
            this.DeviceLabel.Text = "Device";
            // 
            // ScanButton
            // 
            this.ScanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScanButton.AutoSize = true;
            this.ScanButton.Location = new System.Drawing.Point(12, 239);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(75, 25);
            this.ScanButton.TabIndex = 9;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(112, 45);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.ConnectionStatusLabel.TabIndex = 11;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(13, 150);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 12;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.StatusTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StatusTextBox.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTextBox.Location = new System.Drawing.Point(12, 166);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatusTextBox.Size = new System.Drawing.Size(260, 65);
            this.StatusTextBox.TabIndex = 13;
            // 
            // HubConnectForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.DeviceLabel);
            this.Controls.Add(this.DeviceSelectBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PwdTextBox);
            this.Controls.Add(this.NetworkTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PwdLabel);
            this.Controls.Add(this.NetworkLabel);
            this.Controls.Add(this.EmailLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 315);
            this.MinimumSize = new System.Drawing.Size(300, 315);
            this.Name = "HubConnectForm";
            this.Text = "HubConnect";
            this.Load += new System.EventHandler(this.HubConnectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NetworkLabel;
        private System.Windows.Forms.Label PwdLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NetworkTextBox;
        private System.Windows.Forms.TextBox PwdTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox DeviceSelectBox;
        private System.Windows.Forms.Label DeviceLabel;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox StatusTextBox;
    }
}

