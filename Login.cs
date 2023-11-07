using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS314App
{
    public partial class Login : Form
    {
        AccountForm accountForm;
        HomeForm homeForm;
        public Login()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClass dataClass = new DataClass();
            dataClass.readDataStream();

                if (Login_Username_textBox.Text == "user1" && Login_Password_textBox.Text == "12345")
                {
                    //MessageBox.Show("Login was Sucessful");
                    if ((null == homeForm) || (homeForm.IsDisposed))
                    {
                        homeForm = new HomeForm();
                    }
                    homeForm.Show();
                }
                else
                {
                    MessageBox.Show("Error: Username and/or Password is incorrect.");
                }
            
        }

        private void CreateNewAccount_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((null == accountForm) || (accountForm.IsDisposed))
            {
                accountForm= new AccountForm(); 
            }
            accountForm.enableAccountForm_panel();
            accountForm.Show();
        }

        private void Cancel_B10_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cancel button was clicked");
            Close();
        }

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
