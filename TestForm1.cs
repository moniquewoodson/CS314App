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
    public partial class TestForm1 : Form
    {
        public TestForm1()
        {
            InitializeComponent();
        }

        private void TestB10_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewAccount_LNK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          MessageBox.Show("CreateNewAccount_LNK");
        }

        private void TestForm1_Load(object sender, EventArgs e)
        {

        }
    }
}


