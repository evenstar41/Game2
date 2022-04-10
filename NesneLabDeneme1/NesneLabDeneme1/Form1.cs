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
                    if (node["password"].InnerText == pws)
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
                else
                {
                    lbluyarı.Text = "Wrong password!";
                    txtpassword.Clear();
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
            try
            {
                FileStream fs = new FileStream("username.txt",FileMode.OpenOrCreate);
                StreamReader sw = new StreamReader(fs);
                string yazi = sw.ReadLine();

                sw.Close();
                fs.Close();
                txtusername.Text = yazi;
            }
            catch(Exception)
            {
                
            }
            try
            {
                XDocument xdosya1 = XDocument.Load("kayıtlar.xml");
            }
            catch (Exception)
            {
                XmlTextWriter dosya = new XmlTextWriter("kayıtlar.xml", Encoding.UTF8);
                dosya.Formatting = Formatting.Indented;
                dosya.WriteStartElement("uyeler");

                dosya.WriteEndElement();

                dosya.Close();

                XDocument xdosya1 = XDocument.Load("kayıtlar.xml");
                XElement rootelement1 = xdosya1.Root;

                XElement element1 = new XElement("uye");

                XElement name_surname1 = new XElement("name-surname", "admin");
                XElement username1 = new XElement("username", "admin");
                XElement password1 = new XElement("password", "admin");
                XElement phone1 = new XElement("phone", "admin");
                XElement city1 = new XElement("city", "admin");
                XElement adress1 = new XElement("adress", "admin");
                XElement e_mail1 = new XElement("e-mail", "admin");
                XElement country1 = new XElement("country", "admin");
                element1.Add(name_surname1, username1, password1, phone1, city1, adress1, e_mail1, country1);
                rootelement1.Add(element1);

                xdosya1.Save("kayıtlar.xml");
            }
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
            this.Close();
            
            f3.Show();
        }
    }
}
