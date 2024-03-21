namespace UDP_TCP_Chat
{
    partial class TCPServer
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.newClient = new System.Windows.Forms.Button();
            this.historyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Firebrick;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(509, 61);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(127, 34);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // portBox
            // 
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.portBox.Location = new System.Drawing.Point(119, 61);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(145, 24);
            this.portBox.TabIndex = 10;
            this.portBox.Text = "8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(65, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(66, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Navy;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(376, 15);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(127, 33);
            this.start.TabIndex = 6;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // newClient
            // 
            this.newClient.BackColor = System.Drawing.Color.Green;
            this.newClient.FlatAppearance.BorderSize = 0;
            this.newClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.newClient.ForeColor = System.Drawing.Color.White;
            this.newClient.Location = new System.Drawing.Point(509, 15);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(127, 33);
            this.newClient.TabIndex = 7;
            this.newClient.Text = "New Client";
            this.newClient.UseVisualStyleBackColor = false;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // historyBox
            // 
            this.historyBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.historyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyBox.Location = new System.Drawing.Point(65, 126);
            this.historyBox.Multiline = true;
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(571, 297);
            this.historyBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(66, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Host";
            // 
            // ipBox
            // 
            this.ipBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipBox.Location = new System.Drawing.Point(119, 15);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(145, 22);
            this.ipBox.TabIndex = 13;
            this.ipBox.Text = "127.0.0.1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(376, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "To UDP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.newClient);
            this.Controls.Add(this.historyBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TCPServer";
            this.Text = "TCPServer";
            this.Load += new System.EventHandler(this.TCPServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.TextBox historyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button button1;
    }
}