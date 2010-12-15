using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        #region Attributes

        private String _maNhanVien;
        private String _hoTen;
        private String _diaChi;
        private String _soDienThoai;
        private String _username;
        private String _password;
        private String _maChucVu;

        #endregion

        #region Properties

        public String maNhanVien { get { return _maNhanVien; } set { _maNhanVien = value; } }
        public String hoTen { get { return _hoTen; } set { _hoTen = value; } }
        public String diaChi { get { return _diaChi; } set { _diaChi = value; } }
        public String soDienThoai { get { return _soDienThoai; } set { _soDienThoai = value; } }
        public String username { get { return _username; } set { _username = value; } }
        public String password { get { return _password; } set { _password = value; } }
        public String maChucVu { get { return _maChucVu; } set { _maChucVu = value; } }

        #endregion

        #region Default Constructor
        public NhanVienDTO()
        {
            _maNhanVien = String.Empty;
            _hoTen = String.Empty;
            _diaChi = String.Empty;
            _soDienThoai = String.Empty;
            _username = String.Empty;
            _password = String.Empty;
            _maChucVu = String.Empty;
        }
        #endregion

    }
}
