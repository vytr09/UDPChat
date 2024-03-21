namespace UDP_TCP_Chat
{
    partial class UDPServer
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
            this.historyBox = new System.Windows.Forms.TextBox();
            this.newClient = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tcpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyBox
            // 
            this.historyBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.historyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyBox.Location = new System.Drawing.Point(35, 115);
            this.historyBox.Multiline = true;
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(551, 297);
            this.historyBox.TabIndex = 0;
            this.historyBox.TextChanged += new System.EventHandler(this.historyBox_TextChanged);
            // 
            // newClient
            // 
            this.newClient.BackColor = System.Drawing.Color.Green;
            this.newClient.FlatAppearance.BorderSize = 0;
            this.newClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.newClient.ForeColor = System.Drawing.Color.White;
            this.newClient.Location = new System.Drawing.Point(479, 22);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(125, 33);
            this.newClient.TabIndex = 1;
            this.newClient.Text = "New Client";
            this.newClient.UseVisualStyleBackColor = false;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Navy;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(348, 22);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(125, 33);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // portBox
            // 
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.portBox.Location = new System.Drawing.Point(88, 26);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(145, 24);
            this.portBox.TabIndex = 3;
            this.portBox.Text = "8080";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Firebrick;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(479, 61);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(125, 34);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "History";
            // 
            // tcpBtn
            // 
            this.tcpBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.tcpBtn.FlatAppearance.BorderSize = 0;
            this.tcpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tcpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcpBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tcpBtn.Location = new System.Drawing.Point(348, 61);
            this.tcpBtn.Name = "tcpBtn";
            this.tcpBtn.Size = new System.Drawing.Size(125, 34);
            this.tcpBtn.TabIndex = 12;
            this.tcpBtn.Text = "To TCP";
            this.tcpBtn.UseVisualStyleBackColor = false;
            this.tcpBtn.Click += new System.EventHandler(this.tcpBtn_Click);
            // 
            // UDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.tcpBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.newClient);
            this.Controls.Add(this.historyBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UDPServer";
            this.Text = "UDP Server - 22521709";
            this.Load += new System.EventHandler(this.UDPServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox historyBox;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tcpBtn;
    }
}

