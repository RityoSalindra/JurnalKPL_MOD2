using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302204014
{

    

    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }



        private void num1_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "1";
            CalculatorDisplay.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "2";
            CalculatorDisplay.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "3";
            CalculatorDisplay.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "4";
            CalculatorDisplay.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "5";
            CalculatorDisplay.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "6";
            CalculatorDisplay.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "7";
            CalculatorDisplay.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "8";
            CalculatorDisplay.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "9";
            CalculatorDisplay.Text += userInput;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "0";
            CalculatorDisplay.Text += userInput;
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void hasil_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            //tambah
            if (function == '+')
            {
                result = firstNum + secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
        }
    }
}
