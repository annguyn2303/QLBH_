using DOANWINFORM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINFORM.BLL
{
    public class HOADONBLL
    {
        public static void AddHoaDon(string mahd, string makh, string manv,DateTime ngayban, int tongtien)
        {
           HOADONDAL.AddHoaDon(mahd, makh, manv, ngayban, tongtien);
        }
    }
}
