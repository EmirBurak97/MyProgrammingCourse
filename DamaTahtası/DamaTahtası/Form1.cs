using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 750;
            this.Width = 750;
            //Basic

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Button btn = new Button();
            //        btn.Width = (this.Width-35) / 8;
            //        btn.Height = (this.Height-53) / 8;                    
            //        btn.Location = new Point(i * btn.Width, j * btn.Height);
            //        if (i%2==0)
            //        {
            //            btn.BackColor = Color.Black;
            //        }
            //        else
            //        {
            //            btn.BackColor = Color.White;
            //        }
            //        this.Controls.Add(btn);
            //    }
            //}

            Button[,] buttons = new Button[8, 8];
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i,j].Width = 100;
                    buttons[i, j].Height = 100;
                    
                    buttons[i, j].Location = new Point(i * buttons[i, j].Width, j * buttons[i, j].Height);
                    if (i % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }
    }
}
