namespace GUI
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.grRegister = new System.Windows.Forms.GroupBox();
            this.checkPremium = new System.Windows.Forms.CheckBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbPremium = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lbCMND = new System.Windows.Forms.Label();
            this.grRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // grRegister
            // 
            this.grRegister.Controls.Add(this.txtCMND);
            this.grRegister.Controls.Add(this.lbCMND);
            this.grRegister.Controls.Add(this.checkPremium);
            this.grRegister.Controls.Add(this.cbCourse);
            this.grRegister.Controls.Add(this.txtPhone);
            this.grRegister.Controls.Add(this.txtAddress);
            this.grRegister.Controls.Add(this.dtBirthday);
            this.grRegister.Controls.Add(this.txtFullName);
            this.grRegister.Controls.Add(this.lbPremium);
            this.grRegister.Controls.Add(this.lbCourse);
            this.grRegister.Controls.Add(this.lbPhone);
            this.grRegister.Controls.Add(this.lbAddress);
            this.grRegister.Controls.Add(this.lbBirthday);
            this.grRegister.Controls.Add(this.lbFullName);
            this.grRegister.Controls.Add(this.btnRegister);
            this.grRegister.Controls.Add(this.btnCancel);
            this.grRegister.Controls.Add(this.btnBackToHome);
            this.grRegister.Location = new System.Drawing.Point(13, 13);
            this.grRegister.Margin = new System.Windows.Forms.Padding(4);
            this.grRegister.Name = "grRegister";
            this.grRegister.Padding = new System.Windows.Forms.Padding(4);
            this.grRegister.Size = new System.Drawing.Size(568, 274);
            this.grRegister.TabIndex = 0;
            this.grRegister.TabStop = false;
            this.grRegister.Text = "Ghi danh";
            // 
            // checkPremium
            // 
            this.checkPremium.AutoSize = true;
            this.checkPremium.Location = new System.Drawing.Point(216, 213);
            this.checkPremium.Name = "checkPremium";
            this.checkPremium.Size = new System.Drawing.Size(15, 14);
            this.checkPremium.TabIndex = 6;
            this.checkPremium.UseVisualStyleBackColor = true;
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(216, 178);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(250, 24);
            this.cbCourse.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(216, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 23);
            this.txtPhone.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(216, 91);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(345, 23);
            this.txtAddress.TabIndex = 3;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(216, 62);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(254, 23);
            this.dtBirthday.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(216, 34);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(254, 23);
            this.txtFullName.TabIndex = 0;
            // 
            // lbPremium
            // 
            this.lbPremium.AutoSize = true;
            this.lbPremium.Location = new System.Drawing.Point(22, 214);
            this.lbPremium.Name = "lbPremium";
            this.lbPremium.Size = new System.Drawing.Size(120, 17);
            this.lbPremium.TabIndex = 9;
            this.lbPremium.Text = "Đã đóng học phí?";
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(22, 185);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(173, 17);
            this.lbCourse.TabIndex = 8;
            this.lbCourse.Text = "Có nhu cầu học khóa học:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(22, 126);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(76, 17);
            this.lbPhone.TabIndex = 7;
            this.lbPhone.Text = "Điện thoại:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(22, 94);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(55, 17);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(22, 67);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(146, 17);
            this.lbBirthday.TabIndex = 5;
            this.lbBirthday.Text = "Ngày tháng năm sinh:";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(22, 40);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(73, 17);
            this.lbFullName.TabIndex = 3;
            this.lbFullName.Text = "Họ và tên:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(405, 240);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 25);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Ghi danh";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(486, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Location = new System.Drawing.Point(324, 240);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(75, 25);
            this.btnBackToHome.TabIndex = 9;
            this.btnBackToHome.Text = "Trở về";
            this.btnBackToHome.UseVisualStyleBackColor = true;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(216, 149);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(250, 23);
            this.txtCMND.TabIndex = 10;
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(22, 155);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(52, 17);
            this.lbCMND.TabIndex = 11;
            this.lbCMND.Text = "CMND:";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 299);
            this.Controls.Add(this.grRegister);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.Text = "Ghi danh";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.grRegister.ResumeLayout(false);
            this.grRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbPremium;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.CheckBox checkPremium;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lbCMND;

    }
}