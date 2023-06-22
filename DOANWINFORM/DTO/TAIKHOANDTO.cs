using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINFORM.DTO
{
    public class TAIKHOANDTO
    {
        private string _MaNV;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _MaCV;
        public string MaCV
        {
            get { return _MaCV; }
            set { _MaCV = value; }
        }

        private string _TenNV;
        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }

        private string _account;
        public string account
        {
            get { return _account; }
            set { _account = value; }
        }

        public TAIKHOANDTO(string taiKhoan)
        {
            account = taiKhoan;
        }

        private string _MatKhau;
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        private bool _TrangThai;
        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }


        public TAIKHOANDTO(string MaNV_, string MaCV_, string TenNV_, string account_, string MatKhau_, bool TrangThai_)
        {
            this.MaNV = MaNV_;
            this.MaCV = MaCV_;
            this.TenNV = TenNV_;
            this.account = account_;
            this.MatKhau = MatKhau_;
            this.TrangThai = TrangThai_;
        }

    }
}
