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
using System.Xml.Linq;
using System.Security.Cryptography;

namespace NesneLabDeneme1
{
    public partial class Form1 : Form
    {
        public string FromXML_user = "";
        public string FromXML_password = "";

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
            string user = txtusername.Text;
            string pws = txtpassword.Text;

            //XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\kayıtlar.xml");
            //var selected_user = from x in doc.Descendants("uyeler").Where
            //                    (x => (string)x.Element("uye") == txtusername.Text)
            //                    select new
            //                    {
            //                        XMLuser = x.Element("username").Value,
            //                        XMLpassword = x.Element("password").Value,
            //                        XMLphone = x.Element("phone").Value,
            //                        XMLcity = x.Element("city").Value,
            //                        XMLadress = x.Element("adress").Value,
            //                        XMLmail = x.Element("e-mail").Value,
            //                        XMLname = x.Element("name-surname").Value,
            //                    };
            //foreach (var x in selected_user)
            //{
            //    FromXML_user = x.XMLuser;
            //    FromXML_password = x.XMLpassword;
            //}
            XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load("kayıtlar.xml");

            foreach (XmlNode node in xmldoc.DocumentElement)
            {
                if (node["username"].InnerText == user)
                {
                    SHA256Managed sha256 = new SHA256Managed();
                    byte[] bitDizisi = System.Text.Encoding.UTF8.GetBytes(pws);

                    string sifreliVeri = Convert.ToBase64String(sha256.ComputeHash(bitDizisi));
                    if (node["password"].InnerText == sifreliVeri)
                    {
                        FileStream fw;
                        StreamWriter sw;
                        fw = new FileStream("username.txt", FileMode.OpenOrCreate, FileAccess.Write);

                        sw = new StreamWriter(fw);
                        sw.WriteLine(txtusername.Text);
                        sw.Close();
                        fw.Close();
                        txtpassword.Clear();
                        new Form2().Show();
                    }
                    else
                    {
                        lbluyarı.Text = "Wrong password!";
                        txtpassword.Clear();
                    }
                }
            }   
                


            //if (user == FromXML_user)
            //{
            //    if (pws == FromXML_password)
            //    {
            //        FileStream fw;
            //        StreamWriter sw;
            //        fw = new FileStream("username.txt", FileMode.OpenOrCreate, FileAccess.Write);

            //        sw = new StreamWriter(fw);
            //        sw.WriteLine(txtusername.Text);
            //        sw.Close();
            //        fw.Close();

            //        new Form2().Show();
                    
            //    }
            //    else
            //    {
            //        lbluyarı.Text = "Wrong password!";
            //        txtpassword.Clear();
            //    }
            //}
            //if(txtusername.Text=="admin" && txtpassword.Text == "admin")
            //{
            //    Form4 f4 = new Form4();
            //    this.Hide();
            //    f4.Show();
            //}
            //else
            //{
            //    XmlDocument xmldoc = new XmlDocument();
            //    xmldoc.Load("kayıtlar.xml");

            //    foreach (XmlNode node in xmldoc.DocumentElement)
            //    {
            //        if (node["username"].InnerText == txtusername.Text && node["password"].InnerText == txtpassword.Text)
            //        {
            //            Form2 f2 = new Form2();
            //            f2.Show();
            //            this.Hide();
            //        }
            //    }

            //}



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("username.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();

            sw.Close();
            fs.Close();
            txtusername.Text = yazi;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1_Click(sender, e);
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
            
            f3.Show();
        }
    }
}
