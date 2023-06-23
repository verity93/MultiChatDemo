
namespace MultiChatDemo
{
    partial class ChatWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutermostPanel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TextSendPanel = new System.Windows.Forms.Panel();
            this.Button_SendText = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SendTextLabelPanel = new System.Windows.Forms.Panel();
            this.Label_TextToBeSent = new System.Windows.Forms.Label();
            this.ConnectionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Button_ConnectToServer = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PortNumberLabelPanel = new System.Windows.Forms.Panel();
            this.Label_PortNumber = new System.Windows.Forms.Label();
            this.ServerAddressLabelPanel = new System.Windows.Forms.Panel();
            this.Label_ServerAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OutermostPanel.SuspendLayout();
            this.TextSendPanel.SuspendLayout();
            this.SendTextLabelPanel.SuspendLayout();
            this.ConnectionPanel.SuspendLayout();
            this.PortNumberLabelPanel.SuspendLayout();
            this.ServerAddressLabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutermostPanel
            // 
            this.OutermostPanel.Controls.Add(this.textBox3);
            this.OutermostPanel.Controls.Add(this.TextSendPanel);
            this.OutermostPanel.Controls.Add(this.ConnectionPanel);
            this.OutermostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutermostPanel.Location = new System.Drawing.Point(0, 0);
            this.OutermostPanel.Name = "OutermostPanel";
            this.OutermostPanel.Size = new System.Drawing.Size(800, 450);
            this.OutermostPanel.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 37);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(800, 326);
            this.textBox3.TabIndex = 1;
            // 
            // TextSendPanel
            // 
            this.TextSendPanel.Controls.Add(this.Button_SendText);
            this.TextSendPanel.Controls.Add(this.textBox4);
            this.TextSendPanel.Controls.Add(this.SendTextLabelPanel);
            this.TextSendPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextSendPanel.Location = new System.Drawing.Point(0, 363);
            this.TextSendPanel.Name = "TextSendPanel";
            this.TextSendPanel.Size = new System.Drawing.Size(800, 87);
            this.TextSendPanel.TabIndex = 2;
            // 
            // Button_SendText
            // 
            this.Button_SendText.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_SendText.Location = new System.Drawing.Point(725, 0);
            this.Button_SendText.Name = "Button_SendText";
            this.Button_SendText.Size = new System.Drawing.Size(75, 87);
            this.Button_SendText.TabIndex = 2;
            this.Button_SendText.Text = "Send";
            this.Button_SendText.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(98, 0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(702, 87);
            this.textBox4.TabIndex = 0;
            // 
            // SendTextLabelPanel
            // 
            this.SendTextLabelPanel.Controls.Add(this.Label_TextToBeSent);
            this.SendTextLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SendTextLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.SendTextLabelPanel.Name = "SendTextLabelPanel";
            this.SendTextLabelPanel.Size = new System.Drawing.Size(98, 87);
            this.SendTextLabelPanel.TabIndex = 3;
            // 
            // Label_TextToBeSent
            // 
            this.Label_TextToBeSent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_TextToBeSent.Location = new System.Drawing.Point(0, 0);
            this.Label_TextToBeSent.Name = "Label_TextToBeSent";
            this.Label_TextToBeSent.Size = new System.Drawing.Size(98, 87);
            this.Label_TextToBeSent.TabIndex = 1;
            this.Label_TextToBeSent.Text = "Text to Send";
            this.Label_TextToBeSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.ColumnCount = 5;
            this.ConnectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ConnectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ConnectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ConnectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ConnectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ConnectionPanel.Controls.Add(this.Button_ConnectToServer, 4, 0);
            this.ConnectionPanel.Controls.Add(this.textBox2, 3, 0);
            this.ConnectionPanel.Controls.Add(this.PortNumberLabelPanel, 2, 0);
            this.ConnectionPanel.Controls.Add(this.ServerAddressLabelPanel, 0, 0);
            this.ConnectionPanel.Controls.Add(this.textBox1, 1, 0);
            this.ConnectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectionPanel.Location = new System.Drawing.Point(0, 0);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.RowCount = 1;
            this.ConnectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConnectionPanel.Size = new System.Drawing.Size(800, 37);
            this.ConnectionPanel.TabIndex = 3;
            // 
            // Button_ConnectToServer
            // 
            this.Button_ConnectToServer.AutoSize = true;
            this.Button_ConnectToServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_ConnectToServer.Location = new System.Drawing.Point(683, 3);
            this.Button_ConnectToServer.Name = "Button_ConnectToServer";
            this.Button_ConnectToServer.Size = new System.Drawing.Size(114, 31);
            this.Button_ConnectToServer.TabIndex = 4;
            this.Button_ConnectToServer.Text = "Connect";
            this.Button_ConnectToServer.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(563, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 23);
            this.textBox2.TabIndex = 3;
            // 
            // PortNumberLabelPanel
            // 
            this.PortNumberLabelPanel.Controls.Add(this.Label_PortNumber);
            this.PortNumberLabelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortNumberLabelPanel.Location = new System.Drawing.Point(443, 3);
            this.PortNumberLabelPanel.Name = "PortNumberLabelPanel";
            this.PortNumberLabelPanel.Size = new System.Drawing.Size(114, 31);
            this.PortNumberLabelPanel.TabIndex = 6;
            // 
            // Label_PortNumber
            // 
            this.Label_PortNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_PortNumber.Location = new System.Drawing.Point(0, 0);
            this.Label_PortNumber.Name = "Label_PortNumber";
            this.Label_PortNumber.Size = new System.Drawing.Size(114, 31);
            this.Label_PortNumber.TabIndex = 2;
            this.Label_PortNumber.Text = "Port Number";
            this.Label_PortNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerAddressLabelPanel
            // 
            this.ServerAddressLabelPanel.AutoSize = true;
            this.ServerAddressLabelPanel.Controls.Add(this.Label_ServerAddress);
            this.ServerAddressLabelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerAddressLabelPanel.Location = new System.Drawing.Point(3, 3);
            this.ServerAddressLabelPanel.Name = "ServerAddressLabelPanel";
            this.ServerAddressLabelPanel.Size = new System.Drawing.Size(114, 31);
            this.ServerAddressLabelPanel.TabIndex = 5;
            // 
            // Label_ServerAddress
            // 
            this.Label_ServerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_ServerAddress.Location = new System.Drawing.Point(0, 0);
            this.Label_ServerAddress.Name = "Label_ServerAddress";
            this.Label_ServerAddress.Size = new System.Drawing.Size(114, 31);
            this.Label_ServerAddress.TabIndex = 1;
            this.Label_ServerAddress.Text = "Server Address";
            this.Label_ServerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(123, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 23);
            this.textBox1.TabIndex = 0;
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutermostPanel);
            this.Name = "ChatWindow";
            this.Text = "MultiChat Window";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitFilter);
            this.OutermostPanel.ResumeLayout(false);
            this.OutermostPanel.PerformLayout();
            this.TextSendPanel.ResumeLayout(false);
            this.TextSendPanel.PerformLayout();
            this.SendTextLabelPanel.ResumeLayout(false);
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            this.PortNumberLabelPanel.ResumeLayout(false);
            this.ServerAddressLabelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OutermostPanel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Button_ConnectToServer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Label_PortNumber;
        private System.Windows.Forms.Label Label_ServerAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel TextSendPanel;
        private System.Windows.Forms.Button Button_SendText;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Label_TextToBeSent;
        private System.Windows.Forms.TableLayoutPanel ConnectionPanel;
        private System.Windows.Forms.Panel PortNumberLabelPanel;
        private System.Windows.Forms.Panel ServerAddressLabelPanel;
        private System.Windows.Forms.Panel SendTextLabelPanel;
    }
}

