using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HocVienDTO
    {
        #region Attributes

        private String _maHocVien;
        private String _tenHocVien;
        private String _soDienThoaiHV;

        #endregion

        #region Properties

        public String maHocVien { get { return _maHocVien; } set { _maHocVien = value; } }
        public String tenHocVien { get { return _tenHocVien; } set { _tenHocVien = value; } }
        public String soDienThoaiHV { get { return _soDienThoaiHV; } set { _soDienThoaiHV = value; } }

        #endregion

        #region Default Constructor
        public HocVienDTO()
        {
            _maHocVien = String.Empty;
            _tenHocVien = String.Empty;
            _soDienThoaiHV = String.Empty;
        }
        #endregion
    }
}
