using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;

namespace GUI
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

            //Bitmap bgImg = (Bitmap)Image.FromFile("mainForm.jpg");
            //GUI.Properties.Resources.mainForm
            //this.BackgroundImage = bgImg;
            //Bitmap bm = new Bitmap("mainForm_2.jpg");
            //this.BackgroundImage = bm;

            lbSummaryOfCourse.Visible = true;
            lbRegister.Visible = true;

            lbClassInfo.Visible = false;
            //lbClassManagement.Visible = false;

            lbStudentInfo.Visible = false;
            //lbStudentManagement.Visible = false;

            lbSearchClass.Visible = false;
            lbSearchStudent.Visible = false;
            lbSearchMark.Visible = false;

            lbSupport.Visible = false;
            lbAbout.Visible = false;
        }

        // Xử lý cho menu Ghi danh
        private void lbRegisterMenu_MouseEnter(object sender, EventArgs e)
        {
            // invisible
            lbClassInfo.Visible = false;
            //lbClassManagement.Visible = false;

            lbStudentInfo.Visible = false;
            //lbStudentManagement.Visible = false;

            lbSearchClass.Visible = false;
            lbSearchStudent.Visible = false;
            lbSearchMark.Visible = false;

            lbSupport.Visible = false;
            lbAbout.Visible = false; 

            // bold text
            lbRegisterMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

            // show menu items
            lbSummaryOfCourse.Visible = true;
            lbRegister.Visible = true;

            
        }

        private void lbRegisterMenu_MouseLeave(object sender, EventArgs e)
        {
            lbRegisterMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        // Xử lý cho menu Lớp học
        private void lbClassMenu_MouseEnter(object sender, EventArgs e)
        {
            // invisible other text
            lbSummaryOfCourse.Visible = false;
            lbRegister.Visible = false;

            lbStudentInfo.Visible = false;
            //lbStudentManagement.Visible = false;

            lbSearchClass.Visible = false;
            lbSearchStudent.Visible = false;
            lbSearchMark.Visible = false;

            lbSupport.Visible = false;
            lbAbout.Visible = false;

            // bold text
            lbClassMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

            // visible
            lbClassInfo.Visible = true;
            //lbClassManagement.Visible = true;

        }

        private void lbClassMenu_MouseLeave(object sender, EventArgs e)
        {
            lbClassMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        // Xử lý cho menu Học viên
        private void lbStudentMenu_MouseEnter(object sender, EventArgs e)
        {
            // invisible other menu items
            lbSummaryOfCourse.Visible = false;
            lbRegister.Visible = false;

            lbClassInfo.Visible = false;
            //lbClassManagement.Visible = false;

            lbSearchClass.Visible = false;
            lbSearchStudent.Visible = false;
            lbSearchMark.Visible = false;

            lbSupport.Visible = false;
            lbAbout.Visible = false;
  
            // bold text
            lbStudentMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

            // show menu items
            lbStudentInfo.Visible = true;
            //lbStudentManagement.Visible = true;
        }

        private void lbStudentMenu_MouseLeave(object sender, EventArgs e)
        {
            lbStudentMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        // Xử lý cho menu Tra cứu
        private void lbSearchMenu_MouseEnter(object sender, EventArgs e)
        {
            // invisible other menu items
            lbSummaryOfCourse.Visible = false;
            lbRegister.Visible = false;

            lbClassInfo.Visible = false;
            //lbClassManagement.Visible = false;

            lbStudentInfo.Visible = false;
            //lbStudentManagement.Visible = false;

            lbSupport.Visible = false;
            lbAbout.Visible = false;

            // bold text
            lbSearchMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

            // show menu items
            lbSearchClass.Visible = true;
            lbSearchStudent.Visible = true;
            lbSearchMark.Visible = true;
        }

        private void lbSearchMenu_MouseLeave(object sender, EventArgs e)
        {
            lbSearchMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        // Xử lý cho menu Trợ giúp
        private void lbHelpMenu_MouseEnter(object sender, EventArgs e)
        {
            // invisible other menu items
            lbSummaryOfCourse.Visible = false;
            lbRegister.Visible = false;

            lbClassInfo.Visible = false;
            //lbClassManagement.Visible = false;

            lbStudentInfo.Visible = false;
            //lbStudentManagement.Visible = false;

            lbSearchClass.Visible = false;
            lbSearchStudent.Visible = false;
            lbSearchMark.Visible = false;

            // bold text
            lbHelpMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

            // show menu items
            lbSupport.Visible = true;
            lbAbout.Visible = true;
        }

        private void lbHelpMenu_MouseLeave(object sender, EventArgs e)
        {
            lbHelpMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        // Xừ lý cho menu Thoát
        private void lbExitMenu_MouseEnter(object sender, EventArgs e)
        {
            lbExitMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

            // invisible other menu items
            lbSummaryOfCourse.Visible = false;
            lbRegister.Visible = false;

            lbClassInfo.Visible = false;
            //lbClassManagement.Visible = false;

            lbStudentInfo.Visible = false;
            //lbStudentManagement.Visible = false;

            lbSearchClass.Visible = false;
            lbSearchStudent.Visible = false;
            lbSearchMark.Visible = false;

            lbSupport.Visible = false;
            lbAbout.Visible = false;
        }

        private void lbExitMenu_MouseLeave(object sender, EventArgs e)
        {
            lbExitMenu.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        // Click menu Thoát
        private void lbExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            this.DestroyHandle();
            Application.Exit();
        }

        // Thông tin các khóa học
        private void lbSummaryOfCourse_Click(object sender, EventArgs e)
        {
            frmCourseInfo formCourseInfo = new frmCourseInfo();
            formCourseInfo.Show();
        }

        // Ghi danh
        private void lbRegister_Click(object sender, EventArgs e)
        {
            frmRegister formRegister = new frmRegister();
            formRegister.Show();
        }

        // Thông tin lớp học
        private void lbClassInfo_Click(object sender, EventArgs e)
        {
            frmClassInfo formClassInfo = new frmClassInfo();
            formClassInfo.Show();
        }

        // Thông tin học viên
        private void lbStudentInfo_Click(object sender, EventArgs e)
        {
            frmStudentInfo formStudentInfo = new frmStudentInfo();
            formStudentInfo.Show();
        }

        // Tra cứu lớp học
        private void lbSearchClass_Click(object sender, EventArgs e)
        {
            frmClassInfo formClassInfo = new frmClassInfo();
            formClassInfo.Show();
        }

        // Tra cứu học viên
        private void lbSearchStudent_Click(object sender, EventArgs e)
        {
            frmStudentInfo formStudentInfo = new frmStudentInfo();
            formStudentInfo.Show();
        }

        // Tra cứu điểm thi
        private void lbSearchMark_Click(object sender, EventArgs e)
        {
            frmSearchMark formSearchMark = new frmSearchMark();
            formSearchMark.Show();
        }

        // Help
        private void lbSupport_Click(object sender, EventArgs e)
        {

        }

        // About
        private void lbAbout_Click(object sender, EventArgs e)
        {
            frmAbout formAbout = new frmAbout();
            formAbout.Show();
        }

        // Hàm xử lý khi form đóng lại
        // Xóa cache (dispose)
        // kill process
        private void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.DestroyHandle();
            Application.Exit();
        }

        
    }
}
