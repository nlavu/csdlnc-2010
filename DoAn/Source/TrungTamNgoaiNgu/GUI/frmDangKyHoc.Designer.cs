namespace GUI
{
    partial class frmDangKyHoc
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
            this.maLopMo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLopMo = new System.Windows.Forms.ComboBox();
            this.checkBoxFlag = new System.Windows.Forms.CheckBox();
            this.gbxNhapMa = new System.Windows.Forms.GroupBox();
            this.txtMaHocVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxNhapThongTin = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTenHocVien = new System.Windows.Forms.TextBox();
            this.soDienThoaiHV = new System.Windows.Forms.Label();
            this.tenHocVien = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.gbxNhapMa.SuspendLayout();
            this.gbxNhapThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // maLopMo
            // 
            this.maLopMo.AutoSize = true;
            this.maLopMo.Location = new System.Drawing.Point(69, 79);
            this.maLopMo.Name = "maLopMo";
            this.maLopMo.Size = new System.Drawing.Size(31, 13);
            this.maLopMo.TabIndex = 0;
            this.maLopMo.Text = "Lớp :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "ĐĂNG KÝ HỌC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxLopMo
            // 
            this.cbxLopMo.FormattingEnabled = true;
            this.cbxLopMo.Location = new System.Drawing.Point(166, 76);
            this.cbxLopMo.Name = "cbxLopMo";
            this.cbxLopMo.Size = new System.Drawing.Size(152, 21);
            this.cbxLopMo.TabIndex = 5;
            // 
            // checkBoxFlag
            // 
            this.checkBoxFlag.AutoSize = true;
            this.checkBoxFlag.Location = new System.Drawing.Point(69, 113);
            this.checkBoxFlag.Name = "checkBoxFlag";
            this.checkBoxFlag.Size = new System.Drawing.Size(113, 17);
            this.checkBoxFlag.TabIndex = 6;
            this.checkBoxFlag.Text = "Nhập mã học viên";
            this.checkBoxFlag.UseVisualStyleBackColor = true;
            this.checkBoxFlag.CheckedChanged += new System.EventHandler(this.checkBoxFlag_CheckedChanged);
            // 
            // gbxNhapMa
            // 
            this.gbxNhapMa.Controls.Add(this.txtMaHocVien);
            this.gbxNhapMa.Controls.Add(this.label2);
            this.gbxNhapMa.Location = new System.Drawing.Point(23, 147);
            this.gbxNhapMa.Name = "gbxNhapMa";
            this.gbxNhapMa.Size = new System.Drawing.Size(341, 62);
            this.gbxNhapMa.TabIndex = 7;
            this.gbxNhapMa.TabStop = false;
            this.gbxNhapMa.Text = "Nhap ma hoc vien";
            // 
            // txtMaHocVien
            // 
            this.txtMaHocVien.Location = new System.Drawing.Point(143, 26);
            this.txtMaHocVien.Name = "txtMaHocVien";
            this.txtMaHocVien.Size = new System.Drawing.Size(152, 20);
            this.txtMaHocVien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma hoc vien :";
            // 
            // gbxNhapThongTin
            // 
            this.gbxNhapThongTin.Controls.Add(this.textBox3);
            this.gbxNhapThongTin.Controls.Add(this.txtTenHocVien);
            this.gbxNhapThongTin.Controls.Add(this.soDienThoaiHV);
            this.gbxNhapThongTin.Controls.Add(this.tenHocVien);
            this.gbxNhapThongTin.Location = new System.Drawing.Point(22, 215);
            this.gbxNhapThongTin.Name = "gbxNhapThongTin";
            this.gbxNhapThongTin.Size = new System.Drawing.Size(342, 107);
            this.gbxNhapThongTin.TabIndex = 8;
            this.gbxNhapThongTin.TabStop = false;
            this.gbxNhapThongTin.Text = "Nhap thong tin hoc vien";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 3;
            // 
            // txtTenHocVien
            // 
            this.txtTenHocVien.Location = new System.Drawing.Point(148, 28);
            this.txtTenHocVien.Name = "txtTenHocVien";
            this.txtTenHocVien.Size = new System.Drawing.Size(148, 20);
            this.txtTenHocVien.TabIndex = 2;
            // 
            // soDienThoaiHV
            // 
            this.soDienThoaiHV.AutoSize = true;
            this.soDienThoaiHV.Location = new System.Drawing.Point(44, 62);
            this.soDienThoaiHV.Name = "soDienThoaiHV";
            this.soDienThoaiHV.Size = new System.Drawing.Size(73, 13);
            this.soDienThoaiHV.TabIndex = 1;
            this.soDienThoaiHV.Text = "Số điện thoại:";
            // 
            // tenHocVien
            // 
            this.tenHocVien.AutoSize = true;
            this.tenHocVien.Location = new System.Drawing.Point(44, 28);
            this.tenHocVien.Name = "tenHocVien";
            this.tenHocVien.Size = new System.Drawing.Size(76, 13);
            this.tenHocVien.TabIndex = 0;
            this.tenHocVien.Text = "Tên học viên: ";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(72, 367);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(219, 367);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Location = new System.Drawing.Point(69, 338);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(35, 13);
            this.lbThongBao.TabIndex = 11;
            this.lbThongBao.Text = "label3";
            // 
            // frmDangKyHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 402);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.gbxNhapThongTin);
            this.Controls.Add(this.gbxNhapMa);
            this.Controls.Add(this.checkBoxFlag);
            this.Controls.Add(this.cbxLopMo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maLopMo);
            this.Name = "frmDangKyHoc";
            this.Text = "DangKyHoc";
            this.gbxNhapMa.ResumeLayout(false);
            this.gbxNhapMa.PerformLayout();
            this.gbxNhapThongTin.ResumeLayout(false);
            this.gbxNhapThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maLopMo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLopMo;
        private System.Windows.Forms.CheckBox checkBoxFlag;
        private System.Windows.Forms.GroupBox gbxNhapMa;
        private System.Windows.Forms.TextBox txtMaHocVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxNhapThongTin;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTenHocVien;
        private System.Windows.Forms.Label soDienThoaiHV;
        private System.Windows.Forms.Label tenHocVien;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbThongBao;
    }
}