using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhomDTO
    {
        #region Attributes
        private string _maLop;
        private int _maNhom;
        private string _tenNhom;
        private float _hocPhi;
        private string _chungChi;
        private string _thi;
        #endregion

        #region Default Constructor
        public NhomDTO()
        {
            _maLop = string.Empty;
            _maNhom = 0;
            _tenNhom = string.Empty;
            _hocPhi = 0;
            _chungChi = string.Empty;
            _thi = string.Empty;
        }
        #endregion

        #region Properties
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
        public string tenNhom
        {
            get { return _tenNhom; }
            set { _tenNhom = value; }
        }
        public float hocPhi
        {
            get { return _hocPhi; }
            set { _hocPhi = value; }
        }
        public string chungChi
        {
            get { return _chungChi; }
            set { _chungChi = value; }
        }

        public string thi
        {
            get { return _thi; }
            set { _thi = value; }
        }

        #endregion
    }
}
