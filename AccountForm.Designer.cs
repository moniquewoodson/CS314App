using System.Windows.Forms;

namespace CS314App
{
    partial class AccountForm
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
            this.MeunBar = new System.Windows.Forms.MenuStrip();
            this.File_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveChanges_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SwitchToViewMode_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SwitchToModifyMode_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountForm_panel = new System.Windows.Forms.Panel();
            this.SocialMedia_groupBox = new System.Windows.Forms.GroupBox();
            this.FB_textBox = new System.Windows.Forms.TextBox();
            this.IG_textBox = new System.Windows.Forms.TextBox();
            this.Twitter_textBox = new System.Windows.Forms.TextBox();
            this.FB_label = new System.Windows.Forms.Label();
            this.IG_label = new System.Windows.Forms.Label();
            this.Twitter_label = new System.Windows.Forms.Label();
            this.ContactInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.Cell_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Cell_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.LastName_label = new System.Windows.Forms.Label();
            this.FirstName_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.AddressInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.State_comboBox = new System.Windows.Forms.ComboBox();
            this.ZipCode_textBox = new System.Windows.Forms.TextBox();
            this.City_textBox = new System.Windows.Forms.TextBox();
            this.Street_textBox = new System.Windows.Forms.TextBox();
            this.ZipCode_label = new System.Windows.Forms.Label();
            this.State_label = new System.Windows.Forms.Label();
            this.City_label = new System.Windows.Forms.Label();
            this.Street_label = new System.Windows.Forms.Label();
            this.MeunBar.SuspendLayout();
            this.AccountForm_panel.SuspendLayout();
            this.SocialMedia_groupBox.SuspendLayout();
            this.ContactInfo_groupBox.SuspendLayout();
            this.AddressInfo_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MeunBar
            // 
            this.MeunBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStrip,
            this.Edit_ToolStrip,
            this.Help_ToolStrip});
            this.MeunBar.Location = new System.Drawing.Point(0, 0);
            this.MeunBar.Name = "MeunBar";
            this.MeunBar.Size = new System.Drawing.Size(884, 24);
            this.MeunBar.TabIndex = 0;
            this.MeunBar.Text = "menuStrip1";
            // 
            // File_ToolStrip
            // 
            this.File_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveChanges_ToolStrip,
            this.Close_ToolStrip});
            this.File_ToolStrip.Name = "File_ToolStrip";
            this.File_ToolStrip.Size = new System.Drawing.Size(37, 20);
            this.File_ToolStrip.Text = "File";
            this.File_ToolStrip.Click += new System.EventHandler(this.File_ToolStrip_Click);
            // 
            // SaveChanges_ToolStrip
            // 
            this.SaveChanges_ToolStrip.Name = "SaveChanges_ToolStrip";
            this.SaveChanges_ToolStrip.Size = new System.Drawing.Size(180, 22);
            this.SaveChanges_ToolStrip.Text = "Save Changes";
            this.SaveChanges_ToolStrip.Click += new System.EventHandler(this.SaveChanges_ToolStrip_Click);
            // 
            // Close_ToolStrip
            // 
            this.Close_ToolStrip.Name = "Close_ToolStrip";
            this.Close_ToolStrip.Size = new System.Drawing.Size(180, 22);
            this.Close_ToolStrip.Text = "Close";
            this.Close_ToolStrip.Click += new System.EventHandler(this.Close_ToolStrip_Click);
            // 
            // Edit_ToolStrip
            // 
            this.Edit_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SwitchToViewMode_ToolStrip,
            this.SwitchToModifyMode_ToolStrip});
            this.Edit_ToolStrip.Name = "Edit_ToolStrip";
            this.Edit_ToolStrip.Size = new System.Drawing.Size(39, 20);
            this.Edit_ToolStrip.Text = "Edit";
            // 
            // SwitchToViewMode_ToolStrip
            // 
            this.SwitchToViewMode_ToolStrip.Name = "SwitchToViewMode_ToolStrip";
            this.SwitchToViewMode_ToolStrip.Size = new System.Drawing.Size(198, 22);
            this.SwitchToViewMode_ToolStrip.Text = "Switch to View Mode";
            this.SwitchToViewMode_ToolStrip.Click += new System.EventHandler(this.SwitchToViewMode_ToolStrip_Click);
            // 
            // SwitchToModifyMode_ToolStrip
            // 
            this.SwitchToModifyMode_ToolStrip.Name = "SwitchToModifyMode_ToolStrip";
            this.SwitchToModifyMode_ToolStrip.Size = new System.Drawing.Size(198, 22);
            this.SwitchToModifyMode_ToolStrip.Text = "Switch to Modify Mode";
            this.SwitchToModifyMode_ToolStrip.Click += new System.EventHandler(this.SwitchToModifyMode_ToolStrip_Click);
            // 
            // Help_ToolStrip
            // 
            this.Help_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_ToolStrip});
            this.Help_ToolStrip.Name = "Help_ToolStrip";
            this.Help_ToolStrip.Size = new System.Drawing.Size(44, 20);
            this.Help_ToolStrip.Text = "Help";
            // 
            // About_ToolStrip
            // 
            this.About_ToolStrip.Name = "About_ToolStrip";
            this.About_ToolStrip.Size = new System.Drawing.Size(107, 22);
            this.About_ToolStrip.Text = "About";
            this.About_ToolStrip.Click += new System.EventHandler(this.About_ToolStrip_Click);
            // 
            // AccountForm_panel
            // 
            this.AccountForm_panel.Controls.Add(this.SocialMedia_groupBox);
            this.AccountForm_panel.Controls.Add(this.ContactInfo_groupBox);
            this.AccountForm_panel.Controls.Add(this.LastName_textBox);
            this.AccountForm_panel.Controls.Add(this.FirstName_textBox);
            this.AccountForm_panel.Controls.Add(this.Password_textBox);
            this.AccountForm_panel.Controls.Add(this.Username_textBox);
            this.AccountForm_panel.Controls.Add(this.LastName_label);
            this.AccountForm_panel.Controls.Add(this.FirstName_label);
            this.AccountForm_panel.Controls.Add(this.Password_label);
            this.AccountForm_panel.Controls.Add(this.Username_label);
            this.AccountForm_panel.Controls.Add(this.AddressInfo_groupBox);
            this.AccountForm_panel.Location = new System.Drawing.Point(0, 27);
            this.AccountForm_panel.Name = "AccountForm_panel";
            this.AccountForm_panel.Size = new System.Drawing.Size(872, 626);
            this.AccountForm_panel.TabIndex = 1;
            this.AccountForm_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.AccountForm_panel_Paint);
            // 
            // SocialMedia_groupBox
            // 
            this.SocialMedia_groupBox.Controls.Add(this.FB_textBox);
            this.SocialMedia_groupBox.Controls.Add(this.IG_textBox);
            this.SocialMedia_groupBox.Controls.Add(this.Twitter_textBox);
            this.SocialMedia_groupBox.Controls.Add(this.FB_label);
            this.SocialMedia_groupBox.Controls.Add(this.IG_label);
            this.SocialMedia_groupBox.Controls.Add(this.Twitter_label);
            this.SocialMedia_groupBox.Location = new System.Drawing.Point(13, 448);
            this.SocialMedia_groupBox.Name = "SocialMedia_groupBox";
            this.SocialMedia_groupBox.Size = new System.Drawing.Size(842, 176);
            this.SocialMedia_groupBox.TabIndex = 10;
            this.SocialMedia_groupBox.TabStop = false;
            this.SocialMedia_groupBox.Text = "Social Media";
            // 
            // FB_textBox
            // 
            this.FB_textBox.Location = new System.Drawing.Point(196, 120);
            this.FB_textBox.Name = "FB_textBox";
            this.FB_textBox.Size = new System.Drawing.Size(348, 20);
            this.FB_textBox.TabIndex = 5;
            // 
            // IG_textBox
            // 
            this.IG_textBox.Location = new System.Drawing.Point(196, 82);
            this.IG_textBox.Name = "IG_textBox";
            this.IG_textBox.Size = new System.Drawing.Size(348, 20);
            this.IG_textBox.TabIndex = 4;
            // 
            // Twitter_textBox
            // 
            this.Twitter_textBox.Location = new System.Drawing.Point(196, 44);
            this.Twitter_textBox.Name = "Twitter_textBox";
            this.Twitter_textBox.Size = new System.Drawing.Size(348, 20);
            this.Twitter_textBox.TabIndex = 3;
            // 
            // FB_label
            // 
            this.FB_label.AutoSize = true;
            this.FB_label.Location = new System.Drawing.Point(132, 123);
            this.FB_label.Name = "FB_label";
            this.FB_label.Size = new System.Drawing.Size(58, 13);
            this.FB_label.TabIndex = 2;
            this.FB_label.Text = "Facebook:";
            // 
            // IG_label
            // 
            this.IG_label.AutoSize = true;
            this.IG_label.Location = new System.Drawing.Point(134, 85);
            this.IG_label.Name = "IG_label";
            this.IG_label.Size = new System.Drawing.Size(56, 13);
            this.IG_label.TabIndex = 1;
            this.IG_label.Text = "Instagram:";
            // 
            // Twitter_label
            // 
            this.Twitter_label.AutoSize = true;
            this.Twitter_label.Location = new System.Drawing.Point(148, 47);
            this.Twitter_label.Name = "Twitter_label";
            this.Twitter_label.Size = new System.Drawing.Size(42, 13);
            this.Twitter_label.TabIndex = 0;
            this.Twitter_label.Text = "Twitter:";
            // 
            // ContactInfo_groupBox
            // 
            this.ContactInfo_groupBox.Controls.Add(this.Cell_textBox);
            this.ContactInfo_groupBox.Controls.Add(this.Email_textBox);
            this.ContactInfo_groupBox.Controls.Add(this.Cell_label);
            this.ContactInfo_groupBox.Controls.Add(this.Email_label);
            this.ContactInfo_groupBox.Location = new System.Drawing.Point(12, 280);
            this.ContactInfo_groupBox.Name = "ContactInfo_groupBox";
            this.ContactInfo_groupBox.Size = new System.Drawing.Size(842, 150);
            this.ContactInfo_groupBox.TabIndex = 9;
            this.ContactInfo_groupBox.TabStop = false;
            this.ContactInfo_groupBox.Text = "Contact Info";
            // 
            // Cell_textBox
            // 
            this.Cell_textBox.Location = new System.Drawing.Point(90, 89);
            this.Cell_textBox.Name = "Cell_textBox";
            this.Cell_textBox.Size = new System.Drawing.Size(408, 20);
            this.Cell_textBox.TabIndex = 3;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(90, 41);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(620, 20);
            this.Email_textBox.TabIndex = 2;
            // 
            // Cell_label
            // 
            this.Cell_label.AutoSize = true;
            this.Cell_label.Location = new System.Drawing.Point(57, 92);
            this.Cell_label.Name = "Cell_label";
            this.Cell_label.Size = new System.Drawing.Size(27, 13);
            this.Cell_label.TabIndex = 1;
            this.Cell_label.Text = "Cell:";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(49, 41);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(35, 13);
            this.Email_label.TabIndex = 0;
            this.Email_label.Text = "Email:";
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Location = new System.Drawing.Point(516, 55);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(282, 20);
            this.LastName_textBox.TabIndex = 8;
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Location = new System.Drawing.Point(516, 24);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(282, 20);
            this.FirstName_textBox.TabIndex = 7;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(102, 55);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(282, 20);
            this.Password_textBox.TabIndex = 6;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(102, 24);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(282, 20);
            this.Username_textBox.TabIndex = 5;
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Location = new System.Drawing.Point(449, 58);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(61, 13);
            this.LastName_label.TabIndex = 4;
            this.LastName_label.Text = "Last Name:";
            // 
            // FirstName_label
            // 
            this.FirstName_label.AutoSize = true;
            this.FirstName_label.Location = new System.Drawing.Point(450, 27);
            this.FirstName_label.Name = "FirstName_label";
            this.FirstName_label.Size = new System.Drawing.Size(60, 13);
            this.FirstName_label.TabIndex = 3;
            this.FirstName_label.Text = "First Name:";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(40, 58);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(56, 13);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password:";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(38, 27);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(58, 13);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username:";
            // 
            // AddressInfo_groupBox
            // 
            this.AddressInfo_groupBox.Controls.Add(this.State_comboBox);
            this.AddressInfo_groupBox.Controls.Add(this.ZipCode_textBox);
            this.AddressInfo_groupBox.Controls.Add(this.City_textBox);
            this.AddressInfo_groupBox.Controls.Add(this.Street_textBox);
            this.AddressInfo_groupBox.Controls.Add(this.ZipCode_label);
            this.AddressInfo_groupBox.Controls.Add(this.State_label);
            this.AddressInfo_groupBox.Controls.Add(this.City_label);
            this.AddressInfo_groupBox.Controls.Add(this.Street_label);
            this.AddressInfo_groupBox.Location = new System.Drawing.Point(12, 100);
            this.AddressInfo_groupBox.Name = "AddressInfo_groupBox";
            this.AddressInfo_groupBox.Size = new System.Drawing.Size(842, 164);
            this.AddressInfo_groupBox.TabIndex = 0;
            this.AddressInfo_groupBox.TabStop = false;
            this.AddressInfo_groupBox.Text = "Address Info";
            // 
            // State_comboBox
            // 
            this.State_comboBox.FormattingEnabled = true;
            this.State_comboBox.Items.AddRange(new object[] {
            "Alabama",
            "California",
            "Florida",
            "Illinois",
            "New York"});
            this.State_comboBox.Location = new System.Drawing.Point(93, 108);
            this.State_comboBox.Name = "State_comboBox";
            this.State_comboBox.Size = new System.Drawing.Size(134, 21);
            this.State_comboBox.TabIndex = 8;
            // 
            // ZipCode_textBox
            // 
            this.ZipCode_textBox.Location = new System.Drawing.Point(345, 109);
            this.ZipCode_textBox.Name = "ZipCode_textBox";
            this.ZipCode_textBox.Size = new System.Drawing.Size(153, 20);
            this.ZipCode_textBox.TabIndex = 7;
            // 
            // City_textBox
            // 
            this.City_textBox.Location = new System.Drawing.Point(90, 69);
            this.City_textBox.Name = "City_textBox";
            this.City_textBox.Size = new System.Drawing.Size(454, 20);
            this.City_textBox.TabIndex = 5;
            this.City_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Street_textBox
            // 
            this.Street_textBox.Location = new System.Drawing.Point(90, 35);
            this.Street_textBox.Name = "Street_textBox";
            this.Street_textBox.Size = new System.Drawing.Size(620, 20);
            this.Street_textBox.TabIndex = 4;
            // 
            // ZipCode_label
            // 
            this.ZipCode_label.AutoSize = true;
            this.ZipCode_label.Location = new System.Drawing.Point(286, 112);
            this.ZipCode_label.Name = "ZipCode_label";
            this.ZipCode_label.Size = new System.Drawing.Size(53, 13);
            this.ZipCode_label.TabIndex = 3;
            this.ZipCode_label.Text = "Zip Code:";
            // 
            // State_label
            // 
            this.State_label.AutoSize = true;
            this.State_label.Location = new System.Drawing.Point(52, 112);
            this.State_label.Name = "State_label";
            this.State_label.Size = new System.Drawing.Size(35, 13);
            this.State_label.TabIndex = 2;
            this.State_label.Text = "State:";
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.Location = new System.Drawing.Point(57, 72);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(27, 13);
            this.City_label.TabIndex = 1;
            this.City_label.Text = "City:";
            // 
            // Street_label
            // 
            this.Street_label.AutoSize = true;
            this.Street_label.Location = new System.Drawing.Point(49, 38);
            this.Street_label.Name = "Street_label";
            this.Street_label.Size = new System.Drawing.Size(38, 13);
            this.Street_label.TabIndex = 0;
            this.Street_label.Text = "Street:";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 651);
            this.Controls.Add(this.AccountForm_panel);
            this.Controls.Add(this.MeunBar);
            this.MainMenuStrip = this.MeunBar;
            this.Name = "AccountForm";
            this.Text = "Account Form";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.MeunBar.ResumeLayout(false);
            this.MeunBar.PerformLayout();
            this.AccountForm_panel.ResumeLayout(false);
            this.AccountForm_panel.PerformLayout();
            this.SocialMedia_groupBox.ResumeLayout(false);
            this.SocialMedia_groupBox.PerformLayout();
            this.ContactInfo_groupBox.ResumeLayout(false);
            this.ContactInfo_groupBox.PerformLayout();
            this.AddressInfo_groupBox.ResumeLayout(false);
            this.AddressInfo_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MeunBar;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveChanges_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem Close_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem Edit_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SwitchToViewMode_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SwitchToModifyMode_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem Help_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStrip;
        private Panel AccountForm_panel;
        private GroupBox SocialMedia_groupBox;
        private GroupBox ContactInfo_groupBox;
        private TextBox LastName_textBox;
        private TextBox FirstName_textBox;
        private TextBox Password_textBox;
        private TextBox Username_textBox;
        private Label LastName_label;
        private Label FirstName_label;
        private Label Password_label;
        private Label Username_label;
        private GroupBox AddressInfo_groupBox;
        private Label ZipCode_label;
        private Label State_label;
        private Label City_label;
        private Label Street_label;
        private TextBox ZipCode_textBox;
        private TextBox City_textBox;
        private TextBox Street_textBox;
        private ComboBox State_comboBox;
        private TextBox FB_textBox;
        private TextBox IG_textBox;
        private TextBox Twitter_textBox;
        private Label FB_label;
        private Label IG_label;
        private Label Twitter_label;
        private TextBox Cell_textBox;
        private TextBox Email_textBox;
        private Label Cell_label;
        private Label Email_label;
    }
    
}