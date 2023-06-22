using DOANWINFORM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINFORM.BLL
{
    public class CHITIETHOADONBLL
    {
        public static void AddChitiethoadon(string masp, string mahd, int soluong, int giaban, int thanhtien)
        {
            CHITIETHOADONDAL.AddChitiethoadon(masp, mahd, soluong, giaban, thanhtien);
        }
        }
}
