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
        decimal num1, num2, result;
        string operat;
        public formcalc()
        {
            InitializeComponent();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDecimal(txtResultdownner.Text);
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
            }
            txtResultdownner.Text = result.ToString();
        }
        private void btnOperators_click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtResultdownner.Text);
            operat = ((Button)sender).Text;
            txtResultdownner.Clear();
        }
        private void btnNumbers_click(object sender, EventArgs e)
        {
            txtResultdownner.Text += ((Button)sender).Text;
            
        }
        private void btnclear_click(object sender, EventArgs e)
        {
            txtResultdownner.Clear();
        }
        private void btnbackspace_click(object sender, EventArgs e)
        {
            if (txtResultdownner.Text.Length > 1)
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
