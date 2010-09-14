using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class MonHocDTO
    {
        #region Attributes
        private string _maMonHoc;
        private string _tenMonHoc;
        private string _ghiChu;
        #endregion

        #region Default Constructor
        public MonHocDTO()
        {
            _maMonHoc = string.Empty;
            _tenMonHoc = string.Empty;
            _ghiChu = string.Empty;
        }
        #endregion

        #region Properties
        public string maMonHoc
        {
            get { return _maMonHoc; }
            set { _maMonHoc = value; }
        }
        public string tenMonHoc
        {
            get { return _tenMonHoc; }
            set { _tenMonHoc = value; }
        }
        public string ghiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        #endregion
    }
}
