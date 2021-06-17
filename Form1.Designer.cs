
namespace mailReader
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serverName = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.ssl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retrieve Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 386);
            this.textBox1.TabIndex = 1;
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(12, 12);
            this.serverName.Name = "serverName";
            this.serverName.PlaceholderText = "IMAP Server Name";
            this.serverName.Size = new System.Drawing.Size(336, 31);
            this.serverName.TabIndex = 2;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(12, 49);
            this.port.Name = "port";
            this.port.PlaceholderText = "Port";
            this.port.Size = new System.Drawing.Size(336, 31);
            this.port.TabIndex = 3;
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(12, 121);
            this.userId.Name = "userId";
            this.userId.PlaceholderText = "Email Address";
            this.userId.Size = new System.Drawing.Size(336, 31);
            this.userId.TabIndex = 5;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(11, 158);
            this.pwd.Name = "pwd";
            this.pwd.PlaceholderText = "Password";
            this.pwd.Size = new System.Drawing.Size(337, 31);
            this.pwd.TabIndex = 6;
            // 
            // ssl
            // 
            this.ssl.AutoSize = true;
            this.ssl.Location = new System.Drawing.Point(12, 86);
            this.ssl.Name = "ssl";
            this.ssl.Size = new System.Drawing.Size(108, 29);
            this.ssl.TabIndex = 7;
            this.ssl.Text = "Use SSL?";
            this.ssl.UseVisualStyleBackColor = true;
            this.ssl.CheckedChanged += new System.EventHandler(this.ssl_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 408);
            this.Controls.Add(this.ssl);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.port);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Mail Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.CheckBox ssl;
    }
}

