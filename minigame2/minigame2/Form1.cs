using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigame2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int amountx = 7, amounty = 8;
            label1.Location = new Point(label1.Location.X, label1.Location.Y + amounty);
            if (label1.Location.Y >= Height)
                label1.Location = new Point(label1.Location.X, 0);
            if (label1.Location.X >= Width)
                amountx = -7;
            if (label1.Location.X <= 0)
                amountx = 7;
                                 
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (button1.Location.X <= 1)
                        break;
                    button1.Location = new Point(button1.Location.X - 20, button1.Location.Y);
                        break;
                case Keys.D:
                    if (button1.Location.X > Width - 160)
                        break;
                    button1.Location = new Point(button1.Location.X + 20, button1.Location.Y);
                        break;
            }
        }       
    }
}
