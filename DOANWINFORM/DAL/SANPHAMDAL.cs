using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINFORM.DAL
{
    public class SANPHAMDAL
    {
        //=========== Thêm sản phẩm ==========
        public static void AddNewSP(string MaSP, string TenSP, string DVTinh, int DonGia, string MaLoai)
        {
            QLBHDataContext data = new QLBHDataContext();
            SanPham sp = new SanPham();
            sp.MaSP = MaSP;
            sp.TenSP = TenSP;
            sp.DVTinh = DVTinh;
            sp.DonGia = DonGia;
            sp.MaLoai = MaLoai;
            sp.TrangThai = true;

            data.SanPhams.InsertOnSubmit(sp);
            data.SubmitChanges();
        }
        //======= Xóa sản phẩm ==========
        public static void DeleteSelectSP(string MaSP)
        {
            QLBHDataContext data = new QLBHDataContext();
            SanPham sp = (from sanPham in data.SanPhams
                          where sanPham.MaSP == MaSP.Trim()
                          select sanPham).Single<SanPham>();
            sp.TrangThai = false;
            data.SubmitChanges();

        }
        //====== Sửa sản phẩm ===========
        public static void EditSelectSP(string MaSP, string TenSP, string DVTinh, int DonGia, string MaLoai)
        {
            QLBHDataContext data = new QLBHDataContext();
            SanPham sp = (from SanPham in data.SanPhams
                          where SanPham.MaSP == MaSP.Trim()
                          select SanPham).SingleOrDefault<SanPham>();
            sp.MaSP = MaSP;
            sp.TenSP = TenSP;
            sp.DVTinh = DVTinh;
            sp.DonGia = DonGia;
            sp.MaLoai = MaLoai;
            sp.TrangThai = true;
            data.SubmitChanges();
        }
        
    }
}
