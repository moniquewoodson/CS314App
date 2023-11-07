using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CS314App
{
    public partial class HomeForm : Form
    {
        AccountForm accountForm;
        Email_Form emailForm;
        ContactForm contactForm;
        DataClass dataClass = new DataClass();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void Home_label_Click(object sender, EventArgs e)
        {

        }

        private void Account_button_Click(object sender, EventArgs e)
        {
            if ((null == accountForm) || (accountForm.IsDisposed))
            {
                accountForm = new AccountForm();
            }
            accountForm.disableAccountForm_panel();
            accountForm.Show();
            

        }

        private void Email_button_Click(object sender, EventArgs e)
        {
            if ((null == emailForm) || (emailForm.IsDisposed))
            {
                emailForm= new Email_Form();
            }
            emailForm.Show();
        }

        private void Contact_button_Click(object sender, EventArgs e)
        {
            if ((null == contactForm) || (contactForm.IsDisposed))
            {
                contactForm = new ContactForm();
            }
            contactForm.enableContactForm_panel();
            contactForm.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
