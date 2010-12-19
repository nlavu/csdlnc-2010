using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThiSinhDTO
    {
        #region Attributes

        private String _maThiSinh;
        private String _tenThiSinh;
        private String _soDienThoaiTS;

        #endregion

        #region Properties

        public String maThiSinh { get { return _maThiSinh; } set { _maThiSinh = value; } }
        public String tenThiSinh { get { return _tenThiSinh; } set { _tenThiSinh = value; } }
        public String soDienThoaiTS { get { return _soDienThoaiTS; } set { _soDienThoaiTS = value; } }

        #endregion

        #region Default Constructor
        public ThiSinhDTO()
        {
            _maThiSinh = String.Empty;
            _tenThiSinh = String.Empty;
            _soDienThoaiTS = String.Empty;
        }
        #endregion
    }
}
