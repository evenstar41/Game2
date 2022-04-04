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
                FileStream fw;
                StreamWriter sw;
                fw = new FileStream("username.txt", FileMode.OpenOrCreate, FileAccess.Write);

                sw = new StreamWriter(fw);

                sw.WriteLine(txtusername.Text);
                fw.Close();

            }
            if (txtusername.Text == "user" && txtpassword.Text == "user")
            {
                new Form2().Show();
                FileStream fw;
                StreamWriter sw;
                fw = new FileStream("username.txt", FileMode.OpenOrCreate, FileAccess.Write);

                sw = new StreamWriter(fw);

                sw.WriteLine(txtusername.Text);
                fw.Close();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("username.txt");
            string username;
            while ((username = sr.ReadLine()) != null)
            {
                if (username == "admin")
                {
                    txtusername.Text = "admin";
                }
                else if (username == "user")
                {
                    txtusername.Text = "user";
                }
            }
            sr.Close();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                new Form2().Show();
                FileStream fw;
                StreamWriter sw;
                fw = new FileStream("username.txt", FileMode.OpenOrCreate, FileAccess.Write);

                sw = new StreamWriter(fw);

                sw.WriteLine(txtusername.Text);
                fw.Close();

            }
            if (txtusername.Text == "user" && txtpassword.Text == "user")
            {
                new Form2().Show();
                FileStream fw;
                StreamWriter sw;
                fw = new FileStream("username.txt", FileMode.OpenOrCreate, FileAccess.Write);

                sw = new StreamWriter(fw);

                sw.WriteLine(txtusername.Text);
                fw.Close();
            }
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
    }
}
