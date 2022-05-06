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
        


        private void Form6_Load(object sender, EventArgs e)
        {
            int satir = Form2.satir;
            int sutun = Form2.sutun;

            Button[,] button = new Button[satir, sutun];
            int top = 0;
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
                    this.Controls.Add(button[i, j]);
                    left += 50;

                    button[i, j].BackColor = Color.White;



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
                    if (sekil == 0)
                    {

                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"kırmızıUcgen.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        continue;

                    }
                    else if (sekil == 1)
                    {
                        
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"sarıUcgen.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                        continue;
                    }
                    else if (sekil == 2)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"yesilUcgen.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                    continue;
                    }
                    else if (sekil == 3)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"kırmızıDaire.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                    continue;
                    }
                    else if (sekil == 4)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"sarıDaire.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                    continue;
                    }
                    else if (sekil == 5)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"yesilDaire.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                    continue;
                    }
                    else if (sekil == 6)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"kırmızıKare.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                    continue;
                    }
                    else if (sekil == 7)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"sarıKare.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                    continue;
                    }
                    else if (sekil == 8)
                    {
                        button[Satir, Sutun].BackgroundImage = System.Drawing.Image.FromFile(@"yesilKare.png");
                        button[Satir, Sutun].BackgroundImageLayout = ImageLayout.Stretch;
                    continue;
                    }
                    sekil = 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
