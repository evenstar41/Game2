using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace NesneLabDeneme1
{
    public partial class Form6 : Form
    {
        private bool clickTemp = false;
        private Color color;
        private string shape;
        private Button buttontemp;
        private Button[,] buttonarraytemp;
        private Button[,] kral;

        static int satir = Form2.satir;
        static int sutun = Form2.sutun;
        int flag = (satir * sutun);
        int flag1 = 0;
        int x_kordinat = 0;
        int y_kordinat = 0;
        int puan;
        public Form6()
        {
            
            InitializeComponent();
            
        }
        private void ikiekle(Button[,] buton)
        {
            List<string> sekil = new List<string> { "▲", "○", "▀" };
            for (int i = 0; i < 2; i++)
            {
                int sayı1;
                int sayı2;
                Random random = new Random();
                do
                {

                    sayı1 = random.Next(satir);
                    sayı2 = random.Next(sutun);
                } while (buton[sayı1, sayı2].Text != "");
                int sayı3 = random.Next(2 - i);
                if (i == 0)
                {
                    buton[sayı1, sayı2].BackColor = Color.Red;
                    buton[sayı1, sayı2].Text = sekil[sayı3];
                    sekil.RemoveAt(sayı3);
                }
                if (i == 1)
                {
                    buton[sayı1, sayı2].BackColor = Color.Green;
                    buton[sayı1, sayı2].Text = sekil[sayı3];
                    sekil.RemoveAt(sayı3);
                }
          
            }
        }

        private void birekle(Button[,] buton)
        {
            List<string> sekil = new List<string> { "▲", "○", "▀" };

            int sayı1;
            int sayı2;
            Random random = new Random();
            do
            {

                sayı1 = random.Next(satir);
                sayı2 = random.Next(sutun);
            } while (buton[sayı1, sayı2].Text != "");

            int sayı3 = random.Next(3);
            if (sayı3==0)
            {
                color = Color.Red;
            }
            if (sayı3 == 1)
            {
                color = Color.Green;
            }
            if (sayı3 == 2)
            {
                color = Color.Yellow;
            }
            buton[sayı1, sayı2].BackColor = Color.Red;
            buton[sayı1, sayı2].Text = sekil[sayı3];
            sekil.RemoveAt(sayı3);

        }

        private void ucekle(Button[,] buton)
        {

            List<string> sekil=new List<string> { "▲", "○", "▀" };
            for (int i = 0; i < 3; i++)
            {
                int sayı1;
                int sayı2;
                Random random = new Random();
                do
                {
                    
                    sayı1 = random.Next(satir);
                    sayı2 = random.Next(sutun);
                } while (buton[sayı1,sayı2].Text !="");
                int sayı3 = random.Next(3 - i);
                if (i == 0)
                {
                    buton[sayı1, sayı2].BackColor = Color.Red;
                    buton[sayı1, sayı2].Text = sekil[sayı3];
                    kral = buton;

                    sekil.RemoveAt(sayı3);
                }
                if (i == 1)
                {
                    buton[sayı1, sayı2].BackColor = Color.Green;
                    buton[sayı1, sayı2].Text = sekil[sayı3];
                    kral = buton;
                    sekil.RemoveAt(sayı3);
                }
                if (i == 2)
                {
                    buton[sayı1, sayı2].BackColor = Color.Yellow;
                    buton[sayı1, sayı2].Text = sekil[sayı3];
                    kral = buton;

                }
            }
            
        }
        
        int x = 3;
        private void Button_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            buttonarraytemp = kral;
            
            if (x<flag)
            {
                if (flag-1==x)
                {
                    if (clickTemp == false && btn.BackColor != Color.AliceBlue)
                    {
                        color = btn.BackColor;
                        shape = btn.Text;
                        buttontemp = btn;


                        clickTemp = true;

                    }
                    if (clickTemp == true && btn.BackColor == Color.AliceBlue)
                    {
                        btn.BackColor = color;
                        btn.Text = shape;
                        buttontemp.BackColor = Color.AliceBlue;
                        buttontemp.Text = "";
                        clickTemp = false;
                        SoundPlayer music = new SoundPlayer(@"1.wav");
                        music.Play();
                        birekle(buttonarraytemp);
                        x += 1;

                    }
                    for (int i = 0; i < satir; i++)
                    {
                        for (int j = 0; j < sutun - 5; j++)
                        {
                            if (buttonarraytemp[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (buttonarraytemp[i, j].Text == buttonarraytemp[i, j + a].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i, j + a].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;

                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                warband.Play();
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {

                                    buttonarraytemp[i, j + a].Text = "";
                                    buttonarraytemp[i, j + a].BackColor = Color.AliceBlue;




                                }
                                x -= 5;

                            }
                            flag1 = 0;
                        }
                    }
                    for (int i = 0; i < satir - 5; i++)
                    {
                        for (int j = 0; j < sutun; j++)
                        {
                            if (buttonarraytemp[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {

                                    if (buttonarraytemp[i, j].Text == buttonarraytemp[i + a, j].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i + a, j].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;

                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    buttonarraytemp[i + a, j].Text = "";
                                    buttonarraytemp[i + a, j].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    label2.Text = puan.ToString();

                }
            
                if (flag - 2 == x)
                {
                    if (clickTemp == false && btn.BackColor != Color.AliceBlue)
                    {
                        color = btn.BackColor;
                        shape = btn.Text;
                        buttontemp = btn;
                        clickTemp = true;

                    }
                    if (clickTemp == true && btn.BackColor == Color.AliceBlue)
                    {
                        btn.BackColor = color;
                        btn.Text = shape;
                        buttontemp.BackColor = Color.AliceBlue;
                        buttontemp.Text = "";
                        clickTemp = false;
                        SoundPlayer music = new SoundPlayer(@"1.wav");
                        music.Play();
                        ikiekle(buttonarraytemp);
                        x += 2;

                    }
                    for (int i = 0; i < satir; i++)
                    {
                        for (int j = 0; j < sutun - 5; j++)
                        {
                            if (buttonarraytemp[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (buttonarraytemp[i, j].Text == buttonarraytemp[i, j + a].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i, j + a].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;
                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                warband.Play();
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    buttonarraytemp[i, j + a].Text = "";
                                    buttonarraytemp[i, j + a].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    for (int i = 0; i < satir - 5; i++)
                    {
                        for (int j = 0; j < sutun; j++)
                        {
                            if (buttonarraytemp[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (buttonarraytemp[i, j].Text == buttonarraytemp[i + a, j].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i + a, j].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;
                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    buttonarraytemp[i + a, j].Text = "";
                                    buttonarraytemp[i + a, j].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    label2.Text = puan.ToString();

                }
                else
                {
                    if (clickTemp == false && btn.BackColor != Color.AliceBlue)
                    {
                        color = btn.BackColor;
                        shape = btn.Text;
                        buttontemp = btn;
                        clickTemp = true;
                    }
                    if (clickTemp == true && btn.BackColor == Color.AliceBlue)
                    {
                        btn.BackColor = color;
                        btn.Text = shape;
                        buttontemp.BackColor = Color.AliceBlue;
                        buttontemp.Text = "";
                        clickTemp = false;
                        SoundPlayer music = new SoundPlayer(@"1.wav");
                        music.Play();
                        ucekle(kral);
                        x += 3;
                    }
                    for (int i = 0; i < satir; i++)
                    {
                        for (int j = 0; j < sutun - 5; j++)
                        {
                            if (kral[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (kral[i, j].Text == kral[i, j + a].Text && kral[i, j].BackColor == kral[i, j + a].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;
                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                warband.Play();
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    kral[i, j + a].Text = "";
                                    kral[i, j + a].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    for (int i = 0; i < satir - 5; i++)
                    {
                        for (int j = 0; j < sutun; j++)
                        {
                            if (kral[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (kral[i, j].Text == kral[i + a, j].Text && kral[i, j].BackColor == kral[i + a, j].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;
                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                warband.Play();
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    kral[i + a, j].Text = "";
                                    kral[i + a, j].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    label2.Text = puan.ToString();
                }
            }
            else
            {
                string point = puan.ToString();
                this.Hide();
                MessageBox.Show("Oyun bitti puanınız: "+point);
                new Form2().Show();
            }
        }
 
        private void Form6_Load(object sender, EventArgs e)
        {
            
            int horizotal = 0;
            int vertical = 40;
            Button[,] buttonArray = new Button[satir,sutun];
            buttonarraytemp = buttonArray;

            for (int i = 0; i < satir; i++)
            {
                for (int y = 0; y < sutun; y++)
                {
                    buttonArray[i,y] = new Button();
                    buttonArray[i,y].Size = new Size(40, 40);
                    buttonArray[i,y].Location = new Point(horizotal, vertical);
                    buttonArray[i,y].BackColor = Color.AliceBlue;
                    buttonArray[i, y].Click += Button_Click; // click event yükle

                    
                    horizotal += 40;
                    this.Controls.Add(buttonArray[i,y]);
                }
                vertical += 40;
                horizotal = 0;
            }
            /////////şekil renk ekleme

            List<string> sekiller = new List<string> { "▲", "○", "▀" };
            List<string> sekil = new List<string> { "▲", "○", "▀" };
            for (int i = 0; i < 3; i++)
            {
                int sayı1;
                int sayı2;
                Random random = new Random();
                do
                {

                    sayı1 = random.Next(satir);
                    sayı2 = random.Next(sutun);
                } while (buttonarraytemp[sayı1, sayı2].Text != "");
                int sayı3 = random.Next(3 - i);
                if (i == 0)
                {
                    buttonarraytemp[sayı1, sayı2].BackColor = Color.Red;
                    buttonarraytemp[sayı1, sayı2].Text = sekil[sayı3];
                    kral = buttonarraytemp;

                    sekil.RemoveAt(sayı3);
                }
                if (i == 1)
                {
                    buttonarraytemp[sayı1, sayı2].BackColor = Color.Green;
                    buttonarraytemp[sayı1, sayı2].Text = sekil[sayı3];
                    kral = buttonarraytemp;
                    sekil.RemoveAt(sayı3);
                }
                if (i == 2)
                {
                    buttonarraytemp[sayı1, sayı2].BackColor = Color.Yellow;
                    buttonarraytemp[sayı1, sayı2].Text = sekil[sayı3];
                    kral = buttonarraytemp;

                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
