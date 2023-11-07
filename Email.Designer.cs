namespace CS314App
{
    partial class Email_Form
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
            this.Send_B10 = new System.Windows.Forms.Button();
            this.Exit_B10 = new System.Windows.Forms.Button();
            this.To_B10 = new System.Windows.Forms.Button();
            this.Cc_B10 = new System.Windows.Forms.Button();
            this.AttachFiles_B10 = new System.Windows.Forms.Button();
            this.AttachFiles_textBox = new System.Windows.Forms.TextBox();
            this.From_textBox = new System.Windows.Forms.TextBox();
            this.Cc_textBox = new System.Windows.Forms.TextBox();
            this.Subject_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.From_label = new System.Windows.Forms.Label();
            this.Subject_label = new System.Windows.Forms.Label();
            this.To_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Send_B10
            // 
            this.Send_B10.Location = new System.Drawing.Point(15, 12);
            this.Send_B10.Name = "Send_B10";
            this.Send_B10.Size = new System.Drawing.Size(86, 111);
            this.Send_B10.TabIndex = 0;
            this.Send_B10.Text = "Send";
            this.Send_B10.UseVisualStyleBackColor = true;
            this.Send_B10.Click += new System.EventHandler(this.Send_B10_Click);
            // 
            // Exit_B10
            // 
            this.Exit_B10.Location = new System.Drawing.Point(15, 133);
            this.Exit_B10.Name = "Exit_B10";
            this.Exit_B10.Size = new System.Drawing.Size(86, 37);
            this.Exit_B10.TabIndex = 1;
            this.Exit_B10.Text = "Exit";
            this.Exit_B10.UseVisualStyleBackColor = true;
            this.Exit_B10.Click += new System.EventHandler(this.Exit_B10_Click);
            // 
            // To_B10
            // 
            this.To_B10.Location = new System.Drawing.Point(126, 42);
            this.To_B10.Name = "To_B10";
            this.To_B10.Size = new System.Drawing.Size(76, 21);
            this.To_B10.TabIndex = 2;
            this.To_B10.Text = "To...";
            this.To_B10.UseVisualStyleBackColor = true;
            this.To_B10.Click += new System.EventHandler(this.To_B10_Click);
            // 
            // Cc_B10
            // 
            this.Cc_B10.Location = new System.Drawing.Point(126, 72);
            this.Cc_B10.Name = "Cc_B10";
            this.Cc_B10.Size = new System.Drawing.Size(76, 20);
            this.Cc_B10.TabIndex = 3;
            this.Cc_B10.Text = "Cc...";
            this.Cc_B10.UseVisualStyleBackColor = true;
            this.Cc_B10.Click += new System.EventHandler(this.Cc_B10_Click);
            // 
            // AttachFiles_B10
            // 
            this.AttachFiles_B10.Location = new System.Drawing.Point(126, 136);
            this.AttachFiles_B10.Name = "AttachFiles_B10";
            this.AttachFiles_B10.Size = new System.Drawing.Size(76, 20);
            this.AttachFiles_B10.TabIndex = 4;
            this.AttachFiles_B10.Text = "Attach Files:";
            this.AttachFiles_B10.UseVisualStyleBackColor = true;
            this.AttachFiles_B10.Click += new System.EventHandler(this.AttachFiles_B10_Click);
            // 
            // AttachFiles_textBox
            // 
            this.AttachFiles_textBox.Location = new System.Drawing.Point(208, 133);
            this.AttachFiles_textBox.Multiline = true;
            this.AttachFiles_textBox.Name = "AttachFiles_textBox";
            this.AttachFiles_textBox.Size = new System.Drawing.Size(454, 37);
            this.AttachFiles_textBox.TabIndex = 5;
            this.AttachFiles_textBox.TextChanged += new System.EventHandler(this.AttachFiles_textBox_TextChanged);
            // 
            // From_textBox
            // 
            this.From_textBox.Enabled = false;
            this.From_textBox.Location = new System.Drawing.Point(208, 12);
            this.From_textBox.Name = "From_textBox";
            this.From_textBox.Size = new System.Drawing.Size(454, 20);
            this.From_textBox.TabIndex = 8;
            this.From_textBox.TextChanged += new System.EventHandler(this.From_textBox_TextChanged);
            // 
            // Cc_textBox
            // 
            this.Cc_textBox.Location = new System.Drawing.Point(208, 72);
            this.Cc_textBox.Name = "Cc_textBox";
            this.Cc_textBox.Size = new System.Drawing.Size(454, 20);
            this.Cc_textBox.TabIndex = 10;
            this.Cc_textBox.TextChanged += new System.EventHandler(this.Cc_textBox_TextChanged);
            // 
            // Subject_textBox
            // 
            this.Subject_textBox.Location = new System.Drawing.Point(208, 103);
            this.Subject_textBox.Name = "Subject_textBox";
            this.Subject_textBox.Size = new System.Drawing.Size(454, 20);
            this.Subject_textBox.TabIndex = 11;
            this.Subject_textBox.TextChanged += new System.EventHandler(this.Subject_textBox_TextChanged);
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(15, 184);
            this.Email_textBox.Multiline = true;
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(647, 265);
            this.Email_textBox.TabIndex = 12;
            this.Email_textBox.TextChanged += new System.EventHandler(this.Email_textBox_TextChanged);
            // 
            // From_label
            // 
            this.From_label.AutoSize = true;
            this.From_label.Location = new System.Drawing.Point(169, 15);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(33, 13);
            this.From_label.TabIndex = 13;
            this.From_label.Text = "From:";
            this.From_label.Click += new System.EventHandler(this.From_label_Click);
            // 
            // Subject_label
            // 
            this.Subject_label.AutoSize = true;
            this.Subject_label.Location = new System.Drawing.Point(156, 103);
            this.Subject_label.Name = "Subject_label";
            this.Subject_label.Size = new System.Drawing.Size(46, 13);
            this.Subject_label.TabIndex = 14;
            this.Subject_label.Text = "Subject:";
            this.Subject_label.Click += new System.EventHandler(this.Subject_label_Click);
            // 
            // To_textBox
            // 
            this.To_textBox.Location = new System.Drawing.Point(208, 42);
            this.To_textBox.Name = "To_textBox";
            this.To_textBox.Size = new System.Drawing.Size(454, 20);
            this.To_textBox.TabIndex = 15;
            this.To_textBox.TextChanged += new System.EventHandler(this.To_textBox_TextChanged);
            // 
            // Email_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 461);
            this.Controls.Add(this.To_textBox);
            this.Controls.Add(this.Subject_label);
            this.Controls.Add(this.From_label);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.Subject_textBox);
            this.Controls.Add(this.Cc_textBox);
            this.Controls.Add(this.From_textBox);
            this.Controls.Add(this.AttachFiles_textBox);
            this.Controls.Add(this.AttachFiles_B10);
            this.Controls.Add(this.Cc_B10);
            this.Controls.Add(this.To_B10);
            this.Controls.Add(this.Exit_B10);
            this.Controls.Add(this.Send_B10);
            this.Name = "Email_Form";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_B10;
        private System.Windows.Forms.Button Exit_B10;
        private System.Windows.Forms.Button To_B10;
        private System.Windows.Forms.Button Cc_B10;
        private System.Windows.Forms.Button AttachFiles_B10;
        private System.Windows.Forms.TextBox AttachFiles_textBox;
        private System.Windows.Forms.TextBox From_textBox;
        private System.Windows.Forms.TextBox Cc_textBox;
        private System.Windows.Forms.TextBox Subject_textBox;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.Label Subject_label;
        private System.Windows.Forms.TextBox To_textBox;
    }
}