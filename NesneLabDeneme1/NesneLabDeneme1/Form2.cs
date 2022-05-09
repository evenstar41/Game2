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

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fw;
            StreamWriter sw;
            fw = new FileStream("nesnelabbb.txt", FileMode.OpenOrCreate, FileAccess.Write);

            sw = new StreamWriter(fw);

            sw.WriteLine(comboBox1.Text);


            if (checkBox1.Checked)
            {
                sw.WriteLine(checkBox1.Text);

            }
            if (checkBox2.Checked)
            {
                sw.WriteLine(checkBox2.Text);

            }
            if (checkBox3.Checked)
            {
                sw.WriteLine(checkBox3.Text);

            }
            if (chkboxRed.Checked)
            {
                sw.WriteLine(chkboxRed.Text);

            }
            if (chkboxYellow.Checked)
            {
                sw.WriteLine(chkboxYellow.Text);

            }
            if (chkboxGreen.Checked)
            {
                sw.WriteLine(chkboxGreen.Text);

            }


            sw.Close();
            fw.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //admin sayfası girişi izni
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

                StreamReader sr = File.OpenText("nesnelabbb.txt");
                string metin;


                while ((metin = sr.ReadLine()) != null)
                {
                    comboBox1.Text = metin;
                    break;
                }
                string metin2;

                while ((metin2 = sr.ReadLine()) != null)
                {
                    if (metin2 == "Circle")
                    {
                        checkBox1.Checked = true;
                    }
                    if (metin2 == "Triangle")
                    {
                        checkBox3.Checked = true;
                    }
                    if (metin2 == "Square")
                    {
                        checkBox2.Checked = true;
                    }
                    if (metin2 == "Red")
                    {
                        chkboxRed.Checked = true;
                    }
                    if (metin2 == "Yellow")
                    {
                        chkboxYellow.Checked = true;
                    }
                    if (metin2 == "Green")
                    {
                        chkboxGreen.Checked = true;
                    }
                }
                sr.Close();
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

        public static int satir;
        public static int sutun;
        public static int yu=0;
        public static int yk=0;
        public static int yd=0;
        public static int su=0;
        public static int sk=0;
        public static int sd=0;
        public static int ku=0;
        public static int kd=0;
        public static int kk=0;

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Enabled == true)
            {
                if (comboBox1.SelectedItem == "easy")
                {
                    lblBoyut.Text = "15x15";
                    satir = 15;
                    sutun = 15;
                }
                if (comboBox1.SelectedItem == "medium")
                {
                    lblBoyut.Text = "9x9";
                    satir = 9;
                    sutun = 9;
                }
                if (comboBox1.SelectedItem == "hard")
                {
                    satir = 5;
                    sutun = 5;
                    lblBoyut.Text = "5x5";
                }
                yu = 1;
                yk = 1;
                yd = 1;
                su = 1;
                sk = 1;
                sd = 1;
                ku = 1;
                kd = 1;
                kk = 1;
            }
            else if (comboBox1.Enabled==false)
            {
                yu = 0;
                yk = 0;
                yd = 0;
                su = 0;
                sk = 0;
                sd = 0;
                ku = 0;
                kd = 0;
                kk = 0;
            
            }
        }

        private void admingirisi_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().ShowDialog();
            
        }

        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
        //////Aynı anda iki oyun modu açılmaması için yapılmıştır.
            if (chkCustom.Checked==true)
            {
                
                comboBox1.Enabled = false;
                panel1.Enabled = true;
                   
                    
            }
            else if(chkCustom.Checked==false)
            {

                if (comboBox1.SelectedItem == "easy")
                {
                    lblBoyut.Text = "15x15";
                    satir = 15;
                    sutun = 15;
                }
                if (comboBox1.SelectedItem == "medium")
                {
                    lblBoyut.Text = "9x9";
                    satir = 9;
                    sutun = 9;
                }
                if (comboBox1.SelectedItem == "hard")
                {
                    satir = 5;
                    sutun = 5;
                    lblBoyut.Text = "5x5";
                }
                
                comboBox1.Enabled = true;
                panel1.Enabled = false;
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (chkCustom.Checked == true)
            {
                yu = 0;
                yk = 0;
                yd = 0;
                su = 0;
                sk = 0;
                sd = 0;
                ku = 0;
                kd = 0;
                kk = 0;

                int flag = 0;
                int flag1 = 0;
                if (chkboxRed.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        ku = 1;
                        flag1 += 1;
                    }
                    if (checkBox2.Checked)
                    {
                        kk = 1;
                        flag1 += 1;
                    }
                    if (checkBox3.Checked)
                    {
                        kd = 1;
                        flag1 += 1;
                    }
                    flag += 1;
                }
                if (chkboxYellow.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        su = 1;
                        flag1 += 1;
                    }
                    if (checkBox2.Checked)
                    {
                        sk = 1;
                        flag1 += 1;
                    }
                    if (checkBox3.Checked)
                    {
                        sd = 1;
                        flag1 += 1;
                    }
                    flag += 1;
                }
                if (chkboxGreen.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        yu = 1;
                        flag1 += 1;
                    }
                    if (checkBox2.Checked)
                    {
                        yk = 1;
                        flag1 += 1;
                    }
                    if (checkBox3.Checked)
                    {
                        yd = 1;
                        flag1 += 1;
                    }
                    flag += 1;
                }

                if (flag + flag1 <= 3)
                {
                    MessageBox.Show("En az 3 seçenek seçmelisiniz!!");
                }
                else
                {
                    if (textBox1.Text == "" && textBox2.Text == "")
                    {
                        MessageBox.Show("Satır ve sütun sayılarını yazınız!!");
                    }
                    else
                    {
                        satir = int.Parse(textBox1.Text);
                        sutun = int.Parse(textBox2.Text);
                        new Form6().ShowDialog();
                    }
                }
            }
            else if (chkCustom.Checked == false)
            {
                new Form6().ShowDialog();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //satir = int.Parse(textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            //sutun = int.Parse(textBox2.Text);

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
