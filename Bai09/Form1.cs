using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "" || txtMSSV.Text == "" || cbNganh.SelectedIndex == -1 ||
                (ckboxNam.Checked == false && ckboxNu.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ListViewItem itemTonTai = null;
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                if (item.SubItems[0].Text == txtMSSV.Text)
                {
                    itemTonTai = item;
                    break;
                }
            }

            if (itemTonTai != null) //cap nhat lai thong tin
            {
                itemTonTai.SubItems[1].Text = txtTen.Text;
                itemTonTai.SubItems[2].Text = cbNganh.SelectedItem.ToString();
                itemTonTai.SubItems[3].Text = ckboxNam.Checked ? "Nam" : "Nữ";
                itemTonTai.SubItems[4].Text = listRight.Items.Count.ToString();

                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
            else //them moi du lieu
            { 
            ListViewItem item = new ListViewItem(txtMSSV.Text);
            item.SubItems.Add(txtTen.Text);
            item.SubItems.Add(cbNganh.SelectedItem.ToString());
            item.SubItems.Add(ckboxNam.Checked ? "Nam" : "Nữ");
            item.SubItems.Add(listRight.Items.Count.ToString());

            lvSinhVien.Items.Add(item);
            MessageBox.Show("Thêm dữ liệu thành công!");
            }

            // reset lai form sau khi luu
            txtMSSV.Text = "";
            txtTen.Text = "";
            cbNganh.SelectedIndex = -1;
            ckboxNam.Checked = false;
            ckboxNu.Checked = false;

            var selectedItems = listRight.Items.Cast<string>().ToList();
            foreach (var item in selectedItems)
            {
                listLeft.Items.Add(item);
            }
            foreach (var item in selectedItems)
            {
                listRight.Items.Remove(item);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //danh sach duoc chon 
            var selectedItems = listLeft.SelectedItems.Cast<string>().ToList();

            foreach (var item in selectedItems) //them mon duoc chon vao ben phai
            {
                listRight.Items.Add(item);
            }

            foreach (var item in selectedItems) // xoa mon da chon o ben trai
            {
                listLeft.Items.Remove(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            var selectedItems = listRight.SelectedItems.Cast<string>().ToList();

            foreach (var item in selectedItems) //them mon duoc chon vao ben trai
            {
                listLeft.Items.Add(item);
            }

            foreach (var item in selectedItems) //xoa mon da chon
            {
                listRight.Items.Remove(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa các môn đã chọn?",
                            "Thông báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

            if(res == DialogResult.Yes)
            {
                var selectedItems = listRight.Items.Cast<string>().ToList();
                foreach(var item in selectedItems)
                {
                    listLeft.Items.Add(item);
                }
                foreach(var item in selectedItems)
                {
                    listRight.Items.Remove(item);
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
