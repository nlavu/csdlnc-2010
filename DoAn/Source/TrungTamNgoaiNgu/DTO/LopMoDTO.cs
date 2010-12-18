using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class LopMoDTO
    {
        #region Attributes

        private String _maLopMo;
        private String _ngayBatDau;
        private String _ngayKetThuc;
        private int _siSo;
        private int _giamGia;
        private String _isDuNguoi;
        private String _maLop;
        private String _maPhongHoc;
        private String _maCaHoc;

        #endregion
     
        #region Properties
       
        public String maLopMo
        {
          get { return _maLopMo; }
          set { _maLopMo = value; }
        }
            
        public String ngayBatDau
        {
          get { return _ngayBatDau; }
          set { _ngayBatDau = value; }
        }
            
        public String ngayKetThuc
        {
          get { return _ngayKetThuc; }
         
            set { _ngayKetThuc = value; }
        }
         
        public int siSo
        {
          get { return _siSo; }
          set { _siSo = value; }
        }
         
        public int giamGia
        {
          get { return _giamGia; }
          set { _giamGia = value; }
        }

        public String isDuNguoi
        {
            get { return _isDuNguoi; }
            set { _isDuNguoi = value; }
        }
       
        public String maLop
        {
          get { return _maLop; }
          set { _maLop = value; }
        }

        public String maPhongHoc
        {
          get { return _maPhongHoc; }
          set { _maPhongHoc = value; }
        }
   

        public String maCaHoc
        {
          get { return _maCaHoc; }
          set { _maCaHoc = value; }
        }

        
        #endregion

        #region Default Constructor
        public LopMoDTO()
        {
            _maLopMo = String.Empty;
            _ngayBatDau = String.Empty;
            _ngayKetThuc = String.Empty;
            _siSo = 0;
            _giamGia = 0;
            _isDuNguoi = String.Empty;
            _maLop = String.Empty;
            _maPhongHoc = String.Empty;
            _maCaHoc = String.Empty;
        }
        #endregion

    }

}
