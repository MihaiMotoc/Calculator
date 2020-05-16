using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        Double result = 0;
        String operation = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
       
        
            if ((textBox1.Text == "0") || (isOperationPerformed ))
                textBox1.Clear();
             isOperationPerformed = false;

            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;

            }else 

            textBox1.Text = textBox1.Text + button.Text;




        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                button5.PerformClick();
                operation = button.Text;
                labelCurrentOperation.Text = result + " " + operation;
                isOperationPerformed = true;
            }
            else
            {

                operation = button.Text;
                result = Double.Parse(textBox1.Text);
                labelCurrentOperation.Text = result + " " + operation;
                isOperationPerformed = true;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;



            }
            result = Double.Parse(textBox1.Text);
            labelCurrentOperation.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
    