using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int GiaGhe(object sender)
        {
            Button ghe = (Button)sender;
            int SoGhe = int.Parse(ghe.Text);
            if (SoGhe >= 1 && SoGhe <= 5)
                return 5000;
            else if (SoGhe >= 6 && SoGhe <= 10)
                return 6500;
            else
                return 8000;
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Button ghe = (Button)sender;

            if (ghe.BackColor == Color.White)
            {
                ghe.BackColor = Color.Blue;
                //lblSum.Text = (int.Parse(lblSum.Text) + GiaGhe(sender)).ToString();
            }
            else if (ghe.BackColor == Color.Blue)
            {
                ghe.BackColor = Color.White;
                //lblSum.Text = (int.Parse(lblSum.Text) - GiaGhe(sender)).ToString();
            }
            else
            {
                MessageBox.Show("Ghế này đã được bán!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            var ListGhe = new List<Button>
            {
                Ghe1, Ghe2, Ghe3, Ghe4, Ghe5,
                Ghe6, Ghe7, Ghe8, Ghe9, Ghe10,
                Ghe11, Ghe12, Ghe13, Ghe14, Ghe15
            };

            int sum = 0;
            foreach (var ghe in ListGhe)
            {
                if (ghe.BackColor == Color.Blue)
                {
                    sum += GiaGhe(ghe);
                    ghe.BackColor = Color.Yellow;
                }
            }

            lblSum.Text = sum.ToString() + " VND";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            var ListGhe = new List<Button>
            {
                Ghe1, Ghe2, Ghe3, Ghe4, Ghe5,
                Ghe6, Ghe7, Ghe8, Ghe9, Ghe10,
                Ghe11, Ghe12, Ghe13, Ghe14, Ghe15
            };

            foreach(var ghe in ListGhe)
            {
                if(ghe.BackColor == Color.Blue)
                {
                    ghe.BackColor = Color.White;
                }
            }

            lblSum.Text = "0 VND";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
