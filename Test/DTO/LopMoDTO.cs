using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LopMoDTO
    {
        #region Attributes
        private string _maLopMo;
        private string _maLop;
        private string _phongHoc;
        private int _maNgayHoc;
        private int _maCaHoc;
        private DateTime _ngayBatDau;
        private DateTime _ngayKetThuc;
        private int _siSo;
        #endregion

        #region Default Constructor
        public LopMoDTO()
        {
            _maLopMo = string.Empty;
            _maLop = string.Empty;
            _phongHoc = string.Empty;
            _maNgayHoc = 0;
            _maCaHoc = 0;
            _ngayBatDau = DateTime.MinValue;
            _ngayKetThuc = DateTime.MinValue;
            _siSo = 0;
        }
        #endregion

        #region Properties
        public string maLopMo
        {
            get { return _maLopMo; }
            set { _maLopMo = value; }
        }
        public string maLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }
        public string phongHoc
        {
            get { return _phongHoc; }
            set { _phongHoc = value; }
        }
        public int maNgayHoc
        {
            get { return _maNgayHoc; }
            set { _maNgayHoc = value; }
        }
        public int maCaHoc
        {
            get { return _maCaHoc; }
            set { _maCaHoc = value; }
        }
        public DateTime ngayBatDau
        {
            get { return _ngayBatDau; }
            set { _ngayBatDau = value; }
        }
        public DateTime ngayKetThuc
        {
            get { return _ngayKetThuc; }
            set { _ngayKetThuc = value; }
        }
        public int siSo
        {
            get { return _siSo; }
            set { _siSo = value; }
        }
        #endregion
    }
}
