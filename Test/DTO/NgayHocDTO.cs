using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NgayHocDTO
    {
        #region Attributes
        private int _maNgayHoc;
        private string _ngayHoc;
        #endregion

        #region Default Constructor
        public NgayHocDTO()
        {
            _maNgayHoc = 0;
            _ngayHoc = string.Empty;
        }
        #endregion

        #region Properties
        public int maNgayHoc
        {
            get { return _maNgayHoc; }
            set { _maNgayHoc = value; }
        }
        public string ngayHoc
        {
            get { return _ngayHoc; }
            set { _ngayHoc = value; }
        }
        #endregion
    }
}
