using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show("Constructor: Form đang được khởi tạo.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show(" Form_Load: Form đang được tải.");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Show(" Form_Shown: Form đã hiển thị xong.");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Show(" Form_Activated: Form đã nhận focus.");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Show(" Form_Deactivate: Form đã mất focus.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Show("Form_Closing: Chuẩn bị đóng form.");

            DialogResult res = MessageBox.Show("Bạn có chắc muốn thoát không?",
                                                "Xác nhận",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if(res == DialogResult.No)
            {
                e.Cancel = true;
                Show("Form_Closing: Đã hủy đóng form.");
            }
        }

        private void Show(string SuKien)
        {
            string time = DateTime.Now.ToString("HH:mm:ss.fff");
            string log = time + " - " + SuKien;
            txtLog.Text += "\r\n" + log;
        }

    }
}
