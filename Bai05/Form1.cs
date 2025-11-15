using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float x, y;
            if (float.TryParse(txtNumb1.Text, out x) == false || float.TryParse(txtNumb2.Text, out y) == false)
            {
                MessageBox.Show("Invalid input", "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtAnswer.Text = "";
                return;
            }

            float res = x * y;
            txtAnswer.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x, y;
            if (float.TryParse(txtNumb1.Text, out x) == false || float.TryParse(txtNumb2.Text, out y) == false)
            {
                MessageBox.Show("Invalid input", "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtAnswer.Text = "";
                return;
            }

            float res = x + y;
            txtAnswer.Text= res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float x, y;
            if (float.TryParse(txtNumb1.Text, out x) == false || float.TryParse(txtNumb2.Text, out y) == false)
            {
                MessageBox.Show("Invalid input", "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtAnswer.Text = "";
                return;
            }

            float res = x - y;
            txtAnswer.Text = res.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float x, y;
            if (float.TryParse(txtNumb1.Text, out x) == false || float.TryParse(txtNumb2.Text, out y) == false)
            {
                MessageBox.Show("Invalid input", "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtAnswer.Text = "";
                return;
            }

            if (float.Parse(txtNumb2.Text) == 0)
            {
                MessageBox.Show("Cannot divide by zero", "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtAnswer.Text = "";
                return;
            }

            float res = x / y;
            txtAnswer.Text = res.ToString();
        }
    }
}
