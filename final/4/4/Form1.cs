using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        SolidBrush brush = new SolidBrush(Color.Red);
        GraphicsPath path;
        Random random;
        int col;
        int w = 50, h = 50;
        int px = 50, py;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            random = new Random();
            g = CreateGraphics();
            int px = random.Next(4, 500);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            py += 20;
            if (py >= Height)
            {
                col = random.Next(1, 4);
                if (col == 1)
                    brush = new SolidBrush(Color.Red);
                if (col == 2)
                    brush = new SolidBrush(Color.Green);
                if (col == 3)
                    brush = new SolidBrush(Color.Blue);
                if (col == 4)
                    brush = new SolidBrush(Color.Black);
                py = 0;
                px = random.Next(1, 450);
            }
            else
                g.FillEllipse(brush, px, py, w, h);
        }
    }
}
