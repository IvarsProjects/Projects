using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Double resultVlaue = 0;
        String operationPerforned = "";
        bool isOperationPerformed = false;


        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
            {
                textBox_Result.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;

            if (resultVlaue != 0)
            {
                vienads.PerformClick();
                operationPerforned = operatorButton.Text;
                labelCurrentOperation.Text = resultVlaue + " " + operationPerforned;
                isOperationPerformed = true;
            }
            else
            {
                operationPerforned = operatorButton.Text;
                resultVlaue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultVlaue + " " + operationPerforned;
                isOperationPerformed = true;
            }
        }
   

        private void CE_click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void C_click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultVlaue = 0;
        }

        private void equal_click(object sender, EventArgs e)
        {
            switch (operationPerforned)
            {
                case "+" :
                    textBox_Result.Text = (resultVlaue + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (resultVlaue - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (resultVlaue * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (resultVlaue / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;
            }
            resultVlaue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }








    }
}
