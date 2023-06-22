using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINFORM.DAL
{
    public class KHACHHANGDAL
    {
        public static void AddKH(string makh, string tenkh, string gioitinh, string dienthoai, string diachi)
        {
            QLBHDataContext data = new QLBHDataContext();
            KhachHang kh = new KhachHang();
            kh.MaKH = makh;
            kh.TenKH = tenkh;
            kh.GioiTinh = gioitinh;
            kh.DienThoai = dienthoai;
            kh.DiaChi = diachi;
            kh.TrangThai = true;
            data.KhachHangs.InsertOnSubmit(kh);
            data.SubmitChanges();
        }
        public static void DeleteSelectKH(string MaKH)
        {
            QLBHDataContext data = new QLBHDataContext();
            KhachHang dskh = (from kh in data.KhachHangs
                          where kh.MaKH == MaKH.Trim()
                          select kh).SingleOrDefault<KhachHang>();
            dskh.TrangThai = false;
            data.SubmitChanges();

        }
        //====== Sửa sản phẩm ===========
        public static void EditSelectKH(string makh, string tenkh, string gioitinh, string dienthoai, string diachi)
        {
            QLBHDataContext data = new QLBHDataContext();
            KhachHang dskh = (from kh in data.KhachHangs
                            where kh.MaKH == makh.Trim()
                            select kh).SingleOrDefault<KhachHang>();
            dskh.MaKH = makh;
            dskh.TenKH = tenkh;
            dskh.GioiTinh = gioitinh;
            dskh.DienThoai = dienthoai;
            dskh.DiaChi = diachi;
            dskh.TrangThai = true;
            data.SubmitChanges();
        }
    }
}
