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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
            if (ContactForm_panel.Enabled == false)
            {
                SaveChanges_ToolStrip2.Enabled = false;
            }
            else
            {
                SaveChanges_ToolStrip2.Enabled = true;
            }
        }
        public void disableContactForm_panel()
        {
            ContactForm_panel.Enabled = false;
            SaveChanges_ToolStrip2.Enabled = false;
        }
        public void enableContactForm_panel()
        {
            ContactForm_panel.Enabled = true;
            SaveChanges_ToolStrip2.Enabled = true;
        }
        /*
        public void open()
        {
            DataClass dataClass = new DataClass();
            dataClass.readDataStream();

            FirstName_textBox.Text = dataClass.firstname;
            LastName_textBox.Text = dataClass.lastname;
            Street_textBox.Text = dataClass.street;
            City_textBox.Text = dataClass.city;
            State_comboBox.Text = dataClass.state;
            ZipCode_textBox.Text = dataClass.zipcode;
            Email_textBox.Text = dataClass.email;
            Cell_textBox.Text = dataClass.cell;
            Twitter_textBox.Text = dataClass.twitter;
            IG_textBox.Text = dataClass.ig;
            FB_textBox.Text = dataClass.fb;
        }
        */

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }

        private void File_ToolStrip2_Click(object sender, EventArgs e)
        {

        }

        private void SaveChanges_ToolStrip2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Save Changes button is clicked");
            DataClass dataClass = new DataClass();

            dataClass.firstname = FirstName_textBox.Text;
            dataClass.lastname = LastName_textBox.Text;
            dataClass.street = Street_textBox.Text;
            dataClass.city = City_textBox.Text;
            dataClass.state = State_comboBox.Text;
            dataClass.zipcode = ZipCode_textBox.Text;
            dataClass.email = Email_textBox.Text;
            dataClass.cell = Cell_textBox.Text;
            dataClass.twitter = Twitter_textBox.Text;
            dataClass.ig = IG_textBox.Text;
            dataClass.fb = FB_textBox.Text;

            dataClass.writeDataStream();
        }

        private void Close_ToolStrip2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_ToolStrip2_Click(object sender, EventArgs e)
        {

        }

        private void SwitchToVeiwMode_ToolStrip2_Click(object sender, EventArgs e)
        {
            ContactForm_panel.Enabled = false;
        }

        private void SwitchToModifyMode_ToolStrip2_Click(object sender, EventArgs e)
        {
            ContactForm_panel.Enabled = true;
        }

        private void Help_ToolStrip2_Click(object sender, EventArgs e)
        {

        }

        private void About_ToolStrip2_Click(object sender, EventArgs e)
        {

        }

        private void ContactForm_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FirstName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Street_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void City_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void State_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ZipCode_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cell_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Twitter_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IG_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FB_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
