using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        double resultValue = 0; 
        string operationPerformed = ""; // phep toan dang thuc hien
        bool isOperationPerformed = false; // kiem tra phep toan da thuc hien chua

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e) // su kien nhap so
        {
            if (txtAnswer.Text == "Error")
                txtAnswer.Text = "0";

            if (txtAnswer.Text == "0" || isOperationPerformed)
                txtAnswer.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;

            if(button.Text == ".")
            {
                if (txtAnswer.Text.Contains(".") == false)
                {
                    txtAnswer.Text = txtAnswer.Text + button.Text;
                }
            }
            else if (txtAnswer.Text == "0")
                txtAnswer.Text = button.Text;
            else
                txtAnswer.Text = txtAnswer.Text + button.Text;
        }

        private void Operator_Click(object sender, EventArgs e) // su kien nhap phep toan
        {
            Button button = (Button)sender;

            // neu da co phep toan thi thuc hien phep toan truoc
            if(resultValue != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txtAnswer.Text);
                isOperationPerformed = true;
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "0";
            resultValue = 0;
            operationPerformed = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed){
                case "+":
                    txtAnswer.Text = (resultValue + Double.Parse(txtAnswer.Text)).ToString();
                    break;
                case "-":
                    txtAnswer.Text = (resultValue - Double.Parse(txtAnswer.Text)).ToString();
                    break;
                case "*":
                    txtAnswer.Text = (resultValue * Double.Parse(txtAnswer.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(txtAnswer.Text) == 0)
                    {
                        txtAnswer.Text = "Error";
                        break;
                    }
                    else
                        txtAnswer.Text = (resultValue / Double.Parse(txtAnswer.Text)).ToString();
                    break;
             
            }

            if (txtAnswer.Text != "Error")
                resultValue = Double.Parse(txtAnswer.Text);

            operationPerformed = "";

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = (Double.Parse(txtAnswer.Text) / 100).ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "0";
            resultValue = 0;
            operationPerformed = "";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Length > 1)
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1, 1);
            else
                txtAnswer.Text = "0";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (Double.Parse(txtAnswer.Text) < 0)
            {
                txtAnswer.Text = "Error";
                return;
            }

            txtAnswer.Text = Math.Sqrt(Double.Parse(txtAnswer.Text)).ToString();
        }

        private void btn1Chiax_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(txtAnswer.Text);
            if (val == 0)
                txtAnswer.Text = "Error";
            else
                txtAnswer.Text = (1 / val).ToString();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = (Double.Parse(txtAnswer.Text) * -1).ToString();
        }
    }
}
