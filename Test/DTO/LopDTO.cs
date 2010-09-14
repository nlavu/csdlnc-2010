using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LopDTO
    {
        #region Attributes
        private string _maLop;
        private string _tenLop;
        private float _hocPhi;
        private string _chungChi;
        #endregion

        #region Default Constructor
        public LopDTO()
        {
            _maLop = string.Empty;
            _tenLop = string.Empty;
            _hocPhi = 0;
            _chungChi = string.Empty;
        }
        #endregion

        #region Properties
        public string maLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }
        public string tenLop
        {
            get { return _tenLop; }
            set { _tenLop = value; }
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
        #endregion
    }
}
