using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace calculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0, secondNumber = 0, result = 0, memorynumber = 0;
        string operation = "";
        string memorytype = "";
        bool flag = false;
        double temp = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "";
            Button btn = sender as Button;
            display.Text += btn.Text;
            flag = false;
        }
        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstNumber = double.Parse(display.Text);
            operation = btn.Text;

            display.Text = "";
            flag = false;
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
                    result = (Math.Sin((firstNumber*Math.PI)/180));
                    break;
                case "cos":
                    result = (Math.Cos((firstNumber * Math.PI) / 180));
                    break;
                case "sqrt":
                    result = (Math.Sqrt(firstNumber));
                    break;
                case "x^2":
                    result = firstNumber * firstNumber;
                    break;
                case "tan":
                    result = Math.Tan((firstNumber * Math.PI) / 180);
                    break;
                case "ctg":
                    result = 1 / Math.Tan((firstNumber * Math.PI) / 180);
                    break;
                case "x!":
                    for (int i = 2; i <= firstNumber; i++)
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
            flag = false;
        }

        private void CE(object sender, EventArgs e)
        {
            string temptext = display.Text ;

            display.Text = "";
            flag = false;
        }

        private void memory_Click(object sender, EventArgs e)
        {
            Button bb = sender as Button;
            memorytype = bb.Text;
            switch (memorytype)
            {
                case "MS":
                    memorynumber = double.Parse(display.Text);
                    flag = false;
                    FileStream fs = new FileStream(@"C:\Users\acer\Desktop\lab pp2\calculator\calculator\bin\Debug\input.txt", FileMode.Open, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(memorynumber);
                    break;
                case "MC":
                    memorynumber = 0;
                    flag = false;
                    break;
                case "MR":
                    display.Text = memorynumber.ToString();
                    flag = false;
                    break;
                case "M+":
                    memorynumber = memorynumber + double.Parse(display.Text);
                    flag = false;
                    break;
                case "M-":
                    memorynumber = memorynumber - double.Parse(display.Text);
                    flag = false;
                    break;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string temp = display.Text.Substring(0, display.Text.Length - 1);
            display.Text = temp;
            if (display.Text == "")
                display.Text = "0";
            flag = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == '0')
                return;
            Button btn = sender as Button;
            display.Text += btn.Text;
            flag = false;
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
            flag = false;
            display.Text += ',';
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (display.Text == "")
                return;
            if (flag == false)
            {
                secondNumber = Double.Parse(display.Text);
                temp = secondNumber;
            }
                
            display.Text = "";
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    firstNumber = result;
                    secondNumber = temp;
                    break;
                case "-":
                    //firstNumber = result;
                    result = firstNumber - secondNumber;
                    firstNumber = result;
                    secondNumber = temp;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    firstNumber = result;
                    secondNumber = temp;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    firstNumber = result;
                    secondNumber = temp;
                    break;
                case "x^y":
                    result = Math.Pow(firstNumber, secondNumber);
                    firstNumber = result;
                    secondNumber = temp;
                    break;
                case "mod":
                    result = firstNumber % secondNumber;
                    firstNumber = result;
                    secondNumber = temp;
                    break;
                case "x^1/y":
                    result = Math.Pow(firstNumber, 1 / secondNumber);
                    firstNumber = result;
                    secondNumber = temp;
                    break;
            }
            flag = true;
            display.Text = result.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            flag = false;
            display.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = "";
        }
    }
}