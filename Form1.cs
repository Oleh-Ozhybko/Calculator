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
        double a, b;
        char c;
        public Form1()
        {
            InitializeComponent();
        }
        #region buttons0_9
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "0";
        }


        #endregion
        #region methods_+-*/=
        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBoxResult.Text);
                c = '+';
                textBoxResult.Text = String.Empty;
            }
            catch (Exception ex) {Console.WriteLine(MessageBox.Show(ex.Message)); }
        }
        private void minus_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBoxResult.Text);
                c = '-';
                textBoxResult.Text = String.Empty;
            }
            catch (Exception ex) {Console.WriteLine(MessageBox.Show(ex.Message)); }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBoxResult.Text);
                c = '*';
                textBoxResult.Text = String.Empty;
            }
            catch (Exception ex) {Console.WriteLine(MessageBox.Show(ex.Message)); }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBoxResult.Text);
                c = '/';
                textBoxResult.Text = String.Empty;
            }
            catch (Exception ex) {Console.WriteLine(MessageBox.Show(ex.Message)); }
        }
        private void total_Click(object sender, EventArgs e)
        {
            try
            {
                b = double.Parse(textBoxResult.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            textBoxResult.Text = String.Empty;

            switch (c)
            {
                case '+':
                    textBoxResult.Text = Convert.ToString(a + b);
                    break;
                case '-':
                    textBoxResult.Text = Convert.ToString(a - b);
                    break;
                case '*':
                    textBoxResult.Text = Convert.ToString(a * b);
                    break;
                case '/':
                    if (b != 0)
                        textBoxResult.Text = Convert.ToString(a / b);
                    else
                        textBoxResult.Text = "0";
                    break;
                case '%':
                    textBoxResult.Text = Convert.ToString(a * b / 100);
                    break;
            }
        }
        #endregion
        #region methods_dot_bs_c
        private void dot_Click(object sender, EventArgs e) 
        {
            if (!textBoxResult.Text.Contains('.'))
                textBoxResult.Text += ".";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            try
            {
            string tempString = textBoxResult.Text;
            tempString = tempString.Substring(0, tempString.Length - 1);
            textBoxResult.Text = tempString;
            }
            catch (Exception ex) {Console.WriteLine(MessageBox.Show(ex.Message)); }

        }
        private void C_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            textBoxResult.Clear();
        }
        #endregion
        #region math_methods
        private void percent_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBoxResult.Text);
                c = '%';
                textBoxResult.Text = String.Empty;
            }
            catch (Exception ex) {Console.WriteLine(MessageBox.Show(ex.Message)); }
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBoxResult.Text);
                textBoxResult.Text = Convert.ToString(Math.Sqrt(a));
            }
            catch (Exception ex) { Console.WriteLine(MessageBox.Show(ex.Message)); }

        }

        private void exponentiationButton_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBoxResult.Text);
                textBoxResult.Text = Convert.ToString(Math.Pow(a, 2));
            }
            catch (Exception ex) {MessageBox.Show(ex.Message); }
        }
        private void derivative_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxResult.Text);
                textBoxResult.Text = Convert.ToString(1 / a);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void abs_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBoxResult.Text.Contains('-'))
                    textBoxResult.Text = "-" + textBoxResult.Text;
                else
                {
                    a = double.Parse(textBoxResult.Text);
                    a = Math.Abs(a);
                    textBoxResult.Text = Convert.ToString(a);
                }
            }
            catch (Exception ex) { Console.WriteLine(MessageBox.Show(ex.Message)); }
        }
        #endregion
    }
}
