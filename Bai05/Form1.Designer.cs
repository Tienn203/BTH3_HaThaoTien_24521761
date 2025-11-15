namespace Bai05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumb1 = new System.Windows.Forms.TextBox();
            this.txtNumb2 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(146, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(146, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(191, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer";
            // 
            // txtNumb1
            // 
            this.txtNumb1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNumb1.Location = new System.Drawing.Point(370, 85);
            this.txtNumb1.Multiline = true;
            this.txtNumb1.Name = "txtNumb1";
            this.txtNumb1.Size = new System.Drawing.Size(590, 48);
            this.txtNumb1.TabIndex = 3;
            this.txtNumb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumb2
            // 
            this.txtNumb2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNumb2.Location = new System.Drawing.Point(370, 200);
            this.txtNumb2.Multiline = true;
            this.txtNumb2.Name = "txtNumb2";
            this.txtNumb2.Size = new System.Drawing.Size(590, 48);
            this.txtNumb2.TabIndex = 4;
            this.txtNumb2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAnswer.Location = new System.Drawing.Point(370, 535);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(590, 48);
            this.txtAnswer.TabIndex = 5;
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCong.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCong.Location = new System.Drawing.Point(239, 331);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(100, 96);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = false;
            this.btnCong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhan.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhan.Location = new System.Drawing.Point(591, 331);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(100, 96);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = false;
            this.btnNhan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChia
            // 
            this.btnChia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChia.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChia.Location = new System.Drawing.Point(771, 331);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(100, 96);
            this.btnChia.TabIndex = 8;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = false;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnTru
            // 
            this.btnTru.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTru.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTru.Location = new System.Drawing.Point(416, 331);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(100, 96);
            this.btnTru.TabIndex = 9;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = false;
            this.btnTru.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1081, 740);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtNumb2);
            this.Controls.Add(this.txtNumb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumb1;
        private System.Windows.Forms.TextBox txtNumb2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnTru;
    }
}

