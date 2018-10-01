﻿namespace EV3RemoteControlWifi
{
    partial class Mainform
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
            this.sendMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.connectedDeviceLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.receivedDataGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.receivedMessagesGroupBox = new System.Windows.Forms.GroupBox();
            this.clearReceivedMessagesButton = new System.Windows.Forms.Button();
            this.receivedMessagesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sendMessageGroupBox.SuspendLayout();
            this.connectionGroupBox.SuspendLayout();
            this.receivedDataGroupBox.SuspendLayout();
            this.receivedMessagesGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendMessageGroupBox
            // 
            this.sendMessageGroupBox.Controls.Add(this.button1);
            this.sendMessageGroupBox.Location = new System.Drawing.Point(15, 162);
            this.sendMessageGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendMessageGroupBox.Name = "sendMessageGroupBox";
            this.sendMessageGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendMessageGroupBox.Size = new System.Drawing.Size(448, 240);
            this.sendMessageGroupBox.TabIndex = 2;
            this.sendMessageGroupBox.TabStop = false;
            this.sendMessageGroupBox.Text = "EV3 Move";
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.label3);
            this.connectionGroupBox.Controls.Add(this.ipAddressBox);
            this.connectionGroupBox.Controls.Add(this.connectedDeviceLabel);
            this.connectionGroupBox.Controls.Add(this.disconnectButton);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Location = new System.Drawing.Point(15, 15);
            this.connectionGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionGroupBox.Size = new System.Drawing.Size(1020, 132);
            this.connectionGroupBox.TabIndex = 3;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP address of EV3";
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Location = new System.Drawing.Point(68, 55);
            this.ipAddressBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(169, 26);
            this.ipAddressBox.TabIndex = 11;
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedDeviceLabel.Location = new System.Drawing.Point(645, 31);
            this.connectedDeviceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(216, 71);
            this.connectedDeviceLabel.TabIndex = 10;
            this.connectedDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(458, 77);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(112, 35);
            this.disconnectButton.TabIndex = 9;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(458, 23);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(112, 35);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // receivedDataGroupBox
            // 
            this.receivedDataGroupBox.Controls.Add(this.label2);
            this.receivedDataGroupBox.Controls.Add(this.angleTextBox);
            this.receivedDataGroupBox.Controls.Add(this.label1);
            this.receivedDataGroupBox.Controls.Add(this.distanceTextBox);
            this.receivedDataGroupBox.Location = new System.Drawing.Point(480, 423);
            this.receivedDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.receivedDataGroupBox.Name = "receivedDataGroupBox";
            this.receivedDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.receivedDataGroupBox.Size = new System.Drawing.Size(555, 115);
            this.receivedDataGroupBox.TabIndex = 4;
            this.receivedDataGroupBox.TabStop = false;
            this.receivedDataGroupBox.Text = "EV3 Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angle";
            // 
            // angleTextBox
            // 
            this.angleTextBox.Location = new System.Drawing.Point(345, 62);
            this.angleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(133, 26);
            this.angleTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(68, 62);
            this.distanceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(133, 26);
            this.distanceTextBox.TabIndex = 0;
            // 
            // receivedMessagesGroupBox
            // 
            this.receivedMessagesGroupBox.Controls.Add(this.clearReceivedMessagesButton);
            this.receivedMessagesGroupBox.Controls.Add(this.receivedMessagesListBox);
            this.receivedMessagesGroupBox.Location = new System.Drawing.Point(480, 162);
            this.receivedMessagesGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.receivedMessagesGroupBox.Name = "receivedMessagesGroupBox";
            this.receivedMessagesGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.receivedMessagesGroupBox.Size = new System.Drawing.Size(555, 238);
            this.receivedMessagesGroupBox.TabIndex = 5;
            this.receivedMessagesGroupBox.TabStop = false;
            this.receivedMessagesGroupBox.Text = "EV3 message receive";
            // 
            // clearReceivedMessagesButton
            // 
            this.clearReceivedMessagesButton.Location = new System.Drawing.Point(22, 185);
            this.clearReceivedMessagesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearReceivedMessagesButton.Name = "clearReceivedMessagesButton";
            this.clearReceivedMessagesButton.Size = new System.Drawing.Size(525, 35);
            this.clearReceivedMessagesButton.TabIndex = 2;
            this.clearReceivedMessagesButton.Text = "Clear";
            this.clearReceivedMessagesButton.UseVisualStyleBackColor = true;
            this.clearReceivedMessagesButton.Click += new System.EventHandler(this.clearReceivedMessagesButton_Click);
            // 
            // receivedMessagesListBox
            // 
            this.receivedMessagesListBox.FormattingEnabled = true;
            this.receivedMessagesListBox.ItemHeight = 20;
            this.receivedMessagesListBox.Location = new System.Drawing.Point(22, 31);
            this.receivedMessagesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.receivedMessagesListBox.Name = "receivedMessagesListBox";
            this.receivedMessagesListBox.Size = new System.Drawing.Size(523, 144);
            this.receivedMessagesListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(480, 554);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(555, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "version november 2017";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSend);
            this.groupBox2.Controls.Add(this.commandBox);
            this.groupBox2.Location = new System.Drawing.Point(15, 423);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(450, 208);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EV3 message send";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(172, 115);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(112, 35);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(15, 62);
            this.commandBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(418, 26);
            this.commandBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 136);
            this.button1.TabIndex = 0;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.receivedMessagesGroupBox);
            this.Controls.Add(this.receivedDataGroupBox);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.sendMessageGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mainform";
            this.Text = "EV3 Remote Control Wifi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.sendMessageGroupBox.ResumeLayout(false);
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.receivedDataGroupBox.ResumeLayout(false);
            this.receivedDataGroupBox.PerformLayout();
            this.receivedMessagesGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sendMessageGroupBox;
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.GroupBox receivedDataGroupBox;
        private System.Windows.Forms.GroupBox receivedMessagesGroupBox;
        private System.Windows.Forms.ListBox receivedMessagesListBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label connectedDeviceLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button clearReceivedMessagesButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipAddressBox;
        private System.Windows.Forms.Button button1;
    }
}

