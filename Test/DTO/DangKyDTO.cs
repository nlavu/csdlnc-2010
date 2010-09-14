using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DangKyDTO
    {
        #region Attributes
        private string _maLopMo;
        private string _maHocVien;
        private string _dongTien;
        #endregion

        #region Default Constructor
        public DangKyDTO()
        {
            _maLopMo = string.Empty;
            _maHocVien = string.Empty;
            _dongTien = string.Empty;
        }
        #endregion

        #region Properties
        public string maLopMo
        {
            get { return _maLopMo; }
            set { _maLopMo = value; }
        }
        public string maHocVien
        {
            get { return _maHocVien; }
            set { _maHocVien = value; }
        }
        public string dongTien
        {
            get { return _dongTien; }
            set { _dongTien = value; }
        }
        #endregion
    }
}
