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
    public partial class Email_Form : Form
    {
        ContactForm contactForm;

        public Email_Form()
        {
            InitializeComponent();
        }

        private void Email_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void From_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_B10_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Send button is clicked");
            DataClass dataClass = new DataClass();

            dataClass.from = From_textBox.Text;
            dataClass.to = To_textBox.Text;
            dataClass.cc = Cc_textBox.Text;
            dataClass.subject = Subject_textBox.Text;
            dataClass.attachfiles = AttachFiles_textBox.Text;
            dataClass.email = Email_textBox.Text;

            dataClass.writeDataStream();
        }

        private void To_B10_Click(object sender, EventArgs e)
        {
            if ((null == contactForm) || (contactForm.IsDisposed))
            {
                contactForm = new ContactForm();
            }
            contactForm.disableContactForm_panel();
            contactForm.Show();
        }

        private void Cc_B10_Click(object sender, EventArgs e)
        {

        }

        private void Exit_B10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AttachFiles_B10_Click(object sender, EventArgs e)
        {

        }

        private void From_label_Click(object sender, EventArgs e)
        {

        }

        private void Subject_label_Click(object sender, EventArgs e)
        {

        }

        private void To_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cc_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subject_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AttachFiles_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
