using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0, secondNumber = 0, result = 0, memorynumber = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text += btn.Text;
        }
        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstNumber = double.Parse(display.Text);
            operation = btn.Text;

            display.Text = "";
        }
        private void one_operation_Click(object sender, EventArgs e)
        {
            double fak = 1;
            Button btn = sender as Button;
            firstNumber = double.Parse(display.Text);
            operation = btn.Text;
            switch (operation)
            { 
                case "sin":
                    result = (Math.Sin(firstNumber));
                    break;
                case "cos":
                    result = (Math.Cos(firstNumber));
                    break;
                case "sqrt":
                    result = (Math.Sqrt(firstNumber));
                    break;
                case "x^2":
                    result = firstNumber * firstNumber;
                    break;
                case "tan":
                    result = Math.Tan(firstNumber);
                    break;
                case "ctg":
                    result = 1 / Math.Tan(firstNumber);
                    break;
                case "!":
                    for (int i = 2; i < firstNumber; i++)
                    fak *= i;
                    result = fak;
                    break;
                case "log":
                    result = Math.Log(firstNumber);
                    break;
                case "10^x":
                    result = Math.Pow(10, firstNumber);
                    break;
                case "e^x":
                    result = Math.Pow(Math.E, firstNumber);
                    break;                   
            }
            display.Text = result.ToString();
        }

        private void CE(object sender, EventArgs e)
        {
            string temptext = display.Text ;

            display.Text = "";            
        }

        private void button32_Click(object sender, EventArgs e)
        {
            memorynumber = double.Parse(display.Text);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            memorynumber = 0;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            display.Text = memorynumber.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            memorynumber = memorynumber + double.Parse(display.Text);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            memorynumber = memorynumber - double.Parse(display.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string temp = display.Text.Substring(0, display.Text.Length - 1);
            display.Text = temp;
        }

        private void point_click(object sender, EventArgs e)
        {
            for (int i = 0; i<display.Text.Length; i++)
            {
                if (display.Text[i] == ',')
                    return;
            }
            if (display.Text == "")
            {
                display.Text = "0,";
                return;
            }
            display.Text += ',';
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (display.Text == "")
                return;
            secondNumber = double.Parse(display.Text);
            display.Text = "";
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "x^y":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                case "mod":
                    result = firstNumber % secondNumber;
                    break;
                case "x^1/y":
                    result = Math.Pow(firstNumber, 1 / secondNumber);
                    break;
            }
            display.Text = result.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = "";
        }
    }
}