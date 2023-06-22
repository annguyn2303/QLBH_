using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINFORM.DAL
{
    public class HOADONDAL
    {
        //========= Tạo Mã HĐ ============
       
        //========= Thêm Hóa Đơn =============
        public static void AddHoaDon( string mahd, string makh, string manv, DateTime ngayban, int tongtien)
        {
            QLBHDataContext data = new QLBHDataContext();
            HoaDon hd = new HoaDon();
                hd.MaHD = mahd;
                hd.MaKH = makh;
                hd.MaNV = manv;
                hd.NgayHD = ngayban;
                hd.ThanhTien = tongtien;
                hd.TrangThai = true;
            data.HoaDons.InsertOnSubmit(hd);
            data.SubmitChanges();
        }
    }
}

