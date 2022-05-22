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
        public static int sayı;
        public static int satir;
        public static int sutun;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "easy")
            {
                satir = 15;
                sutun = 15;
            }
            if (comboBox1.Text == "normal")
            {
                satir = 9;
                sutun = 9;
            }
            if (comboBox1.Text == "hard")
            {
                satir = 5;
                sutun = 5;
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
           
            if (chkCustom.Checked == true)
            {                
                if (txtsatir.Text=="")
                {
                    MessageBox.Show("Lütfen satır ve sütunu yazınız!");
                }
                else satir = int.Parse(txtsatir.Text);

                if (txtsutun.Text=="")
                {
                    MessageBox.Show("Lütfen satır ve sütunu yazınız!");
                }
                else
                {
                    sutun = int.Parse(txtsutun.Text);
                }

                if (satir < 20 && sutun < 20)
                {
                    if (satir>=6 && sutun>=6)
                    {
                        Form6 f6 = new Form6();
                        f6.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Satır veya sütun sayısı 6'dan az olamaz!");

                }
                else
                {
                    MessageBox.Show("Satır veya sütun sayısı 20'den fazla olamaz!");

                }
                //if (satir < 6 || sutun < 6)
                //{
                //    MessageBox.Show("Satır veya sütun sayısı 6'dan az olamaz!");
                //}
            }
            if (chkCustom.Checked == false)
            {
                if (comboBox1.Text == "easy")
                {
                    satir = 15;
                    sutun = 15;
                }
                if (comboBox1.Text == "normal")
                {
                    satir = 9;
                    sutun = 9;
                }
                if (comboBox1.Text == "hard")
                {
                    satir = 5;
                    sutun = 5;
                }
                Form6 f6 = new Form6();
                f6.ShowDialog();
                this.Close();
            }
            
            
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f3 = new Form7();

            f3.ShowDialog();
        }

        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustom.Checked == true)
            {
                panel1.Enabled = true;
                comboBox1.Enabled = false;
                //satir = int.Parse(txtsatir.Text);
                //sutun = int.Parse(txtsutun.Text);
            }
            if (chkCustom.Checked == false)
            {
                panel1.Enabled = false;
                comboBox1.Enabled = true;
            }
        }

        private void txtsatir_TextChanged(object sender, EventArgs e)
        {
            
            //satir = int.Parse(txtsatir.Text);
        }

        private void txtsutun_TextChanged(object sender, EventArgs e)
        {
            //sutun = int.Parse(txtsutun.Text);
        }

        private void txtsatir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtsutun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
