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
        static Button btn1,btn2;
        static PictureBox pct1, pct2;
        static RadioButton rd1, rd2, rd3;
        static string[] pictures = { "kamen.png", "bumaga.jpg", "noz.jpg" };
        static int joker;
        static Label Win;
       

        static Random rnd = new Random();

        public Form1()
        {

            

            this.Height = 600;
            this.Width = 1250;
            this.Text = "Kivi Paber Käärid";
            this.BackColor = Color.Aquamarine;

            btn1 = new Button();
            btn1.Text = "Начать";
            btn1.Location = new Point(555, 10);
            btn1.Height = 50;
            btn1.Width = 150;
            btn1.Click += Btn1_Click;
            

            btn2 = new Button();
            btn2.Text = "Рестарт";
            btn2.Location = new Point(555, 100);
            btn2.Height = 50;
            btn2.Width = 150;
            btn2.Click += Btn2_Click; 

            rd1 = new RadioButton();
            rd1.Text = "Камень";
            rd1.Location = new Point(500, 400);
            rd1.Height = 50;
            rd1.Width = 150;
            rd1.Click += Rd1_Click;

            rd2 = new RadioButton();
            rd2.Text = "Бумага";
            rd2.Location = new Point(400, 400);
            rd2.Height = 50;
            rd2.Width = 150;
            rd2.Click += Rd2_Click;

            rd3 = new RadioButton();
            rd3.Text = "Ножницы";
            rd3.Location = new Point(300, 400);
            rd3.Height = 50;
            rd3.Width = 150;
            rd3.Click += Rd3_Click;



            pct1 = new PictureBox();
            pct1.Location = new Point(800, 50);
            pct1.Height = 200;
            pct1.Width = 200;
            pct1.Image = Image.FromFile(@"..\..\Pictures\vopros1.jpg");
            pct1.SizeMode = PictureBoxSizeMode.StretchImage;

            pct2 = new PictureBox();
            pct2.Location = new Point(150, 50);
            pct2.Height = 200;
            pct2.Width = 200;
            pct2.Image = Image.FromFile(@"..\..\Pictures\vopros1.jpg");
            pct2.SizeMode = PictureBoxSizeMode.StretchImage;

            


            this.Controls.Add(btn1);
            this.Controls.Add(btn2);

            this.Controls.Add(pct1);
            this.Controls.Add(pct2);

            this.Controls.Add(rd1);
            this.Controls.Add(rd2);
            this.Controls.Add(rd3);
            

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Rd3_Click(object sender, EventArgs e)
        {
            pct2.Image = Image.FromFile(@"../../Pictures/" + pictures[2]);
            joker = 2;

        }     

        private void Rd1_Click(object sender, EventArgs e)
        {
            pct2.Image = Image.FromFile(@"../../Pictures/" + pictures[0]);
            joker = 0;

        }
        private void Rd2_Click(object sender, EventArgs e)
        {
            pct2.Image = Image.FromFile(@"../../Pictures/" + pictures[1]);
            joker = 1;

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(0, 3);
            pct1.Image = Image.FromFile(@"../../Pictures/" + pictures[a]);
            Label Win = new Label();
            Win.BackColor = Color.Gray;
            Win.Location = new Point(530, 300);

            if (pictures[a] == pictures[joker])
            {
                Win.Text = "Никто не выйграл";
                
            }               
            else if (pictures[a] == "kamen.png" && pictures[joker] == "noz.jpg")
            {
                Win.Text = "Выйграл Бот";
                
            }
            else if (pictures[a] == "noz.png" && pictures[joker] == "bumaga.jpg")
            {
                Win.Text = "Выйграл Я";
                
            }
            else if (pictures[a] == "bumaga.jpg" && pictures[joker] == "noz.jpg")
            {
                Win.Text = "Выйграл Я";

            }
            else if (pictures[a] == "bumaga.jpg" && pictures[joker] == "kamen.png")
            {
                Win.Text = "Выйграл Бот";
                
            }
            else if (pictures[a] == "noz.jpg" && pictures[joker] == "kamen.png")
            {
                Win.Text = "Выйграл я";

            }
            else if (pictures[a] == "kamen.png" && pictures[joker] == "bumaga.jpg")
            {
                Win.Text = "Выйграл я";

            }
            else if (pictures[a] == "noz.jpg" && pictures[joker] == "bumaga.jpg")
            {
                Win.Text = "Выйграл Бот";

            }
            else if (pictures[a] == "bumaga.jpg" && pictures[joker] == "noz.jpg")
            {
                Win.Text = "Выйграл Я";
                
            }           
            else
            {
                Win.Text = "Еггор";

            }
            this.Controls.Add(Win);
            
        }
        
    }
}
