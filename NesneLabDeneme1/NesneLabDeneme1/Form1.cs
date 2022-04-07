using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

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
            if(txtusername.Text=="admin" && txtpassword.Text == "admin")
            {
                Form4 f4 = new Form4();
                this.Hide();
                f4.Show();
            }
            else
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load("kayıtlar.xml");

                foreach (XmlNode node in xmldoc.DocumentElement)
                {
                    if (node["username"].InnerText == txtusername.Text && node["password"].InnerText == txtpassword.Text)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                    }
                }

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
            
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGoster.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }
    }
}
