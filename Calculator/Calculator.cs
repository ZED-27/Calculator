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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber;

            firstNumber = Convert.ToDouble(textBox1.Text);
            secondNumber = Convert.ToDouble(textBox2.Text);

            switch(comboBox1.Text)
            {
                case "+":
                    double sum = firstNumber + secondNumber;
                    textBox3.Text = Convert.ToString(sum);
                    break;

                case "-":
                    double difference = firstNumber - secondNumber;
                    textBox3.Text = Convert.ToString(difference);
                    break;

                case "*":
                    double composition = firstNumber * secondNumber;
                    textBox3.Text = Convert.ToString(composition);
                    break;

                case "/":
                    double division = firstNumber / secondNumber;
                    textBox3.Text = Convert.ToString(division);
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.Text = string.Empty;
        }
    }
}
