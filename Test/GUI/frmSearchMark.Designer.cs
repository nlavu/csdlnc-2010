namespace GUI
{
    partial class frmSearchMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchMark));
            this.lbDangKyTaiKhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHocVien = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDiemThi = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemThi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDangKyTaiKhoan
            // 
            this.lbDangKyTaiKhoan.AutoSize = true;
            this.lbDangKyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangKyTaiKhoan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDangKyTaiKhoan.Location = new System.Drawing.Point(281, 21);
            this.lbDangKyTaiKhoan.Name = "lbDangKyTaiKhoan";
            this.lbDangKyTaiKhoan.Size = new System.Drawing.Size(163, 24);
            this.lbDangKyTaiKhoan.TabIndex = 25;
            this.lbDangKyTaiKhoan.Text = "Tra cứu điểm thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã học viên :";
            // 
            // txtMaHocVien
            // 
            this.txtMaHocVien.Location = new System.Drawing.Point(150, 64);
            this.txtMaHocVien.Name = "txtMaHocVien";
            this.txtMaHocVien.Size = new System.Drawing.Size(240, 23);
            this.txtMaHocVien.TabIndex = 27;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(456, 64);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
            this.btnTraCuu.TabIndex = 28;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDiemThi);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 221);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điểm thi";
            // 
            // dtgvDiemThi
            // 
            this.dtgvDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiemThi.Location = new System.Drawing.Point(6, 22);
            this.dtgvDiemThi.Name = "dtgvDiemThi";
            this.dtgvDiemThi.Size = new System.Drawing.Size(666, 193);
            this.dtgvDiemThi.TabIndex = 0;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(456, 340);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 26);
            this.btnQuayLai.TabIndex = 30;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frmSearchMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 378);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.txtMaHocVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDangKyTaiKhoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSearchMark";
            this.Text = "Tra cứu kết quả học tập";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDangKyTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHocVien;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDiemThi;
        private System.Windows.Forms.Button btnQuayLai;
    }
}