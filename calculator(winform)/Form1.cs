using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_winform_
{
    public partial class formcalc : Form
    {
        double num1, num2, result;
        string operat;
        
        public formcalc()
        {
            InitializeComponent();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!(operat == "√")) //
            {
                num2 = Convert.ToDouble(txtResultdownner.Text);
                txtResultupper.Text += num2.ToString(); //
            }
            switch (operat)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "×":
                    result = num1 * num2;
                    break;
                case "÷":
                    result = num1 / num2;
                    break;
                case "√":
                    result = Math.Sqrt(num1);
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                case "⅍":
                    result = num1 / num2;
                    break;

            }
            txtResultupper.Text += "=";
            txtResultdownner.Text = result.ToString();
            txtResultupper.Text = txtResultdownner.Text;
            txtResultupper.Clear();
        }
        private void btnOperators_click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResultdownner.Text);
            txtResultupper.Text += num1.ToString();  //
            operat = ((Button)sender).Text;
            if (operat == "⅍")
            {
                txtResultupper.Text += "/";
            }
            else
            {
                txtResultupper.Text += operat;  //
            }
            txtResultdownner.Clear();
            
        }
        private void btnNumbers_click(object sender, EventArgs e)
        {
            txtResultdownner.Text += ((Button)sender).Text;
            
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtResultdownner.Text += ".";
        }

        private void txtResultdownner_TextChanged(object sender, EventArgs e)
        {
            if (txtResultdownner.Text.Contains("."))
            {
                btnPoint.Enabled = false;
            }
            else
            {
                btnPoint.Enabled = true;
            }
            //this method link to txtresultdowner for validate "." contains
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(txtResultdownner.Text);
            txtResultdownner.Text = (temp * -1).ToString();

        }
        private void btnclear_click(object sender, EventArgs e)
        {
            txtResultdownner.Clear();
            txtResultupper.Clear();
        }
        private void btnbackspace_click(object sender, EventArgs e)
        {
            if (txtResultdownner.Text.Length >= 1)
            {
                txtResultdownner.Text = txtResultdownner.Text.Substring(0, txtResultdownner.Text.Length - 1);

            }
            else
            {
                txtResultdownner.Text = "0";
                txtResultdownner.Clear();
            }

        }
    }
}
