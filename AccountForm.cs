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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            if (AccountForm_panel.Enabled == false)
            {
                SaveChanges_ToolStrip.Enabled = false;
            }
            else
            {
                SaveChanges_ToolStrip.Enabled = true;
            }

        }
        public void disableAccountForm_panel()
        {
            AccountForm_panel.Enabled = false;
            SaveChanges_ToolStrip.Enabled = false;
        }
        public void enableAccountForm_panel()
        {
            AccountForm_panel.Enabled = true;
            SaveChanges_ToolStrip.Enabled = true;
        }
        /*
        public void open()
        {
            DataClass dataClass = new DataClass();
            dataClass.readDataStream();

            Username_textBox.Text = dataClass.username;
            Password_textBox.Text = dataClass.password;
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
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddressInfo_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SwitchToViewMode_ToolStrip_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked on Switch to veiw mode");
            AccountForm_panel.Enabled= false;
            SaveChanges_ToolStrip.Enabled= false;
        }

        private void SwitchToModifyMode_ToolStrip_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked on Switch to modify mode");
            AccountForm_panel.Enabled = true;
            SaveChanges_ToolStrip.Enabled = true;


        }

        private void SaveChanges_ToolStrip_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Save Changes button is clicked");
            DataClass dataClass = new DataClass();

            dataClass.username = Username_textBox.Text;
            dataClass.password=Password_textBox.Text;
            dataClass.firstname=FirstName_textBox.Text;
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

        private void Close_ToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
            //MessageBox.Show("Close button was clicked");
        }

        private void About_ToolStrip_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("About button was clicked");
        }

        private void AccountForm_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void File_ToolStrip_Click(object sender, EventArgs e)
        {

        }

        
    }
}
