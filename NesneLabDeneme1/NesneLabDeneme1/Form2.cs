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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int sayı;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "hard")
            {
                sayı = 15;
            }
            if (comboBox1.Text == "medium")
            {
                sayı = 9;
            }
            if (comboBox1.Text == "easy")
            {
                sayı = 5;
            }

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("kayıtlar.xml");
            foreach(XmlNode node in xmldoc.DocumentElement)
            {
                if (node["username"].InnerText == label4.Text)
                {
                    node["difficulties"].InnerText = comboBox1.Text;
                    node["shape"].InnerText = label5.Text;
                    node["color"].InnerText = label5.Text;
                    if (checkBox1.Checked)
                    {
                        node["shape"].InnerText += "triangle,";
                    }
                    if (checkBox2.Checked)
                    {
                        node["shape"].InnerText += "square,";
                    }
                    if (checkBox3.Checked)
                    {
                        node["shape"].InnerText += "circle";
                    }
                    if (chkboxRed.Checked)
                    {
                        node["color"].InnerText += "red,";
                    }
                    if (chkboxGreen.Checked)
                    {
                        node["color"].InnerText += "green,";
                    }
                    if (chkboxYellow.Checked)
                    {
                        node["color"].InnerText += "yellow";
                    }
                }
            }
            xmldoc.Save("kayıtlar.xml");
            
            //FileStream fw;
            //StreamWriter sw;
            //fw = new FileStream("nesnelabbb.txt", FileMode.OpenOrCreate, FileAccess.Write);

            //sw = new StreamWriter(fw);

            //sw.WriteLine(comboBox1.Text);


            //if (checkBox1.Checked)
            //{
            //    sw.WriteLine(checkBox1.Text);

            //}
            //if (checkBox2.Checked)
            //{
            //    sw.WriteLine(checkBox2.Text);

            //}
            //if (checkBox3.Checked)
            //{
            //    sw.WriteLine(checkBox3.Text);

            //}
            //if (chkboxRed.Checked)
            //{
            //    sw.WriteLine(chkboxRed.Text);

            //}
            //if (chkboxYellow.Checked)
            //{
            //    sw.WriteLine(chkboxYellow.Text);

            //}
            //if (chkboxGreen.Checked)
            //{
            //    sw.WriteLine(chkboxGreen.Text);

            //}


            //sw.Close();
            //fw.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //admin sayfası girişi izni

            label4.Text = Form1.giden;
            label4.Visible = false;


            FileStream fs = new FileStream("username.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();

            sw.Close();
            fs.Close();
            try
            {
 

                if (yazi == "admin")
                {
                    admingirisi.Visible = true;
                }
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load("kayıtlar.xml");

                foreach(XmlNode node in xmldoc.DocumentElement)
                {
                    if (node["username"].InnerText == label4.Text)
                    {
                        comboBox1.Text = node["difficulties"].InnerText;

                        string[] shape = node["shape"].InnerText.Split(',');
                        foreach (string index in shape)
                        {
                            if (index == "triangle")
                            {
                                checkBox1.Checked = true;
                            }
                            if (index == "square")
                            {
                                checkBox2.Checked = true;
                            }
                            if (index == "circle")
                            {
                                checkBox3.Checked = true;
                            }

                        }
                        string[] color = node["color"].InnerText.Split(',');
                        foreach(String renk in color)
                        {
                            if (renk == "red")
                            {
                                chkboxRed.Checked = true;
                            }
                            if (renk == "yellow")
                            {
                                chkboxYellow.Checked = true;
                            }
                            if (renk == "green")
                            {
                                chkboxGreen.Checked = true;
                            }
                        }
                    }
                    

                    
                }
                //StreamReader sr = File.OpenText("nesnelabbb.txt");
                //string metin;


                //while ((metin = sr.ReadLine()) != null)
                //{
                //    comboBox1.Text = metin;
                //    break;
                //}
                //string metin2;

                //while ((metin2 = sr.ReadLine()) != null)
                //{
                //    if (metin2 == "Circle")
                //    {
                //        checkBox1.Checked = true;
                //    }
                //    if (metin2 == "Triangle")
                //    {
                //        checkBox3.Checked = true;
                //    }
                //    if (metin2 == "Square")
                //    {
                //        checkBox2.Checked = true;
                //    }
                //    if (metin2 == "Red")
                //    {
                //        chkboxRed.Checked = true;
                //    }
                //    if (metin2 == "Yellow")
                //    {
                //        chkboxYellow.Checked = true;
                //    }
                //    if (metin2 == "Green")
                //    {
                //        chkboxGreen.Checked = true;
                //    }
                //}
                //sr.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void admingirisi_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
        }
    }
}
