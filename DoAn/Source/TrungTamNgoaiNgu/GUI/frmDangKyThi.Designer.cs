namespace GUI
{
    partial class frmDangKyThi
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
            this.cbMakythi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenTS = new System.Windows.Forms.Label();
            this.btdangky = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.lbTest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(175, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "ĐĂNG KÝ THI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kỳ thi";
            // 
            // cbMakythi
            // 
            this.cbMakythi.FormattingEnabled = true;
            this.cbMakythi.Location = new System.Drawing.Point(165, 64);
            this.cbMakythi.Name = "cbMakythi";
            this.cbMakythi.Size = new System.Drawing.Size(199, 21);
            this.cbMakythi.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbTenTS);
            this.groupBox1.Location = new System.Drawing.Point(78, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 98);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN THÍ SINH";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(85, 66);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(199, 20);
            this.txtSoDT.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(86, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số DT";
            // 
            // lbTenTS
            // 
            this.lbTenTS.AutoSize = true;
            this.lbTenTS.Location = new System.Drawing.Point(17, 32);
            this.lbTenTS.Name = "lbTenTS";
            this.lbTenTS.Size = new System.Drawing.Size(46, 13);
            this.lbTenTS.TabIndex = 0;
            this.lbTenTS.Text = "Họ Tên ";
            // 
            // btdangky
            // 
            this.btdangky.Location = new System.Drawing.Point(127, 282);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(97, 27);
            this.btdangky.TabIndex = 8;
            this.btdangky.Text = "ĐĂNG KÝ";
            this.btdangky.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(310, 283);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(107, 26);
            this.btthoat.TabIndex = 9;
            this.btthoat.Text = "THOÁT";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(120, 240);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(13, 13);
            this.lbTest.TabIndex = 10;
            this.lbTest.Text = "  ";
            // 
            // frmDangKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 346);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btdangky);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMakythi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangKyThi";
            this.Text = "DangKyThi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMakythi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTenTS;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label lbTest;


    }
}