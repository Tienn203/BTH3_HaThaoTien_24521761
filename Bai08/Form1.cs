using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        private int stt = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CapNhatSTT() 
        {
            int stt = 1;
            foreach(ListViewItem item in lvTaiKhoan.Items)
            {
                item.SubItems[0].Text = stt.ToString();
                stt++;
            }
        }

        private void TongTien()
        {
            long sum = 0;
            foreach(ListViewItem item in lvTaiKhoan.Items)
            {
                sum += long.Parse(item.SubItems[4].Text);
            }

            lblSum.Text = sum.ToString() + " VND";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtDChi.Text=="" || txtSoTien.Text=="" || txtSTK.Text=="" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", 
                                "Thông báo", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                return;
            }

            ListViewItem itemTonTai = null; //check STK da ton tai chua

            foreach(ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == txtSTK.Text)
                {
                    itemTonTai = item;
                    break;
                }
            }

            if (itemTonTai == null) //them du lieu moi
            {
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(txtSTK.Text);
                item.SubItems.Add(txtTen.Text);
                item.SubItems.Add(txtDChi.Text);
                item.SubItems.Add(txtSoTien.Text);

                lvTaiKhoan.Items.Add(item);
                TongTien();
                CapNhatSTT();

                MessageBox.Show("Thêm mới dữ liêu thành công!");
            }
            else //cap nhat lai du lieu
            {
                itemTonTai.SubItems[2].Text = txtTen.Text;
                itemTonTai.SubItems[3].Text = txtDChi.Text;
                itemTonTai.SubItems[4].Text = txtSoTien.Text;

                MessageBox.Show("Cập nhật dữ liệu thành công!");

                TongTien();
            }
            txtSTK.Text = "";
            txtTen.Text = "";
            txtDChi.Text = "";
            txtSoTien.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem itemXoa = null;

            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if(txtSTK.Text == item.SubItems[1].Text)
                {
                    itemXoa = item;
                    break;
                }
            }

            if(itemXoa == null) //khong tim thay STK can xoa
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!",
                                 "Thông báo", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                return;
            }
           
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?",
                                               "Xác nhận",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                lvTaiKhoan.Items.Remove(itemXoa);
                CapNhatSTT();
                MessageBox.Show("Xóa tài khoản thành công!");

                txtSTK.Text = "";
                txtTen.Text = "";
                txtDChi.Text = "";
                txtSoTien.Text = "";
                TongTien();
            }
        }

        private void SelectedRow(object sender, EventArgs e) //hien du lieu len textbox
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                txtSTK.Text = "";
                txtTen.Text = "";
                txtDChi.Text = "";
                txtSoTien.Text = "";
                return;
            }

            ListViewItem item = lvTaiKhoan.SelectedItems[0];

            txtSTK.Text = item.SubItems[1].Text;
            txtTen.Text = item.SubItems[2].Text;
            txtDChi.Text = item.SubItems[3].Text;
            txtSoTien.Text = item.SubItems[4].Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
