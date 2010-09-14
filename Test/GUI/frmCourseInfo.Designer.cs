namespace GUI
{
    partial class frmCourseInfo
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
            this.lbDangKyTaiKhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtgvThongTin = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDangKyTaiKhoan
            // 
            this.lbDangKyTaiKhoan.AutoSize = true;
            this.lbDangKyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangKyTaiKhoan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDangKyTaiKhoan.Location = new System.Drawing.Point(188, 19);
            this.lbDangKyTaiKhoan.Name = "lbDangKyTaiKhoan";
            this.lbDangKyTaiKhoan.Size = new System.Drawing.Size(191, 24);
            this.lbDangKyTaiKhoan.TabIndex = 8;
            this.lbDangKyTaiKhoan.Text = "Thông tin khóa học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chương trình";
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(192, 71);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(190, 21);
            this.cbCourse.TabIndex = 10;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(433, 69);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(93, 23);
            this.btnXem.TabIndex = 11;
            this.btnXem.Text = "Xem thông tin";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtgvThongTin
            // 
            this.dtgvThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maLopMo,
            this.phongHoc,
            this.ngayHoc,
            this.gioHoc,
            this.ngayBatDau,
            this.ngayKetThuc,
            this.siSo});
            this.dtgvThongTin.Location = new System.Drawing.Point(19, 115);
            this.dtgvThongTin.Name = "dtgvThongTin";
            this.dtgvThongTin.Size = new System.Drawing.Size(547, 215);
            this.dtgvThongTin.TabIndex = 12;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // maLopMo
            // 
            this.maLopMo.HeaderText = "Lớp";
            this.maLopMo.Name = "maLopMo";
            // 
            // phongHoc
            // 
            this.phongHoc.HeaderText = "Phòng học";
            this.phongHoc.Name = "phongHoc";
            // 
            // ngayHoc
            // 
            this.ngayHoc.HeaderText = "Ngày học";
            this.ngayHoc.Name = "ngayHoc";
            this.ngayHoc.Width = 80;
            // 
            // gioHoc
            // 
            this.gioHoc.HeaderText = "Giờ học";
            this.gioHoc.Name = "gioHoc";
            this.gioHoc.Width = 70;
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.ngayBatDau.Name = "ngayBatDau";
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.HeaderText = "Ngày kết thúc";
            this.ngayKetThuc.Name = "ngayKetThuc";
            // 
            // siSo
            // 
            this.siSo.HeaderText = "Sỉ số";
            this.siSo.Name = "siSo";
            this.siSo.Width = 60;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(367, 336);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 13;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // frmCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 366);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dtgvThongTin);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDangKyTaiKhoan);
            this.Name = "frmCourseInfo";
            this.Text = "frmCourseInfo";
            this.Load += new System.EventHandler(this.frmCourseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDangKyTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dtgvThongTin;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSo;
    }
}