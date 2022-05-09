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
        
        public Form6()
        {
            InitializeComponent();
        }
        private void random_start()
        {

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
                    
                    sayı1 = random.Next(8);
                    sayı2 = random.Next(8);
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
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            
            if (clickTemp == false &&btn.BackColor !=Color.AliceBlue)
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


            
            

            
        }
        


        private void Form6_Load(object sender, EventArgs e)
        {
            ////////////////////tablo yapımı 
            //Form2 f2 = new Form2();
            //int sayı = f2.sayı;
            //Button[,] button0 = new Button[8, 8];


            //int top = 0;
            //int left = 0;
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {

            //        Button button = new Button();
            //        button.Size = new Size(60, 60);
            //        button.Location = new Point(60 * i, 60 * j);
            //        button.Click += Button_Click;
            //        panel1.Controls.Add(button);
            //    }
            //}
            int horizotal = 0;
            int vertical = 40;
            Button[,] buttonArray = new Button[8,8];
            buttonarraytemp = buttonArray;

            for (int i = 0; i < 8; i++)
            {
                for (int y = 0; y < 8; y++)
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
            int rand_yellow = random_yellow.Next(8);

            
            int rand_yellowy = random_yellow.Next(8);

            int rand_yellow_s = random_yellow.Next(3);

            buttonArray[rand_yellow, rand_yellowy].BackColor = Color.Yellow;
            buttonArray[rand_yellow, rand_yellowy].Text = sekiller[rand_yellow_s];

            sekiller.RemoveAt(rand_yellow_s);
            ////////
            int rand_green = random_yellow.Next(8);

            int rand_greeny = random_yellow.Next(8);

            int rand_green_s = random_yellow.Next(2);

            buttonArray[rand_green, rand_greeny].BackColor = Color.Green;
            buttonArray[rand_green, rand_greeny].Text = sekiller[rand_green_s];

            /////
            int rand_red = random_yellow.Next(8);

            int rand_redy = random_yellow.Next(8);

            int rand_red_s = random_yellow.Next(1);

            buttonArray[rand_red, rand_redy].BackColor = Color.Red;
            buttonArray[rand_red, rand_redy].Text = sekiller[rand_red_s];






        }
    }
}
