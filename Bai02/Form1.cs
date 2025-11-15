using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random rand = new Random();
            Font font = new Font("Arial", 20, FontStyle.Bold);
            Color mau = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            int x = rand.Next(this.ClientSize.Width);
            int y = rand.Next(this.ClientSize.Height);
            e.Graphics.DrawString("Paint Event", font, new SolidBrush(mau), x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
