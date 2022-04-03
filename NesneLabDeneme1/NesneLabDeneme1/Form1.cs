using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneLabDeneme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusername.Text=="admin" &&  txtpassword.Text=="admin" )
            {
                new Form2().Show();
            }
            if (txtusername.Text == "user" && txtpassword.Text == "user")
            {
                new Form2().Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                new Form2().Show();
            }
            if (txtusername.Text == "user" && txtpassword.Text == "user")
            {
                new Form2().Show();
            }
        }
    }
}
