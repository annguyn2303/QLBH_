using DOANWINFORM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINFORM.BLL
{
    public class KHACHHANGBLL
    {
        public static void AddKH(string makh, string tenkh, string gioitinh, string dienthoai, string diachi)
        {
            KHACHHANGDAL.AddKH(makh, tenkh, gioitinh, dienthoai, diachi);
        }
        public static void DeleteSelectKH(string MaKH)
        {
            KHACHHANGDAL.DeleteSelectKH(MaKH);
        }
        public static void EditSelectKH(string makh, string tenkh, string gioitinh, string dienthoai, string diachi)
        {
            KHACHHANGDAL.EditSelectKH(makh, tenkh, gioitinh, dienthoai, diachi);
        }
    }
}
