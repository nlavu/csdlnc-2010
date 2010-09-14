using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HocVienDTO
    {
        #region Attributes
        private string _maHocVien;
        private string _tenHocVien;
        private DateTime _ngaySinh;
        private string _diaChi;
        private string _dienThoai;
        private string _CMND;


        #endregion

        #region Default Constructor
        public HocVienDTO()
        {
            _maHocVien = string.Empty;
            _tenHocVien = string.Empty;
            _ngaySinh = DateTime.MinValue;
            _diaChi = string.Empty;
            _dienThoai = string.Empty;
            _CMND = string.Empty;
        }
        #endregion

        #region Properties
        public string maHocVien
        {
            get { return _maHocVien; }
            set { _maHocVien = value; }
        }
        public string tenHocVien
        {
            get { return _tenHocVien; }
            set { _tenHocVien = value; }
        }
        public DateTime ngaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        public string diaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        public string dienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }
        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }
        #endregion
    }
}
