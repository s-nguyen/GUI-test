using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Draw!";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        int wow = 0;
        private void button1_Click(object sender, EventArgs e)
        {
         
            pictureBox1.Size = new Size(80, 60);
            Controls.Add(pictureBox1);
            Bitmap pixel = new Bitmap(80, 60);
      
                for (int i = 0; i < 80; i++)
                {
                    for (int j = 0; j < 60; j++)
                    {
                        if (wow % 2 == 0)
                        {
                            pixel.SetPixel(i, j, Color.White);
                        }
                        else
                        {
                            pixel.SetPixel(i, j, Color.Black);
                        }
                        
                    }
                }

                wow++;
                pictureBox1.Image = pixel;

            
            
            //pictureBox1.Size = new Size(80, 60);
            //this.Controls.Add(pictureBox1);

            //Bitmap flag = new Bitmap(80, 60);
            //Graphics flagGraphics = Graphics.FromImage(flag);
            //int red = 0;
            //int white = 11;
            //while (white <= 100)
            //{
            //    flagGraphics.FillRectangle(Brushes.Red, 0, red, 200, 10);
            //    flagGraphics.FillRectangle(Brushes.White, 0, white, 200, 10);
            //    red += 20;
            //    white += 20;
            //}
            //pictureBox1.Image = flag;
        }
    }
}
