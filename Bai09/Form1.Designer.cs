namespace Bai09
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listRight = new System.Windows.Forms.ListBox();
            this.listLeft = new System.Windows.Forms.ListBox();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.ckboxNu = new System.Windows.Forms.CheckBox();
            this.ckboxNam = new System.Windows.Forms.CheckBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nganh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.listRight);
            this.groupBox1.Controls.Add(this.listLeft);
            this.groupBox1.Controls.Add(this.cbNganh);
            this.groupBox1.Controls.Add(this.ckboxNu);
            this.groupBox1.Controls.Add(this.ckboxNam);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1521, 738);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(847, 529);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(85, 69);
            this.btnLeft.TabIndex = 19;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(847, 422);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(85, 69);
            this.btnRight.TabIndex = 18;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(916, 646);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 60);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa chọn";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(584, 646);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(261, 60);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listRight
            // 
            this.listRight.FormattingEnabled = true;
            this.listRight.ItemHeight = 37;
            this.listRight.Location = new System.Drawing.Point(1001, 403);
            this.listRight.Name = "listRight";
            this.listRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRight.Size = new System.Drawing.Size(446, 226);
            this.listRight.TabIndex = 13;
            // 
            // listLeft
            // 
            this.listLeft.FormattingEnabled = true;
            this.listLeft.ItemHeight = 37;
            this.listLeft.Items.AddRange(new object[] {
            "Cơ Sở Dữ Liệu",
            "Lập Trình Hướng Đối Tượng",
            "Hệ Điều Hành",
            "Nhập Môn Lập Trình",
            "Lập Trình Trực Quan"});
            this.listLeft.Location = new System.Drawing.Point(330, 403);
            this.listLeft.Name = "listLeft";
            this.listLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listLeft.Size = new System.Drawing.Size(446, 226);
            this.listLeft.TabIndex = 12;
            // 
            // cbNganh
            // 
            this.cbNganh.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Items.AddRange(new object[] {
            "Hệ Thống Thông Tin",
            "Công Nghệ Thông Tin",
            "Kỹ Thuật Phần Mềm",
            "Khoa Học Máy Tính",
            "Kỹ Thuật Máy Tính",
            "An Toàn Thông Tin",
            "Trí Tuệ Nhân Tạo"});
            this.cbNganh.Location = new System.Drawing.Point(642, 196);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(690, 58);
            this.cbNganh.TabIndex = 11;
            // 
            // ckboxNu
            // 
            this.ckboxNu.AutoSize = true;
            this.ckboxNu.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckboxNu.Location = new System.Drawing.Point(862, 277);
            this.ckboxNu.Name = "ckboxNu";
            this.ckboxNu.Size = new System.Drawing.Size(104, 54);
            this.ckboxNu.TabIndex = 10;
            this.ckboxNu.Text = "Nữ";
            this.ckboxNu.UseVisualStyleBackColor = true;
            // 
            // ckboxNam
            // 
            this.ckboxNam.AutoSize = true;
            this.ckboxNam.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckboxNam.Location = new System.Drawing.Point(642, 277);
            this.ckboxNam.Name = "ckboxNam";
            this.ckboxNam.Size = new System.Drawing.Size(133, 54);
            this.ckboxNam.TabIndex = 9;
            this.ckboxNam.Text = "Nam";
            this.ckboxNam.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(642, 117);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(690, 50);
            this.txtTen.TabIndex = 6;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMSSV.Location = new System.Drawing.Point(642, 43);
            this.txtMSSV.Multiline = true;
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(324, 50);
            this.txtMSSV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(320, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chuyên ngành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(320, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(490, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn các môn học tham gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(320, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(320, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(320, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.Ten,
            this.Nganh,
            this.GTinh,
            this.SoMon});
            this.lvSinhVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(36, 772);
            this.lvSinhVien.MultiSelect = false;
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(1521, 421);
            this.lvSinhVien.TabIndex = 1;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            this.MSSV.Width = 150;
            // 
            // Ten
            // 
            this.Ten.Text = "Họ Tên";
            this.Ten.Width = 180;
            // 
            // Nganh
            // 
            this.Nganh.Text = "Chuyên Ngành";
            this.Nganh.Width = 220;
            // 
            // GTinh
            // 
            this.GTinh.Text = "Giới Tính";
            this.GTinh.Width = 100;
            // 
            // SoMon
            // 
            this.SoMon.Text = "Số Môn";
            this.SoMon.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1595, 1263);
            this.Controls.Add(this.lvSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Liệu Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.CheckBox ckboxNu;
        private System.Windows.Forms.CheckBox ckboxNam;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ListBox listRight;
        private System.Windows.Forms.ListBox listLeft;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader Nganh;
        private System.Windows.Forms.ColumnHeader GTinh;
        private System.Windows.Forms.ColumnHeader SoMon;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
    }
}

