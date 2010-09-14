using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KetQuaNhomDTO
    {
        #region Attributes
        private string _maHocVien;
        private string _maLopMo;
        private string _maLop;
        private int _maNhom;
        private string _ketQua;
        #endregion

        #region Default Constructor
        public KetQuaNhomDTO()
        {
            _maHocVien = string.Empty;
            _maLopMo = string.Empty;
            _maLop = string.Empty;
            _maNhom = 0;
            _ketQua = string.Empty;
        }
        #endregion

        #region Properties
        public string maHocVien
        {
            get { return _maHocVien; }
            set { _maHocVien = value; }
        }
        public string maLopMo
        {
            get { return _maLopMo; }
            set { _maLopMo = value; }
        }
        public string maLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }
        public int maNhom
        {
            get { return _maNhom; }
            set { _maNhom = value; }
        }
        public string ketQua
        {
            get { return _ketQua; }
            set { _ketQua = value; }
        }
        #endregion
    }
}
