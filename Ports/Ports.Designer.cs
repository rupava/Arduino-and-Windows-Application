namespace Ports
{
    partial class Ports
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
            this.components = new System.ComponentModel.Container();
            this.connectBT = new System.Windows.Forms.Button();
            this.disconnectBT = new System.Windows.Forms.Button();
            this.clearBT = new System.Windows.Forms.Button();
            this.scanBT = new System.Windows.Forms.Button();
            this.sendBT = new System.Windows.Forms.Button();
            this.comportCB = new System.Windows.Forms.ComboBox();
            this.baudrateCB = new System.Windows.Forms.ComboBox();
            this.incomingTB = new System.Windows.Forms.RichTextBox();
            this.outgoingTB = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // connectBT
            // 
            this.connectBT.Location = new System.Drawing.Point(29, 244);
            this.connectBT.Name = "connectBT";
            this.connectBT.Size = new System.Drawing.Size(114, 65);
            this.connectBT.TabIndex = 0;
            this.connectBT.Text = "CONNECT";
            this.connectBT.UseVisualStyleBackColor = true;
            this.connectBT.Click += new System.EventHandler(this.connectBT_Click);
            // 
            // disconnectBT
            // 
            this.disconnectBT.Enabled = false;
            this.disconnectBT.Location = new System.Drawing.Point(29, 315);
            this.disconnectBT.Name = "disconnectBT";
            this.disconnectBT.Size = new System.Drawing.Size(114, 65);
            this.disconnectBT.TabIndex = 1;
            this.disconnectBT.Text = "DISCONNECT";
            this.disconnectBT.UseVisualStyleBackColor = true;
            this.disconnectBT.Click += new System.EventHandler(this.disconnectBT_Click);
            // 
            // clearBT
            // 
            this.clearBT.Location = new System.Drawing.Point(344, 244);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(114, 65);
            this.clearBT.TabIndex = 2;
            this.clearBT.Text = "CLEAR";
            this.clearBT.UseVisualStyleBackColor = true;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // scanBT
            // 
            this.scanBT.Location = new System.Drawing.Point(186, 280);
            this.scanBT.Name = "scanBT";
            this.scanBT.Size = new System.Drawing.Size(114, 65);
            this.scanBT.TabIndex = 3;
            this.scanBT.Text = "SCAN";
            this.scanBT.UseVisualStyleBackColor = true;
            this.scanBT.Click += new System.EventHandler(this.scanBT_Click);
            // 
            // sendBT
            // 
            this.sendBT.Enabled = false;
            this.sendBT.Location = new System.Drawing.Point(344, 315);
            this.sendBT.Name = "sendBT";
            this.sendBT.Size = new System.Drawing.Size(114, 65);
            this.sendBT.TabIndex = 4;
            this.sendBT.Text = "SEND";
            this.sendBT.UseVisualStyleBackColor = true;
            this.sendBT.Click += new System.EventHandler(this.sendBT_Click);
            // 
            // comportCB
            // 
            this.comportCB.FormattingEnabled = true;
            this.comportCB.Location = new System.Drawing.Point(29, 192);
            this.comportCB.Name = "comportCB";
            this.comportCB.Size = new System.Drawing.Size(194, 24);
            this.comportCB.TabIndex = 5;
            // 
            // baudrateCB
            // 
            this.baudrateCB.FormattingEnabled = true;
            this.baudrateCB.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baudrateCB.Location = new System.Drawing.Point(264, 192);
            this.baudrateCB.Name = "baudrateCB";
            this.baudrateCB.Size = new System.Drawing.Size(194, 24);
            this.baudrateCB.TabIndex = 6;
            // 
            // incomingTB
            // 
            this.incomingTB.Location = new System.Drawing.Point(29, 23);
            this.incomingTB.Name = "incomingTB";
            this.incomingTB.Size = new System.Drawing.Size(198, 154);
            this.incomingTB.TabIndex = 7;
            this.incomingTB.Text = "";
            // 
            // outgoingTB
            // 
            this.outgoingTB.Location = new System.Drawing.Point(264, 23);
            this.outgoingTB.Name = "outgoingTB";
            this.outgoingTB.Size = new System.Drawing.Size(198, 154);
            this.outgoingTB.TabIndex = 8;
            this.outgoingTB.Text = "";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Ports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 403);
            this.Controls.Add(this.outgoingTB);
            this.Controls.Add(this.incomingTB);
            this.Controls.Add(this.baudrateCB);
            this.Controls.Add(this.comportCB);
            this.Controls.Add(this.sendBT);
            this.Controls.Add(this.scanBT);
            this.Controls.Add(this.clearBT);
            this.Controls.Add(this.disconnectBT);
            this.Controls.Add(this.connectBT);
            this.Name = "Ports";
            this.Text = "Ports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectBT;
        private System.Windows.Forms.Button disconnectBT;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Button scanBT;
        private System.Windows.Forms.Button sendBT;
        private System.Windows.Forms.ComboBox comportCB;
        private System.Windows.Forms.ComboBox baudrateCB;
        private System.Windows.Forms.RichTextBox incomingTB;
        private System.Windows.Forms.RichTextBox outgoingTB;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

