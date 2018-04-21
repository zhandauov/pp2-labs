using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint2
{
    public enum Tool { Pencil, Fill, Erase, Palette, Line, Triangle, Right_Triangle, Hexagon, Curve, Circle, Rectangle };

    public partial class Form1 : Form
    {
        Graphics g;
        Point prev, cur;
        GraphicsPath gpath;
        Pen pen;
        Bitmap btm;
        Tool tools;
        int rad_hexagon;
        bool flag_circle_bool;
        int flag_circle_int;

        public Form1()
        {
            InitializeComponent();
            flag_circle_bool = true;
            gpath = new GraphicsPath();
            tools = Tool.Pencil;
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;
            g = Graphics.FromImage(btm);
            g.Clear(Color.White);
            pen = new Pen(Color.Black, 3);
            current_color.BackColor = pen.Color;
        }



        private void picturebox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
            switch (tools)
            {
                case Tool.Fill:
                    Color color = new Color();
                    color = btm.GetPixel(e.X, e.Y);
                    Queue<Point> q = new Queue<Point>();
                    if (color.R != pen.Color.R || color.G != pen.Color.G || color.B != pen.Color.B || color.A != pen.Color.A)
                        q.Enqueue(new Point(e.X, e.Y));


                    btm.SetPixel(e.X, e.Y, pen.Color);
                    while (q.Count > 0)
                    {

                        //MessageBox.Show("while");
                        Point curP = q.Dequeue();
                        if (curP.X + 1 < pictureBox1.Width && btm.GetPixel(curP.X + 1, curP.Y) == color)
                        {
                            btm.SetPixel(curP.X + 1, curP.Y, pen.Color);
                            q.Enqueue(new Point(curP.X + 1, curP.Y));
                        }
                        if (curP.X - 1 >= 0 && btm.GetPixel(curP.X - 1, curP.Y) == color)
                        {
                            btm.SetPixel(curP.X - 1, curP.Y, pen.Color);
                            q.Enqueue(new Point(curP.X - 1, curP.Y));
                        }
                        if (curP.Y + 1 < pictureBox1.Height && btm.GetPixel(curP.X, curP.Y + 1) == color)
                        {
                            btm.SetPixel(curP.X, curP.Y + 1, pen.Color);
                            q.Enqueue(new Point(curP.X, curP.Y + 1));
                        }
                        if (curP.Y - 1 >= 0 && btm.GetPixel(curP.X, curP.Y - 1) == color)
                        {
                            btm.SetPixel(curP.X, curP.Y - 1, pen.Color);
                            q.Enqueue(new Point(curP.X, curP.Y - 1));
                        }
                    }
                    pictureBox1.Refresh();
                    break;
                case Tool.Palette:
                    Color clr = new Color();
                    clr = btm.GetPixel(e.X, e.Y);
                    current_color.BackColor = clr;
                    break;
            }

        }

        private void picturebox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gpath.Reset();
                switch (tools)
                {

                    case Tool.Pencil:
                        cur = e.Location;
                        g.DrawLine(pen, prev, cur);
                        prev = cur;
                        break;
                    case Tool.Line:
                        cur = e.Location;
                        gpath.AddLine(prev, cur);
                        break;
                    case Tool.Fill:
                        break;
                    case Tool.Circle:
                        cur = e.Location;
                        if (flag_circle_bool)
                        {
                            flag_circle_int = cur.Y;
                        }
                        gpath.AddEllipse(new Rectangle(prev.X, flag_circle_int, cur.X - prev.X, cur.Y - prev.Y));
                        flag_circle_bool = false;
                        break;
                    case Tool.Erase:
                        cur = e.Location;
                        g.DrawLine(new Pen(Color.White, pen.Width), prev, cur);
                        prev = cur;
                        break;
                    case Tool.Rectangle:
                        cur = e.Location;
                        if (cur.X < prev.X && cur.Y < prev.Y)
                            gpath.AddRectangle(new Rectangle(cur.X, cur.Y, Math.Abs(cur.X - prev.X), Math.Abs(cur.Y - prev.Y)));

                        else if (cur.Y > prev.Y && cur.X < prev.X)
                            gpath.AddRectangle(new Rectangle(cur.X, prev.Y, prev.X - cur.X, cur.Y - prev.Y));

                        else if (cur.X > prev.X && cur.Y < prev.Y)
                            gpath.AddRectangle(new Rectangle(prev.X, cur.Y, cur.X - prev.X, prev.Y - cur.Y));
                        else
                            gpath.AddRectangle(new Rectangle(prev.X, prev.Y, Math.Abs(cur.X - prev.X), Math.Abs(cur.Y - prev.Y)));
                        break;
                    case Tool.Triangle:
                        cur = e.Location;
                        Point[] points = new Point[] { new Point(prev.X, prev.Y), new Point(prev.X - (cur.X - prev.X), cur.Y), cur };
                        gpath.AddPolygon(points);
                        break;
                    case Tool.Hexagon:
                        cur = e.Location;
                        rad_hexagon = (cur.X - prev.X) / 2;
                        Point[] shapes = new Point[6];
                        int x_c = prev.X + (cur.X - prev.X) / 2;
                        int y_c = prev.Y + (cur.Y - prev.Y) / 2;
                        for (int i = 0; i < 6; i++)
                        {
                            shapes[i] = new Point(x_c + rad_hexagon * (int)(Math.Cos(i * 60 * Math.PI / 180f)), y_c + rad_hexagon * (int)Math.Sin(i * 60 * Math.PI / 180f));
                            g.DrawLine(pen, new Point(x_c + rad_hexagon * (int)(Math.Cos(i * 60 * Math.PI / 180f)), y_c + rad_hexagon * (int)Math.Sin(i * 60 * Math.PI / 180f)), new Point(x_c, y_c));
                        }
                        gpath.AddPolygon(shapes);
                        break;
                }
            }
            pictureBox1.Refresh();
        }

        private void picturebox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (tools)
            {
                case Tool.Line:
                    if (gpath != null)
                    {
                        g.DrawPath(pen, gpath);
                        gpath.Reset();
                    }
                    break;
                case Tool.Circle:
                    if (gpath != null)
                    {
                        g.DrawPath(pen, gpath);
                        gpath.Reset();
                        flag_circle_bool = true;
                    }
                    break;
                case Tool.Rectangle:
                    if (gpath != null)
                    {
                        g.DrawPath(pen, gpath);
                        gpath.Reset();
                    }
                    break;
                case Tool.Triangle:
                    if (gpath != null)
                    {
                        g.DrawPath(pen, gpath);
                        gpath.Reset();
                    }
                    break;
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(pen, gpath);
        }

        private void colorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                current_color.BackColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: pen.Width = 2; break;
                case 1: pen.Width = 4; break;
                case 2: pen.Width = 6; break;
                case 3: pen.Width = 8; break;
                case 4: pen.Width = 10; break;
                case 5: pen.Width = 12; break;
            }
        }

        private void color_button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pen.Color = btn.BackColor;
            current_color.BackColor = btn.BackColor;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.* | (*.jpg*)|*.jpg| (*.png*)|*png";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                MessageBox.Show(ext);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }
                btm.Save(saveFileDialog1.FileName, format);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btm = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = btm;
                g = Graphics.FromImage(btm);

            }
        }
        private void tools_Clicked(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch (b.Name)
            {
                case "button_tool_pencil":
                    tools = Tool.Pencil;
                    break;
                case "button_tool_fill":
                    tools = Tool.Fill;
                    break;
                case "button_tool_erase":
                    tools = Tool.Erase;
                    break;
                case "button_tool_palette":
                    tools = Tool.Palette;
                    break;
                case "line":
                    tools = Tool.Line;
                    break;
                case "curve":
                    tools = Tool.Curve;
                    break;
                case "rectangle":
                    tools = Tool.Rectangle;
                    break;
                case "circle":
                    tools = Tool.Circle;
                    break;
                case "triangle":
                    tools = Tool.Triangle;
                    break;
            }
        }
    }
}