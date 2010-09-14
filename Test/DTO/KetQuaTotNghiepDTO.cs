using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KetQuaTotNghiepDTO
    {
        #region Attributes
        private int _maTotNghiep;
        private string _maLopMo;
        private string _maHocVien;
        private float _diemTotNghiep;
        private string _ketQua;
        #endregion

        #region Default Constructor
        public KetQuaTotNghiepDTO()
        {
            _maTotNghiep = 0;
            _maLopMo = string.Empty;
            _maHocVien = string.Empty;
            _diemTotNghiep = 0;
            _ketQua = string.Empty;
        }
        #endregion

        #region Properties
        public int maTotNghiep
        {
            get { return _maTotNghiep; }
            set { _maTotNghiep = value; }
        }
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
        public float diemTotNghiep
        {
            get { return _diemTotNghiep; }
            set { _diemTotNghiep = value; }
        }
        public string ketQua
        {
            get { return _ketQua; }
            set { _ketQua = value; }
        }
        #endregion
    }
}
