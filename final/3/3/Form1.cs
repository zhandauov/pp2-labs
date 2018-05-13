using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{ 
    public partial class Form1 : Form
    {
        public  void clear()
        {
            if (gameover() == true && cnt % 2 == 0)
            {
                MessageBox.Show("O wins");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
            }
            if (gameover() == true && cnt % 2 != 0)
            {
                MessageBox.Show("X wins");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
            }

        }
        bool gameover()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                return true;
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                return true;
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                return true;
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                return true;
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                return true;
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                return true;
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                return true;
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                return true;

            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                return true;
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                return true;
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                return true;
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                return true;
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                return true;
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                return true;
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                return true;
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                return true;

            else
                return false;
        }
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnt++;
            if (button1.Text == "")
            {
                if (cnt % 2 == 0)
                    button1.Text = "O";
                else
                    button1.Text = "X";
            }
            clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnt++;
            if (button3.Text == "")
            {
                if (cnt % 2 == 0)
                    button3.Text = "O";
                else
                    button3.Text = "X";
            }
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnt++;
            if (button2.Text == "")
            {
                if (cnt % 2 == 0)
                    button2.Text = "O";
                else
                    button2.Text = "X";
            }
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnt++;
            if (button4.Text == "")
            {
                if (cnt % 2 == 0)
                    button4.Text = "O";
                else
                    button4.Text = "X";
            }
            clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnt++;
            if (button5.Text == "")
            {
                if (cnt % 2 == 0)
                    button5.Text = "O";
                else
                    button5.Text = "X";
            }
            clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cnt++;
            if (button6.Text == "")
            {
                if (cnt % 2 == 0)
                    button6.Text = "O";
                else
                    button6.Text = "X";
            }
            clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cnt++;
            if (button7.Text == "")
            {
                if (cnt % 2 == 0)
                    button7.Text = "O";
                else
                    button7.Text = "X";
            }
            clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cnt++;
            if (button8.Text == "")
            {
                if (cnt % 2 == 0)
                    button8.Text = "O";
                else
                    button8.Text = "X";
            }
            clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cnt++;
            if (button9.Text == "")
            {
                if (cnt % 2 == 0)
                    button9.Text = "O";
                else
                    button9.Text = "X";
            }
            clear();
        }
    }
}
