namespace ChatClient
{
    partial class Form1
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
            if (disposing && (components != null))
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
            this.ChatBox = new DevExpress.XtraEditors.MemoEdit();
            this.NameEdit = new DevExpress.XtraEditors.TextEdit();
            this.SendMessageEdit = new DevExpress.XtraEditors.TextEdit();
            this.ConnectButton = new DevExpress.XtraEditors.SimpleButton();
            this.DisconnectButton = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SendButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ChatBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendMessageEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ChatBox
            // 
            this.ChatBox.Location = new System.Drawing.Point(12, 12);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Properties.ReadOnly = true;
            this.ChatBox.Size = new System.Drawing.Size(422, 147);
            this.ChatBox.TabIndex = 0;
            // 
            // NameEdit
            // 
            this.NameEdit.EditValue = "User1";
            this.NameEdit.Location = new System.Drawing.Point(53, 165);
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Size = new System.Drawing.Size(114, 20);
            this.NameEdit.TabIndex = 1;
            // 
            // SendMessageEdit
            // 
            this.SendMessageEdit.Location = new System.Drawing.Point(15, 217);
            this.SendMessageEdit.Name = "SendMessageEdit";
            this.SendMessageEdit.Size = new System.Drawing.Size(337, 20);
            this.SendMessageEdit.TabIndex = 2;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(275, 165);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(77, 23);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(358, 165);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(76, 23);
            this.DisconnectButton.TabIndex = 4;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(358, 214);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(77, 23);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 314);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SendMessageEdit);
            this.Controls.Add(this.NameEdit);
            this.Controls.Add(this.ChatBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChatBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendMessageEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton ConnectButton;
        private DevExpress.XtraEditors.SimpleButton DisconnectButton;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton SendButton;
        public DevExpress.XtraEditors.MemoEdit ChatBox;
        public DevExpress.XtraEditors.TextEdit NameEdit;
        public DevExpress.XtraEditors.TextEdit SendMessageEdit;
    }
}

