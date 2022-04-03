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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
