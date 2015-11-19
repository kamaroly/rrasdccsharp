namespace SerialComms
{
    partial class MainWindows
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
            this.btnShowPorts = new System.Windows.Forms.Button();
            this.comboBoxListPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxHandShaking = new System.Windows.Forms.ComboBox();
            this.lblCTSStatus = new System.Windows.Forms.Label();
            this.lblDSRStatus = new System.Windows.Forms.Label();
            this.lblRIStatus = new System.Windows.Forms.Label();
            this.lblBreakStatus = new System.Windows.Forms.Label();
            this.comboBoxBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.labelPortState = new System.Windows.Forms.Label();
            this.richTextCommand = new System.Windows.Forms.RichTextBox();
            this.richTextResponse = new System.Windows.Forms.RichTextBox();
            this.SDC_ID_Status = new System.Windows.Forms.Button();
            this.SDCIDcmd = new System.Windows.Forms.Button();
            this.ReceiptDataToSDC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.requestSignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPorts
            // 
            this.btnShowPorts.Location = new System.Drawing.Point(43, 43);
            this.btnShowPorts.Name = "btnShowPorts";
            this.btnShowPorts.Size = new System.Drawing.Size(75, 23);
            this.btnShowPorts.TabIndex = 0;
            this.btnShowPorts.Text = "Show ports";
            this.btnShowPorts.UseVisualStyleBackColor = true;
            this.btnShowPorts.Click += new System.EventHandler(this.btnShowPorts_Click);
            // 
            // comboBoxListPorts
            // 
            this.comboBoxListPorts.FormattingEnabled = true;
            this.comboBoxListPorts.Location = new System.Drawing.Point(144, 45);
            this.comboBoxListPorts.Name = "comboBoxListPorts";
            this.comboBoxListPorts.Size = new System.Drawing.Size(166, 21);
            this.comboBoxListPorts.TabIndex = 1;
            this.comboBoxListPorts.Text = "Select port";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(144, 86);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(166, 21);
            this.comboBoxBaudRate.TabIndex = 2;
            // 
            // comboBoxHandShaking
            // 
            this.comboBoxHandShaking.FormattingEnabled = true;
            this.comboBoxHandShaking.Location = new System.Drawing.Point(144, 122);
            this.comboBoxHandShaking.Name = "comboBoxHandShaking";
            this.comboBoxHandShaking.Size = new System.Drawing.Size(166, 21);
            this.comboBoxHandShaking.TabIndex = 3;
            // 
            // lblCTSStatus
            // 
            this.lblCTSStatus.Location = new System.Drawing.Point(0, 0);
            this.lblCTSStatus.Name = "lblCTSStatus";
            this.lblCTSStatus.Size = new System.Drawing.Size(100, 23);
            this.lblCTSStatus.TabIndex = 3;
            // 
            // lblDSRStatus
            // 
            this.lblDSRStatus.Location = new System.Drawing.Point(0, 0);
            this.lblDSRStatus.Name = "lblDSRStatus";
            this.lblDSRStatus.Size = new System.Drawing.Size(100, 23);
            this.lblDSRStatus.TabIndex = 2;
            // 
            // lblRIStatus
            // 
            this.lblRIStatus.Location = new System.Drawing.Point(0, 0);
            this.lblRIStatus.Name = "lblRIStatus";
            this.lblRIStatus.Size = new System.Drawing.Size(100, 23);
            this.lblRIStatus.TabIndex = 1;
            // 
            // lblBreakStatus
            // 
            this.lblBreakStatus.Location = new System.Drawing.Point(0, 0);
            this.lblBreakStatus.Name = "lblBreakStatus";
            this.lblBreakStatus.Size = new System.Drawing.Size(100, 23);
            this.lblBreakStatus.TabIndex = 0;
            // 
            // comboBoxBits
            // 
            this.comboBoxBits.FormattingEnabled = true;
            this.comboBoxBits.Location = new System.Drawing.Point(144, 158);
            this.comboBoxBits.Name = "comboBoxBits";
            this.comboBoxBits.Size = new System.Drawing.Size(166, 21);
            this.comboBoxBits.TabIndex = 5;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(144, 198);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(166, 21);
            this.comboBoxParity.TabIndex = 6;
            // 
            // labelPortState
            // 
            this.labelPortState.AutoSize = true;
            this.labelPortState.Location = new System.Drawing.Point(141, 236);
            this.labelPortState.Name = "labelPortState";
            this.labelPortState.Size = new System.Drawing.Size(39, 13);
            this.labelPortState.TabIndex = 7;
            this.labelPortState.Text = "Closed";
            // 
            // richTextCommand
            // 
            this.richTextCommand.Location = new System.Drawing.Point(597, 58);
            this.richTextCommand.Name = "richTextCommand";
            this.richTextCommand.Size = new System.Drawing.Size(498, 49);
            this.richTextCommand.TabIndex = 9;
            this.richTextCommand.Text = "";
            // 
            // richTextResponse
            // 
            this.richTextResponse.Location = new System.Drawing.Point(597, 139);
            this.richTextResponse.Name = "richTextResponse";
            this.richTextResponse.Size = new System.Drawing.Size(498, 96);
            this.richTextResponse.TabIndex = 16;
            this.richTextResponse.Text = "";
            // 
            // SDC_ID_Status
            // 
            this.SDC_ID_Status.Location = new System.Drawing.Point(341, 71);
            this.SDC_ID_Status.Name = "SDC_ID_Status";
            this.SDC_ID_Status.Size = new System.Drawing.Size(177, 23);
            this.SDC_ID_Status.TabIndex = 0;
            this.SDC_ID_Status.Text = "Get SDC status";
            this.SDC_ID_Status.Click += new System.EventHandler(this.SDC_ID_Status_Click);
            // 
            // SDCIDcmd
            // 
            this.SDCIDcmd.Location = new System.Drawing.Point(341, 42);
            this.SDCIDcmd.Name = "SDCIDcmd";
            this.SDCIDcmd.Size = new System.Drawing.Size(177, 23);
            this.SDCIDcmd.TabIndex = 12;
            this.SDCIDcmd.Text = "Get SDC ID";
            this.SDCIDcmd.UseVisualStyleBackColor = true;
            this.SDCIDcmd.Click += new System.EventHandler(this.SDCIDcmd_Click);
            // 
            // ReceiptDataToSDC
            // 
            this.ReceiptDataToSDC.Location = new System.Drawing.Point(341, 100);
            this.ReceiptDataToSDC.Name = "ReceiptDataToSDC";
            this.ReceiptDataToSDC.Size = new System.Drawing.Size(177, 33);
            this.ReceiptDataToSDC.TabIndex = 13;
            this.ReceiptDataToSDC.Text = "Send Receipt Data to SDC";
            this.ReceiptDataToSDC.Click += new System.EventHandler(this.ReceiptDataToSDC_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "INPUT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "OUTPUT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // requestSignature
            // 
            this.requestSignature.Location = new System.Drawing.Point(341, 151);
            this.requestSignature.Name = "requestSignature";
            this.requestSignature.Size = new System.Drawing.Size(177, 33);
            this.requestSignature.TabIndex = 17;
            this.requestSignature.Text = "Request SIGNATURE";
            this.requestSignature.Click += new System.EventHandler(this.requestSignature_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 356);
            this.Controls.Add(this.requestSignature);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReceiptDataToSDC);
            this.Controls.Add(this.SDCIDcmd);
            this.Controls.Add(this.SDC_ID_Status);
            this.Controls.Add(this.richTextResponse);
            this.Controls.Add(this.richTextCommand);
            this.Controls.Add(this.labelPortState);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.comboBoxBits);
            this.Controls.Add(this.lblBreakStatus);
            this.Controls.Add(this.lblRIStatus);
            this.Controls.Add(this.lblDSRStatus);
            this.Controls.Add(this.lblCTSStatus);
            this.Controls.Add(this.comboBoxHandShaking);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboBoxListPorts);
            this.Controls.Add(this.btnShowPorts);
            this.Name = "MainWindows";
            this.Text = "Tigo Rwanda Serial port Communicator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowPorts;
        private System.Windows.Forms.ComboBox comboBoxListPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxHandShaking;
        private System.Windows.Forms.Label lblCTSStatus;
        private System.Windows.Forms.Label lblDSRStatus;
        private System.Windows.Forms.Label lblRIStatus;
        private System.Windows.Forms.Label lblBreakStatus;
        private System.Windows.Forms.ComboBox comboBoxBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label labelPortState;
        private System.Windows.Forms.RichTextBox richTextCommand;
        private System.Windows.Forms.RichTextBox richTextResponse;
        private System.Windows.Forms.Button SDC_ID_Status;
        private System.Windows.Forms.Button SDCIDcmd;
        private System.Windows.Forms.Button ReceiptDataToSDC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button requestSignature;
    }
}

