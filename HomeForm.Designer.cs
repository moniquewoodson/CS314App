namespace CS314App
{
    partial class HomeForm
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
            this.Account_button = new System.Windows.Forms.Button();
            this.Email_button = new System.Windows.Forms.Button();
            this.Contact_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Account_button
            // 
            this.Account_button.Location = new System.Drawing.Point(50, 50);
            this.Account_button.Name = "Account_button";
            this.Account_button.Size = new System.Drawing.Size(86, 67);
            this.Account_button.TabIndex = 0;
            this.Account_button.Text = "Account Form";
            this.Account_button.UseVisualStyleBackColor = true;
            this.Account_button.Click += new System.EventHandler(this.Account_button_Click);
            // 
            // Email_button
            // 
            this.Email_button.Location = new System.Drawing.Point(200, 50);
            this.Email_button.Name = "Email_button";
            this.Email_button.Size = new System.Drawing.Size(86, 67);
            this.Email_button.TabIndex = 1;
            this.Email_button.Text = "Email Form";
            this.Email_button.UseVisualStyleBackColor = true;
            this.Email_button.Click += new System.EventHandler(this.Email_button_Click);
            // 
            // Contact_button
            // 
            this.Contact_button.Location = new System.Drawing.Point(350, 50);
            this.Contact_button.Name = "Contact_button";
            this.Contact_button.Size = new System.Drawing.Size(86, 67);
            this.Contact_button.TabIndex = 2;
            this.Contact_button.Text = "Contact Form";
            this.Contact_button.UseVisualStyleBackColor = true;
            this.Contact_button.Click += new System.EventHandler(this.Contact_button_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.Contact_button);
            this.Controls.Add(this.Email_button);
            this.Controls.Add(this.Account_button);
            this.Name = "HomeForm";
            this.Text = "Home Form";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Account_button;
        private System.Windows.Forms.Button Email_button;
        private System.Windows.Forms.Button Contact_button;
    }
}