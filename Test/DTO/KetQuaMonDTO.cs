using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KetQuaMonDTO
    {
        #region Attributes
        private string _maHocVien;
        private string _maLopMo;
        private string _maMonHoc;
        private int _lanThi;
        private float _diem;
        #endregion

        #region Default Constructor
        public KetQuaMonDTO()
        {
            _maHocVien = string.Empty;
            _maLopMo = string.Empty;
            _maMonHoc = string.Empty;
            _lanThi = 0;
            _diem = 0;
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
        public string maMonHoc
        {
            get { return _maMonHoc; }
            set { _maMonHoc = value; }
        }
        public int lanThi
        {
            get { return _lanThi; }
            set { _lanThi = value; }
        }
        public float diem
        {
            get { return _diem; }
            set { _diem = value; }
        }
        #endregion
    }
}
