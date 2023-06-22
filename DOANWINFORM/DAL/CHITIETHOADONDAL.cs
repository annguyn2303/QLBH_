using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINFORM.DAL
{
    public class CHITIETHOADONDAL
    {
        public static void AddChitiethoadon( string masp, string mahd, int soluong, int giaban, int thanhtien)
        {
            QLBHDataContext data = new QLBHDataContext();
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.MaHD = mahd;
            cthd.MaSP = masp;
            cthd.SoLuong = soluong;
            cthd.DonGia = giaban;
            cthd.ThanhTien = thanhtien;
            data.ChiTietHoaDons.InsertOnSubmit(cthd);
            data.SubmitChanges();
        }
    }
}
