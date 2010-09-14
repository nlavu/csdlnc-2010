namespace GUI
{
    partial class frmStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentInfo));
            this.txtTenHocVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grPremium = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.grClassInfo = new System.Windows.Forms.GroupBox();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbTenHocVien = new System.Windows.Forms.Label();
            this.lbMaHocVien = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.tb_DT = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.tb_MaHV = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.lbDangKyTaiKhoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.grPremium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).BeginInit();
            this.grClassInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenHocVien
            // 
            this.txtTenHocVien.Location = new System.Drawing.Point(161, 71);
            this.txtTenHocVien.Name = "txtTenHocVien";
            this.txtTenHocVien.Size = new System.Drawing.Size(280, 23);
            this.txtTenHocVien.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên học viên : ";
            // 
            // grPremium
            // 
            this.grPremium.Controls.Add(this.dtgvDanhSach);
            this.grPremium.Location = new System.Drawing.Point(15, 112);
            this.grPremium.Name = "grPremium";
            this.grPremium.Size = new System.Drawing.Size(682, 169);
            this.grPremium.TabIndex = 21;
            this.grPremium.TabStop = false;
            this.grPremium.Text = "Danh sách học viên";
            // 
            // dtgvDanhSach
            // 
            this.dtgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSach.Location = new System.Drawing.Point(11, 21);
            this.dtgvDanhSach.Name = "dtgvDanhSach";
            this.dtgvDanhSach.Size = new System.Drawing.Size(660, 142);
            this.dtgvDanhSach.TabIndex = 7;
            this.dtgvDanhSach.SelectionChanged += new System.EventHandler(this.dtgvDanhSach_SelectionChanged);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(420, 415);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 25);
            this.btnTroVe.TabIndex = 20;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // grClassInfo
            // 
            this.grClassInfo.Controls.Add(this.lbCMND);
            this.grClassInfo.Controls.Add(this.label2);
            this.grClassInfo.Controls.Add(this.lbDienThoai);
            this.grClassInfo.Controls.Add(this.lbDiaChi);
            this.grClassInfo.Controls.Add(this.lbNgaySinh);
            this.grClassInfo.Controls.Add(this.lbTenHocVien);
            this.grClassInfo.Controls.Add(this.lbMaHocVien);
            this.grClassInfo.Controls.Add(this.lbTime);
            this.grClassInfo.Controls.Add(this.lbRoom);
            this.grClassInfo.Controls.Add(this.tb_DT);
            this.grClassInfo.Controls.Add(this.lbStartDate);
            this.grClassInfo.Controls.Add(this.tb_MaHV);
            this.grClassInfo.Location = new System.Drawing.Point(17, 287);
            this.grClassInfo.Name = "grClassInfo";
            this.grClassInfo.Size = new System.Drawing.Size(680, 119);
            this.grClassInfo.TabIndex = 18;
            this.grClassInfo.TabStop = false;
            this.grClassInfo.Text = "Thông tin học viên";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(439, 84);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(0, 17);
            this.lbDienThoai.TabIndex = 12;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(439, 29);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(0, 17);
            this.lbDiaChi.TabIndex = 12;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(439, 56);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(0, 17);
            this.lbNgaySinh.TabIndex = 12;
            // 
            // lbTenHocVien
            // 
            this.lbTenHocVien.AutoSize = true;
            this.lbTenHocVien.Location = new System.Drawing.Point(136, 56);
            this.lbTenHocVien.Name = "lbTenHocVien";
            this.lbTenHocVien.Size = new System.Drawing.Size(0, 17);
            this.lbTenHocVien.TabIndex = 11;
            // 
            // lbMaHocVien
            // 
            this.lbMaHocVien.AutoSize = true;
            this.lbMaHocVien.Location = new System.Drawing.Point(136, 29);
            this.lbMaHocVien.Name = "lbMaHocVien";
            this.lbMaHocVien.Size = new System.Drawing.Size(0, 17);
            this.lbMaHocVien.TabIndex = 10;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(346, 56);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(73, 17);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Ngày Sinh";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(21, 56);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(102, 17);
            this.lbRoom.TabIndex = 3;
            this.lbRoom.Text = "Tên Học Viên :";
            // 
            // tb_DT
            // 
            this.tb_DT.AutoSize = true;
            this.tb_DT.Location = new System.Drawing.Point(346, 84);
            this.tb_DT.Name = "tb_DT";
            this.tb_DT.Size = new System.Drawing.Size(85, 17);
            this.tb_DT.TabIndex = 2;
            this.tb_DT.Text = "Điện Thoại :";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(346, 29);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(61, 17);
            this.lbStartDate.TabIndex = 1;
            this.lbStartDate.Text = "Địa Chỉ :";
            // 
            // tb_MaHV
            // 
            this.tb_MaHV.AutoSize = true;
            this.tb_MaHV.Location = new System.Drawing.Point(21, 29);
            this.tb_MaHV.Name = "tb_MaHV";
            this.tb_MaHV.Size = new System.Drawing.Size(96, 17);
            this.tb_MaHV.TabIndex = 0;
            this.tb_MaHV.Text = "Mã Học Viên :";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(509, 70);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 25);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lbDangKyTaiKhoan
            // 
            this.lbDangKyTaiKhoan.AutoSize = true;
            this.lbDangKyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangKyTaiKhoan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDangKyTaiKhoan.Location = new System.Drawing.Point(232, 18);
            this.lbDangKyTaiKhoan.Name = "lbDangKyTaiKhoan";
            this.lbDangKyTaiKhoan.Size = new System.Drawing.Size(185, 24);
            this.lbDangKyTaiKhoan.TabIndex = 24;
            this.lbDangKyTaiKhoan.Text = "Thông tin học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "CMND:";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(136, 84);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(0, 17);
            this.lbCMND.TabIndex = 14;
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 452);
            this.Controls.Add(this.lbDangKyTaiKhoan);
            this.Controls.Add(this.txtTenHocVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grPremium);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.grClassInfo);
            this.Controls.Add(this.btnTim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudentInfo";
            this.Text = "Thông tin học viên";
            this.grPremium.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).EndInit();
            this.grClassInfo.ResumeLayout(false);
            this.grClassInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenHocVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grPremium;
        private System.Windows.Forms.DataGridView dtgvDanhSach;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.GroupBox grClassInfo;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbTenHocVien;
        private System.Windows.Forms.Label lbMaHocVien;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label tb_DT;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label tb_MaHV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lbDangKyTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCMND;
    }
}