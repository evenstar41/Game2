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

namespace NesneLabDeneme1
{
    public partial class Form6 : Form
    {
        private bool clickTemp = false;
        private Color color;
        private string shape;
        private Button buttontemp;
        private Button[,] buttonarraytemp;
        int sayı = Form2.sayı;
        int flag = 0;
        int flag1 = 0;
        int x_kordinat = 0;
        int y_kordinat = 0;
        public Form6()
        {
            flag = (sayı * sayı);
            InitializeComponent();
            
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
                    
                    sayı1 = random.Next(sayı);
                    sayı2 = random.Next(sayı);
                } while (buton[sayı1,sayı2].Text !="");
                int sayı3 = random.Next(3 - i);
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
                if (i == 2)
                {
                    buton[sayı1, sayı2].BackColor = Color.Yellow;
                    buton[sayı1, sayı2].Text = sekil[sayı3];
                }
            }
        }
        
        int x = 0;
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            x += 1 ;
            if (x<2*flag/3)
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
                    ucekle(buttonarraytemp);


                }
                for (int i = 0; i < sayı; i++)
                {
                    for (int j = 0; j < sayı - 5; j++)
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
                            this.Hide();
                            MessageBox.Show("Tebrikler kazandınız.");
                        }
                        flag1 = 0;
                    }
                }




            }
            
            
            else
            {
                this.Close();
                MessageBox.Show("Üzgünüm kaybettiniz.");
            }
            







        }
        


        private void Form6_Load(object sender, EventArgs e)
        {
            
            int horizotal = 0;
            int vertical = 40;
            Button[,] buttonArray = new Button[sayı,sayı];
            buttonarraytemp = buttonArray;

            for (int i = 0; i < sayı; i++)
            {
                for (int y = 0; y < sayı; y++)
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



            /////////////

            Random random_yellow = new Random();
            int rand_yellow = random_yellow.Next(sayı);

            
            int rand_yellowy = random_yellow.Next(sayı);

            int rand_yellow_s = random_yellow.Next(3);

            buttonArray[rand_yellow, rand_yellowy].BackColor = Color.Yellow;
            buttonArray[rand_yellow, rand_yellowy].Text = sekiller[rand_yellow_s];

            sekiller.RemoveAt(rand_yellow_s);
            ////////
            int rand_green = random_yellow.Next(sayı);

            int rand_greeny = random_yellow.Next(sayı);

            int rand_green_s = random_yellow.Next(2);

            buttonArray[rand_green, rand_greeny].BackColor = Color.Green;
            buttonArray[rand_green, rand_greeny].Text = sekiller[rand_green_s];

            /////
            int rand_red = random_yellow.Next(sayı);

            int rand_redy = random_yellow.Next(sayı);

            int rand_red_s = random_yellow.Next(1);

            buttonArray[rand_red, rand_redy].BackColor = Color.Red;
            buttonArray[rand_red, rand_redy].Text = sekiller[rand_red_s];

            
            



        }
    }
}
