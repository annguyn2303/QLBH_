using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINFORM.DTO
{
    public class SANPHAMDTO
    {
        private string _MaSP;
        public string MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        private string _TenSP;
        public string TenSP
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }

        private string _DVTinh;
        public string DVTinh
        {
            get { return _DVTinh; }
            set { _DVTinh = value; }
        }

        private int _DonGia;
        public int DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

        private string _MaLoai;
        public string MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }

        private bool _TrangThai;
        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }


        public SANPHAMDTO(string MaSP_, string TenSP_, string DVTinh_, int DonGia_, string MaLoai_, bool TrangThai_)
        {
            this.MaSP = MaSP_;
            this.TenSP = TenSP_;
            this.DVTinh = DVTinh_;
            this.DonGia = DonGia_;
            this.MaLoai = MaLoai_;
            this.TrangThai = TrangThai_;
        }

    }
}
