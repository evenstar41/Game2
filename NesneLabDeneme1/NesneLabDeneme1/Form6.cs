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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        static int Satir = Form2.satir;
        static int Sutun = Form2.sutun;
        int Yu = Form2.yu;
        int Yk = Form2.yk;
        int Yd = Form2.yd;
        int Su = Form2.su;
        int Sk = Form2.sk;
        int Sd = Form2.sd;
        int Ku = Form2.ku;
        int Kd = Form2.kd;
        int Kk = Form2.kk;
        Button[,] button = new Button[Satir, Sutun];


        private void Form6_Load(object sender, EventArgs e)
        {
            int satir = Form2.satir;
            int sutun = Form2.sutun;
            int Yu = Form2.yu;
            int Yk=Form2.yk;
            int Yd=Form2.yd;
            int Su=Form2.su;
            int Sk=Form2.sk;
            int Sd=Form2.sd;
            int Ku=Form2.ku;
            int Kd=Form2.kd;
            int Kk=Form2.kk;


            
            int top = 55;
            int left = 0;
            
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 50;
                    button[i, j].Height = 50;
                    button[i, j].Left = left;
                    button[i, j].Top = top;
                    ///
                    
                    button[i, j].Name = i.ToString();
                    
                
                    
                    ///
                    this.Controls.Add(button[i, j]);
                    left += 50;

                    button[i, j].BackColor = Color.White;
                    //button[i, j].Enabled = false;


                }
            
                top += 50;
                left = 0;
            }
            int Satir;
            int Sutun;
            Random rastgele = new Random();
            
            for (int x = 0; x < 3; x++)///random şekil ekleme
            {
                    //hangi butona şekil atanacak
                    
                    Satir = rastgele.Next(satir);
                    Sutun = rastgele.Next(sutun);

                    //hangi şekil atanacak
                    
                    int sekil = rastgele.Next(9);
                    if (sekil == 0 )
                    {
                    if (Ku == 1)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"kırmızıUcgen.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        button[Satir, Sutun].BackColor = Color.Black;
                        continue;
                    }
                    else
                        x--;                        

                    }
                    else if (sekil == 1 )
                    {

                    if (Su == 1)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"sarıUcgen.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        button[Satir, Sutun].BackColor = Color.Black;
                    }
                    else
                        x--;
                        
                    
                    }
                    else if (sekil == 2 )
                    {
                    if ( Yu == 1)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"yesilUcgen.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        button[Satir, Sutun].BackColor = Color.Black;
                    }
                    else
                    {
                        x--;
                    }
                    }
                    else if (sekil == 3 )
                    {
                    if (Kd == 1)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"kırmızıDaire.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        button[Satir, Sutun].BackColor = Color.Black;
                    }
                    else
                        x--;
                    }
                    else if (sekil == 4 )
                    {
                    if (Sd == 1)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"sarıDaire.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        button[Satir, Sutun].BackColor = Color.Black;
                    }
                    else
                        x--;
                    }
                    else if (sekil == 5 )
                    {
                    if (Yd == 1)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"yesilDaire.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        button[Satir, Sutun].BackColor = Color.Black;
                    }
                    else
                        x--;
                    }
                    else if (sekil == 6 )
                    {
                    if ( Kk == 1)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"kırmızıKare.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        button[Satir, Sutun].BackColor = Color.Black;
                    }
                    else
                        x--;
                    }
                    else if (sekil == 7 )
                    {
                    if (Sk == 1)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"sarıKare.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        button[Satir, Sutun].BackColor = Color.Black;
                    }
                    else
                        x--;
                    }
                    else if (sekil == 8 )
                    {
                    if (Yk == 1)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"yesilKare.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        button[Satir, Sutun].BackColor = Color.Black;
                    }
                    else
                        x--;
                    }
                    sekil = 0;
            }


          
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int satir = Form2.satir;
            int sutun = Form2.sutun;
            Random rastgele = new Random();

            for (int x = 0; x < 3; x++)///random şekil ekleme
            {
                //hangi butona şekil atanacak

                Satir = rastgele.Next(satir);
                Sutun = rastgele.Next(sutun);
                if (button[Satir, Sutun].BackColor != Color.White)
                {
                    x--;
                    continue;
                }
                else
                {
                    //hangi şekil atanacak


                    int sekil = rastgele.Next(9);
                    if (sekil == 0)
                    {
                        if (Ku == 1)
                        {
                            button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"kırmızıUcgen.png");
                            button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                            button[Satir, Sutun].BackColor = Color.Black;
                            continue;
                        }
                        else
                            x--;

                    }
                    else if (sekil == 1)
                    {

                        if (Su == 1)
                        {
                            button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"sarıUcgen.png");
                            button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                            button[Satir, Sutun].BackColor = Color.Black;
                        }
                        else
                            x--;


                    }
                    else if (sekil == 2)
                    {
                        if (Yu == 1)
                        {
                            button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"yesilUcgen.png");
                            button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                            button[Satir, Sutun].BackColor = Color.Black;
                        }
                        else
                        {
                            x--;
                        }
                    }
                    else if (sekil == 3)
                    {
                        if (Kd == 1)
                        {
                            button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"kırmızıDaire.png");
                            button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                            button[Satir, Sutun].BackColor = Color.Black;
                        }
                        else
                            x--;
                    }
                    else if (sekil == 4)
                    {
                        if (Sd == 1)
                        {
                            button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"sarıDaire.png");
                            button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                            button[Satir, Sutun].BackColor = Color.Black;
                        }
                        else
                            x--;
                    }
                    else if (sekil == 5)
                    {
                        if (Yd == 1)
                        {
                            button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"yesilDaire.png");
                            button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                            button[Satir, Sutun].BackColor = Color.Black;
                        }
                        else
                            x--;
                    }
                    else if (sekil == 6)
                    {
                        if (Kk == 1)
                        {
                            button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"kırmızıKare.png");
                            button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                            button[Satir, Sutun].BackColor = Color.Black;
                        }
                        else
                            x--;
                    }
                    else if (sekil == 7)
                    {
                        if (Sk == 1)
                        {
                            button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"sarıKare.png");
                            button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                            button[Satir, Sutun].BackColor = Color.Black;
                        }
                        else
                            x--;
                    }
                    else if (sekil == 8)
                    {
                        if (Yk == 1)
                        {
                            button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"yesilKare.png");
                            button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                            button[Satir, Sutun].BackColor = Color.Black;
                        }
                        else
                            x--;
                    }
                    sekil = 0;
                }
                
            }

        }
    }
}
