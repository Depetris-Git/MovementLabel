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
        bool ReturnLeft = false;
        bool ReturnTop = false;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btIniciar_Click(object sender, EventArgs e)
        {
            Label figura = new Label();
            figura.Text = "";
            figura.BackColor = Color.Red;
            figura.AutoSize = false;
            figura.Width = 50;
            figura.Height = 50;
            figura.Top = 120;
            figura.Left = 0;
            Controls.Add(figura);

            do
            {
                if (ReturnLeft == false & (figura.Left + figura.Width) < this.Width)
                {
                    figura.Left = figura.Left + 4;
                }
                else
                {
                    if (ReturnLeft == false)
                    {
                        ReturnLeft = true;
                    }
                    figura.Left = figura.Left - 4;
                    if (figura.Left <= 0)
                    {
                        ReturnLeft = false;
                    }
                }

                if (ReturnTop == false & (figura.Top + figura.Height) < this.Height)
                {
                    figura.Top = figura.Top + 4;
                }
                else
                {
                    if (ReturnTop == false)
                    {
                        ReturnTop = true;
                    }
                    figura.Top = figura.Top - 4;
                    if (figura.Top <= 0)
                    {
                        ReturnTop = false;
                    }
                }
                await Task.Delay(10);

            } while (1 == 1);
        }
    }
}
