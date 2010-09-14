using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    [Serializable]
    public class CaHocDTO
    {
        #region Attributes
        private int _maCaHoc;
        private string _gioHoc;
        private int _thoiGianHoc;
        #endregion

        #region Default Constructor
        public CaHocDTO()
        {
            _maCaHoc = 0;
            _gioHoc = string.Empty;
            _thoiGianHoc = 0;
        }
        #endregion

        #region Properties
        public int maCaHoc
        {
            get { return _maCaHoc; }
            set { _maCaHoc = value; }
        }
        public string gioHoc
        {
            get { return _gioHoc; }
            set { _gioHoc = value; }
        }
        public int thoiGianHoc
        {
            get { return _thoiGianHoc; }
            set { _thoiGianHoc = value; }
        }
        #endregion
    }
}
