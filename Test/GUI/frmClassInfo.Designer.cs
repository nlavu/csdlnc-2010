namespace GUI
{
    partial class frmClassInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassInfo));
            this.grClassIndentify = new System.Windows.Forms.GroupBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbCourse = new System.Windows.Forms.Label();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.grClassInfo = new System.Windows.Forms.GroupBox();
            this.lbGioHoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNgayKetThuc = new System.Windows.Forms.Label();
            this.lbNgayBatDau = new System.Windows.Forms.Label();
            this.lbNgayHoc = new System.Windows.Forms.Label();
            this.lbPhongHoc = new System.Windows.Forms.Label();
            this.lbSiSo = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbDueDate = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbNumberOfStudent = new System.Windows.Forms.Label();
            this.dtgvDanhSachHocVien = new System.Windows.Forms.DataGridView();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.lbDangKyTaiKhoan = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grClassIndentify.SuspendLayout();
            this.grClassInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocVien)).BeginInit();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // grClassIndentify
            // 
            this.grClassIndentify.Controls.Add(this.lbClass);
            this.grClassIndentify.Controls.Add(this.cbClass);
            this.grClassIndentify.Controls.Add(this.lbCourse);
            this.grClassIndentify.Controls.Add(this.cbCourse);
            this.grClassIndentify.Location = new System.Drawing.Point(12, 52);
            this.grClassIndentify.Name = "grClassIndentify";
            this.grClassIndentify.Size = new System.Drawing.Size(703, 56);
            this.grClassIndentify.TabIndex = 0;
            this.grClassIndentify.TabStop = false;
            this.grClassIndentify.Text = "Chọn lớp học";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(349, 26);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(36, 17);
            this.lbClass.TabIndex = 4;
            this.lbClass.Text = "Lớp:";
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(391, 22);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(213, 24);
            this.cbClass.TabIndex = 3;
            this.cbClass.SelectionChangeCommitted += new System.EventHandler(this.cbClass_SelectionChangeCommitted);
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(17, 26);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(72, 17);
            this.lbCourse.TabIndex = 2;
            this.lbCourse.Text = "Khóa học:";
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(98, 22);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(213, 24);
            this.cbCourse.TabIndex = 1;
            this.cbCourse.SelectionChangeCommitted += new System.EventHandler(this.cbCourse_SelectionChangeCommitted);
            // 
            // grClassInfo
            // 
            this.grClassInfo.Controls.Add(this.lbGioHoc);
            this.grClassInfo.Controls.Add(this.label2);
            this.grClassInfo.Controls.Add(this.lbNgayKetThuc);
            this.grClassInfo.Controls.Add(this.lbNgayBatDau);
            this.grClassInfo.Controls.Add(this.lbNgayHoc);
            this.grClassInfo.Controls.Add(this.lbPhongHoc);
            this.grClassInfo.Controls.Add(this.lbSiSo);
            this.grClassInfo.Controls.Add(this.lbTime);
            this.grClassInfo.Controls.Add(this.lbRoom);
            this.grClassInfo.Controls.Add(this.lbDueDate);
            this.grClassInfo.Controls.Add(this.lbStartDate);
            this.grClassInfo.Controls.Add(this.lbNumberOfStudent);
            this.grClassInfo.Location = new System.Drawing.Point(12, 112);
            this.grClassInfo.Name = "grClassInfo";
            this.grClassInfo.Size = new System.Drawing.Size(703, 131);
            this.grClassInfo.TabIndex = 1;
            this.grClassInfo.TabStop = false;
            this.grClassInfo.Text = "Thông tin lớp học";
            // 
            // lbGioHoc
            // 
            this.lbGioHoc.AutoSize = true;
            this.lbGioHoc.Location = new System.Drawing.Point(443, 56);
            this.lbGioHoc.Name = "lbGioHoc";
            this.lbGioHoc.Size = new System.Drawing.Size(0, 17);
            this.lbGioHoc.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Giờ học:";
            // 
            // lbNgayKetThuc
            // 
            this.lbNgayKetThuc.AutoSize = true;
            this.lbNgayKetThuc.Location = new System.Drawing.Point(201, 108);
            this.lbNgayKetThuc.Name = "lbNgayKetThuc";
            this.lbNgayKetThuc.Size = new System.Drawing.Size(0, 17);
            this.lbNgayKetThuc.TabIndex = 12;
            // 
            // lbNgayBatDau
            // 
            this.lbNgayBatDau.AutoSize = true;
            this.lbNgayBatDau.Location = new System.Drawing.Point(201, 80);
            this.lbNgayBatDau.Name = "lbNgayBatDau";
            this.lbNgayBatDau.Size = new System.Drawing.Size(0, 17);
            this.lbNgayBatDau.TabIndex = 12;
            // 
            // lbNgayHoc
            // 
            this.lbNgayHoc.AutoSize = true;
            this.lbNgayHoc.Location = new System.Drawing.Point(443, 29);
            this.lbNgayHoc.Name = "lbNgayHoc";
            this.lbNgayHoc.Size = new System.Drawing.Size(0, 17);
            this.lbNgayHoc.TabIndex = 12;
            // 
            // lbPhongHoc
            // 
            this.lbPhongHoc.AutoSize = true;
            this.lbPhongHoc.Location = new System.Drawing.Point(201, 56);
            this.lbPhongHoc.Name = "lbPhongHoc";
            this.lbPhongHoc.Size = new System.Drawing.Size(0, 17);
            this.lbPhongHoc.TabIndex = 11;
            // 
            // lbSiSo
            // 
            this.lbSiSo.AutoSize = true;
            this.lbSiSo.Location = new System.Drawing.Point(201, 29);
            this.lbSiSo.Name = "lbSiSo";
            this.lbSiSo.Size = new System.Drawing.Size(0, 17);
            this.lbSiSo.TabIndex = 10;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(349, 29);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(72, 17);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Ngày học:";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(21, 56);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(80, 17);
            this.lbRoom.TabIndex = 3;
            this.lbRoom.Text = "Phòng học:";
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.Location = new System.Drawing.Point(21, 109);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(161, 17);
            this.lbDueDate.TabIndex = 2;
            this.lbDueDate.Text = "Ngày kết thúc khóa học:";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(21, 82);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(159, 17);
            this.lbStartDate.TabIndex = 1;
            this.lbStartDate.Text = "Ngày bắt đầu khóa học:";
            // 
            // lbNumberOfStudent
            // 
            this.lbNumberOfStudent.AutoSize = true;
            this.lbNumberOfStudent.Location = new System.Drawing.Point(21, 29);
            this.lbNumberOfStudent.Name = "lbNumberOfStudent";
            this.lbNumberOfStudent.Size = new System.Drawing.Size(43, 17);
            this.lbNumberOfStudent.TabIndex = 0;
            this.lbNumberOfStudent.Text = "Sĩ số:";
            // 
            // dtgvDanhSachHocVien
            // 
            this.dtgvDanhSachHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHocVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.hoTen,
            this.ngaySinh,
            this.diaChi,
            this.dienThoai,
            this.CMND,
            this.dongTien});
            this.dtgvDanhSachHocVien.Location = new System.Drawing.Point(11, 22);
            this.dtgvDanhSachHocVien.Name = "dtgvDanhSachHocVien";
            this.dtgvDanhSachHocVien.Size = new System.Drawing.Size(686, 181);
            this.dtgvDanhSachHocVien.TabIndex = 7;
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.dtgvDanhSachHocVien);
            this.gbx.Location = new System.Drawing.Point(12, 250);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(703, 209);
            this.gbx.TabIndex = 8;
            this.gbx.TabStop = false;
            this.gbx.Text = "Danh sách học viên của lớp này";
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Location = new System.Drawing.Point(314, 465);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(75, 25);
            this.btnBackToHome.TabIndex = 9;
            this.btnBackToHome.Text = "Trở về";
            this.btnBackToHome.UseVisualStyleBackColor = true;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // lbDangKyTaiKhoan
            // 
            this.lbDangKyTaiKhoan.AutoSize = true;
            this.lbDangKyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangKyTaiKhoan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDangKyTaiKhoan.Location = new System.Drawing.Point(310, 25);
            this.lbDangKyTaiKhoan.Name = "lbDangKyTaiKhoan";
            this.lbDangKyTaiKhoan.Size = new System.Drawing.Size(134, 24);
            this.lbDangKyTaiKhoan.TabIndex = 10;
            this.lbDangKyTaiKhoan.Text = "Thông tin lớp";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // hoTen
            // 
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.Name = "hoTen";
            // 
            // ngaySinh
            // 
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            // 
            // diaChi
            // 
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // dienThoai
            // 
            this.dienThoai.HeaderText = "Số điện thoại";
            this.dienThoai.Name = "dienThoai";
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // dongTien
            // 
            this.dongTien.HeaderText = "Đóng tiền";
            this.dongTien.Name = "dongTien";
            // 
            // frmClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 502);
            this.Controls.Add(this.lbDangKyTaiKhoan);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.gbx);
            this.Controls.Add(this.grClassInfo);
            this.Controls.Add(this.grClassIndentify);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MaximizeBox = false;
            this.Name = "frmClassInfo";
            this.Text = "Thông tin lớp học";
            this.Load += new System.EventHandler(this.frmClassInfo_Load);
            this.grClassIndentify.ResumeLayout(false);
            this.grClassIndentify.PerformLayout();
            this.grClassInfo.ResumeLayout(false);
            this.grClassInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocVien)).EndInit();
            this.gbx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grClassIndentify;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.GroupBox grClassInfo;
        private System.Windows.Forms.Label lbDueDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbNumberOfStudent;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.DataGridView dtgvDanhSachHocVien;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.Label lbNgayKetThuc;
        private System.Windows.Forms.Label lbNgayBatDau;
        private System.Windows.Forms.Label lbNgayHoc;
        private System.Windows.Forms.Label lbPhongHoc;
        private System.Windows.Forms.Label lbSiSo;
        private System.Windows.Forms.Label lbGioHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDangKyTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongTien;
    }
}