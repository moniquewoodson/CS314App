namespace CS314App
{
    partial class Login
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
            this.Username_label = new System.Windows.Forms.Label();
            this.CreateNewAccount_link = new System.Windows.Forms.LinkLabel();
            this.Password_label = new System.Windows.Forms.Label();
            this.Login_B10 = new System.Windows.Forms.Button();
            this.Cancel_B10 = new System.Windows.Forms.Button();
            this.Login_Username_textBox = new System.Windows.Forms.TextBox();
            this.Login_Password_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(133, 72);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(58, 13);
            this.Username_label.TabIndex = 0;
            this.Username_label.Text = "Username:";
            // 
            // CreateNewAccount_link
            // 
            this.CreateNewAccount_link.AutoSize = true;
            this.CreateNewAccount_link.Location = new System.Drawing.Point(267, 159);
            this.CreateNewAccount_link.Name = "CreateNewAccount_link";
            this.CreateNewAccount_link.Size = new System.Drawing.Size(106, 13);
            this.CreateNewAccount_link.TabIndex = 1;
            this.CreateNewAccount_link.TabStop = true;
            this.CreateNewAccount_link.Text = "Create New Account";
            this.CreateNewAccount_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewAccount_link_LinkClicked);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(135, 114);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(56, 13);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password:";
            // 
            // Login_B10
            // 
            this.Login_B10.Location = new System.Drawing.Point(184, 197);
            this.Login_B10.Name = "Login_B10";
            this.Login_B10.Size = new System.Drawing.Size(75, 38);
            this.Login_B10.TabIndex = 3;
            this.Login_B10.Text = "Login";
            this.Login_B10.UseVisualStyleBackColor = true;
            this.Login_B10.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel_B10
            // 
            this.Cancel_B10.Location = new System.Drawing.Point(341, 197);
            this.Cancel_B10.Name = "Cancel_B10";
            this.Cancel_B10.Size = new System.Drawing.Size(75, 38);
            this.Cancel_B10.TabIndex = 4;
            this.Cancel_B10.Text = "Cancel";
            this.Cancel_B10.UseVisualStyleBackColor = true;
            this.Cancel_B10.Click += new System.EventHandler(this.Cancel_B10_Click);
            // 
            // Login_Username_textBox
            // 
            this.Login_Username_textBox.Location = new System.Drawing.Point(197, 65);
            this.Login_Username_textBox.Name = "Login_Username_textBox";
            this.Login_Username_textBox.Size = new System.Drawing.Size(246, 20);
            this.Login_Username_textBox.TabIndex = 5;
            this.Login_Username_textBox.TextChanged += new System.EventHandler(this.Username_textBox_TextChanged);
            // 
            // Login_Password_textBox
            // 
            this.Login_Password_textBox.Location = new System.Drawing.Point(197, 107);
            this.Login_Password_textBox.Name = "Login_Password_textBox";
            this.Login_Password_textBox.Size = new System.Drawing.Size(246, 20);
            this.Login_Password_textBox.TabIndex = 6;
            this.Login_Password_textBox.TextChanged += new System.EventHandler(this.Password_textBox_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.Login_Password_textBox);
            this.Controls.Add(this.Login_Username_textBox);
            this.Controls.Add(this.Cancel_B10);
            this.Controls.Add(this.Login_B10);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.CreateNewAccount_link);
            this.Controls.Add(this.Username_label);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.LinkLabel CreateNewAccount_link;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Login_B10;
        private System.Windows.Forms.Button Cancel_B10;
        private System.Windows.Forms.TextBox Login_Username_textBox;
        private System.Windows.Forms.TextBox Login_Password_textBox;
    }
}

