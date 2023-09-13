using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimiento
{
    public partial class Form1 : Form
    {
        Label redSquare = new Label();
        Label yellowSquare = new Label();
        bool redSquareE = false;
        bool yellowSquareE = false;
        bool returnLeft = false;
        bool returnTop = false;
        bool returnRight = false;
        bool returnBottom = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            timerRed.Start();
            timerYellow.Start();
        }
        private void btPausar_Click(object sender, EventArgs e)
        {
            timerRed.Stop();
            timerYellow.Stop();
            if (redSquare.BackColor == Color.Red)
            {
                btIniciar.Text = "Reanudar";
            }
        }

        private void timerRed_Tick(object sender, EventArgs e)
        {

            if (redSquareE == false)
            {
                redSquare.Text = "";
                redSquare.BackColor = Color.Red;
                redSquare.AutoSize = false;
                redSquare.Width = 50;
                redSquare.Height = 50;
                redSquare.Top = 120;
                redSquare.Left = 0;
                Controls.Add(redSquare);
                redSquareE = true;
            }

            if (returnLeft == false & (redSquare.Left + redSquare.Width) < this.Width)
            {
                redSquare.Left = redSquare.Left + 4;
            }
            else
            {
                if (returnLeft == false)
                {
                    returnLeft = true;
                }
                redSquare.Left = redSquare.Left - 4;
                if (redSquare.Left <= 0)
                {
                    returnLeft = false;
                }
            }

            if (returnTop == false & (redSquare.Top + redSquare.Height) < this.Height)
            {
                redSquare.Top = redSquare.Top + 4;
            }
            else
            {
                if (returnTop == false)
                {
                    returnTop = true;
                }
                redSquare.Top = redSquare.Top - 4;
                if (redSquare.Top <= 0)
                {
                    returnTop = false;
                }
            }
        }

        private void timerYellow_Tick(object sender, EventArgs e)
        {
            if (yellowSquareE == false)
            {
                yellowSquare.Text = "";
               yellowSquare.BackColor = Color.Yellow;
                yellowSquare.AutoSize = false;
                yellowSquare.Width = 50;
               yellowSquare.Height = 50;
                yellowSquare.Top = 120;
                yellowSquare.Left = (this.Width - 70);
                Controls.Add(yellowSquare);
                yellowSquareE = true;
            }

            if (returnRight == false & yellowSquare.Left >= 0)
            {
                yellowSquare.Left = yellowSquare.Left - 4;
            }
            else
            {
                if (returnRight == false)
                {
                    returnRight = true;
                }
                yellowSquare.Left = yellowSquare.Left + 4;
                if ((yellowSquare.Left + yellowSquare.Width) >= this.Width)
                {
                    returnRight = false;
                }
            }

            if (returnBottom == false & yellowSquare.Top >= 0)
            {
                yellowSquare.Top = yellowSquare.Top - 4;
            }
            else
            {
                if (returnBottom == false)
                {
                    returnBottom = true;
                }
                yellowSquare.Top = yellowSquare.Top + 4;
                if ((yellowSquare.Top + yellowSquare.Height) >= this.Height)
                {
                    returnBottom = false;
                }
            }
        }
    }
}
