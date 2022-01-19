using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiviPaberGrigorjev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Button btn1;
            PictureBox pct1,pct2;
            RadioButton rd1, rd2, rd3;

            Random rnd = new Random();
            int a = rnd.Next(0, 3);
            string[] pictures = { "kamen.jpg", "bumaga.jpg", "noz.jpg" };

            this.Height = 1500;
            this.Width = 1250;
            this.Text = "Kivi Paber Käärid";

            btn1 = new Button();
            btn1.Text = "Start Game";
            btn1.Location = new Point(555, 10);
            btn1.Height = 50;
            btn1.Width = 150;
            btn1.Click += Btn1_Click;

            rd1 = new RadioButton();
            rd1.Text = "Kamen";
            rd1.Location = new Point(500, 600);
            rd1.Height = 50;
            rd1.Width = 150;
            rd1.Click

            rd2 = new RadioButton();
            rd2.Text = "Noz";
            rd2.Location = new Point(400, 600);
            rd2.Height = 50;
            rd2.Width = 150;

            rd3 = new RadioButton();
            rd3.Text = "Bumaga";
            rd3.Location = new Point(300, 600);
            rd3.Height = 50;
            rd3.Width = 150;



            pct1 = new PictureBox();
            pct1.Location = new Point(800, 50);
            pct1.Height = 450;
            pct1.Width = 450;
            pct1.Image = Image.FromFile(@"..\..\Pictures\vopros1.jpg");

            pct2 = new PictureBox();
            pct2.Location = new Point(150, 50);
            pct2.Height = 450;
            pct2.Width = 450;
            pct2.Image = Image.FromFile(@"..\..\Pictures\vopros1.jpg");


            this.Controls.Add(btn1);

            this.Controls.Add(pct1);
            this.Controls.Add(pct2);

            this.Controls.Add(rd1);
            this.Controls.Add(rd2);
            this.Controls.Add(rd3);

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
          


        }
    }
}
