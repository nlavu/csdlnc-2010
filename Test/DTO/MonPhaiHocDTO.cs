using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class MonPhaiHocDTO
    {
        #region Attributes
        private string _maMonHoc;
        private string _maLop;
        private string _maNhom;
        #endregion

        #region Default Constructor
        public MonPhaiHocDTO()
        {
            _maMonHoc = string.Empty;
            _maLop = string.Empty;
            _maNhom = string.Empty;
        }
        #endregion

        #region Properties
        public string maMonHoc
        {
            get { return _maMonHoc; }
            set { _maMonHoc = value; }
        }
        public string maLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }
        public string maNhom
        {
            get { return _maNhom; }
            set { _maNhom = value; }
        }
        #endregion
    }
}
