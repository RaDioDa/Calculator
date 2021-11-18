using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = textBox1.Text + "% = ";
                double inpt = Convert.ToDouble(textBox1.Text);
                double outpt = inpt / 100;
                textBox1.Text = outpt.ToString();
            }
            catch (Exception ex) { textBox2.Text = null; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string inpt = textBox1.Text;
            string[] arr = inpt.Split(' ');
            if (arr.Length == 1) textBox1.Text = textBox1.Text + " / ";
            else if (arr[arr.Length - 2] != "+" && arr[arr.Length - 2] != "-" && arr[arr.Length - 2] != "/" && arr[arr.Length - 2] != "*" && arr[arr.Length - 2] != ".")
                textBox1.Text = textBox1.Text + " / ";
            textBox2.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = "sqrt(" + textBox1.Text + ") = ";
                double inpt = Convert.ToDouble(textBox1.Text);
                double outpt = Math.Sqrt(inpt);
                textBox1.Text = inpt.ToString();
            }
            catch (Exception ex) { textBox2.Text = null; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = textBox1.Text + "^2 = ";
                double inpt = Convert.ToDouble(textBox1.Text);
                double outpt = Math.Pow(inpt, 2);
                textBox1.Text = outpt.ToString();
            }
            catch (Exception ex) { textBox2.Text = null; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = "1 / " + textBox1.Text;
                double inpt = Convert.ToDouble(textBox1.Text);
                double outpt = 1 / inpt;
                textBox1.Text = outpt.ToString();
            }
            catch (Exception ex) { textBox2.Text = null; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string inpt = textBox1.Text;
            string[] arr = inpt.Split(' ');
            if (arr.Length == 1) textBox1.Text = textBox1.Text + " * ";
            else if (arr[arr.Length - 2] != "+" && arr[arr.Length - 2] != "-" && arr[arr.Length - 2] != "/" && arr[arr.Length - 2] != "*" && arr[arr.Length - 2] != ".")
                textBox1.Text = textBox1.Text + " * "; 
            textBox2.Text = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text = textBox1.Text + "9";
            textBox2.Text = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text = textBox1.Text + "8";
            textBox2.Text = null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text = textBox1.Text + "7";
            textBox2.Text = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string inpt = textBox1.Text;
            string[] arr = inpt.Split(' ');
            if (arr.Length == 1) textBox1.Text = textBox1.Text + " - ";
            else if (arr[arr.Length - 2] != "+" && arr[arr.Length - 2] != "-" && arr[arr.Length - 2] != "/" && arr[arr.Length - 2] != "*" && arr[arr.Length - 2] != ".")
                textBox1.Text = textBox1.Text + " - ";
            textBox2.Text = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text = textBox1.Text + "6";
            textBox2.Text = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text = textBox1.Text + "5";
            textBox2.Text = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text = textBox1.Text + "4";
            textBox2.Text = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string inpt = textBox1.Text;
            string[] arr = inpt.Split(' ');
            if (arr.Length == 1) textBox1.Text = textBox1.Text + " + ";
            else if (arr[arr.Length - 2] != "+" && arr[arr.Length - 2] != "-" && arr[arr.Length - 2] != "/" && arr[arr.Length - 2] != "*" && arr[arr.Length - 2] != ".")
                textBox1.Text = textBox1.Text + " + ";
            textBox2.Text = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text = textBox1.Text + "3";
            textBox2.Text = null;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text = textBox1.Text + "2";
            textBox2.Text = null;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text = textBox1.Text + "1";
            textBox2.Text = null;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + " = ";
            string inpt = textBox1.Text;
            string[] arr = inpt.Split(' ');
            double ansvr = 0;
            ansvr = Convert.ToDouble(arr[0]);

            try
            {
                for (int i = 1; i < arr.Length - 1; i++)
                {
                    if (arr[i] == "+") ansvr += Convert.ToDouble(arr[i + 1]);
                    if (arr[i] == "-") ansvr -= Convert.ToDouble(arr[i + 1]);
                    if (arr[i] == "*") ansvr *= Convert.ToDouble(arr[i + 1]);
                    if (arr[i] == "/") ansvr /= Convert.ToDouble(arr[i + 1]);

                }
                string outpt = Convert.ToString(ansvr);
                textBox1.Text = outpt;
            }
            catch (Exception) { textBox2.Text = null; }
            
        }
        private void button22_Click(object sender, EventArgs e)
        {
            string inpt = textBox1.Text;
            string[] arr = inpt.Split(' ');
            if (arr.Length == 1) textBox1.Text = textBox1.Text + ".";
            else if (arr[arr.Length - 2] != "+" && arr[arr.Length - 2] != "-" && arr[arr.Length - 2] != "/" && arr[arr.Length - 2] != "*" && arr[arr.Length - 2] != ".")
                textBox1.Text = textBox1.Text + ".";
            textBox2.Text = null;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox1.Text = textBox1.Text + "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
