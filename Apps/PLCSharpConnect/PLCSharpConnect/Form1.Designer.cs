namespace PLCSharpConnect
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
            this.components = new System.ComponentModel.Container();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPLCIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.winsock1 = new MelsecPLC.Winsock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(158, 109);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(147, 37);
            this.btnWrite.TabIndex = 19;
            this.btnWrite.Text = "Write Data to PLC";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(7, 109);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(145, 37);
            this.btnRead.TabIndex = 18;
            this.btnRead.Text = "Read Data from PLC";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(236, 61);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(87, 33);
            this.btnDisconnect.TabIndex = 17;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "PLC Write Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "PLC IP Address";
            // 
            // txtPLCIPAddress
            // 
            this.txtPLCIPAddress.Location = new System.Drawing.Point(114, 10);
            this.txtPLCIPAddress.Name = "txtPLCIPAddress";
            this.txtPLCIPAddress.Size = new System.Drawing.Size(116, 21);
            this.txtPLCIPAddress.TabIndex = 14;
            this.txtPLCIPAddress.Text = "10.126.224.221";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "PLC Read Data";
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(114, 73);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(116, 21);
            this.txtWrite.TabIndex = 12;
            this.txtWrite.Text = "0002";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 21);
            this.textBox1.TabIndex = 11;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(236, 9);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(87, 46);
            this.BtnConnect.TabIndex = 10;
            this.BtnConnect.Text = "PLC Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // winsock1
            // 
            this.winsock1.LocalPort = 80;
            this.winsock1.RemoteIP = "127.0.0.1";
            this.winsock1.RemotePort = 80;
            this.winsock1.DataArrival += new MelsecPLC.Winsock.DataArrivalEventHandler(this.winsock1_DataArrival);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 157);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPLCIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPLCIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnConnect;
        private MelsecPLC.Winsock winsock1;
        private System.Windows.Forms.Timer timer1;
    }
}

