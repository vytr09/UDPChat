namespace UDP_TCP_Chat
{
    partial class TCPClient
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.historyBox = new System.Windows.Forms.TextBox();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(141, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(30, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Host Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(326, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(33, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "IP Remote Host";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Firebrick;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(409, 49);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(88, 37);
            this.closeBtn.TabIndex = 17;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Navy;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(503, 390);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(88, 37);
            this.sendBtn.TabIndex = 16;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // historyBox
            // 
            this.historyBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.historyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyBox.Location = new System.Drawing.Point(33, 105);
            this.historyBox.Multiline = true;
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(464, 253);
            this.historyBox.TabIndex = 15;
            // 
            // msgBox
            // 
            this.msgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgBox.Location = new System.Drawing.Point(141, 390);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(356, 37);
            this.msgBox.TabIndex = 14;
            // 
            // hostBox
            // 
            this.hostBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hostBox.Location = new System.Drawing.Point(33, 390);
            this.hostBox.Multiline = true;
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(89, 37);
            this.hostBox.TabIndex = 13;
            this.hostBox.Text = "localhost";
            // 
            // portBox
            // 
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portBox.Location = new System.Drawing.Point(376, 21);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(121, 22);
            this.portBox.TabIndex = 12;
            this.portBox.Text = "8080";
            // 
            // IPBox
            // 
            this.IPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IPBox.Location = new System.Drawing.Point(163, 21);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(103, 24);
            this.IPBox.TabIndex = 11;
            this.IPBox.Text = "127.0.0.1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(315, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "To UDP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.IPBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TCPClient";
            this.Text = "TCPClient";
            this.Load += new System.EventHandler(this.TCPClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox historyBox;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Button button1;
    }
}