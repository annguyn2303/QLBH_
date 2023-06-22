using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANWINFORM.DAL;

namespace DOANWINFORM.BLL
{
    public class SANPHAMBLL
    {
        public static void AddNewSP(string MaSP, string TenSP, string DVTinh, int DonGia, string MaLoai)
        {
            SANPHAMDAL.AddNewSP(MaSP, TenSP, DVTinh, DonGia, MaLoai);
        }
        public static void DeleteSelectSP(string MaSP)
        {
            SANPHAMDAL.DeleteSelectSP(MaSP);
        }
        public static void EditSelectSP(string MaSP, string TenSP, string DVTinh, int DonGia, string MaLoai)
        {
            SANPHAMDAL.EditSelectSP(MaSP, TenSP, DVTinh, DonGia, MaLoai);
        }
    }
}
