using DOANWINFORM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINFORM.BLL
{
    internal class TAIKHOANBLL
    {
        public static void AddNewTK(string manv, string macv, string tennv, string account, string matkhau, string diachi, string email, string dienthoai, string chucvu, string gioitinh)
        {
            TAIKHOANDAL.AddNewTK(manv, macv, tennv, account, matkhau, diachi, email, dienthoai, chucvu, gioitinh);
        }
        public static void DeleteSelectTK(string manv)
        {
            TAIKHOANDAL.DeleteSelectTK(manv);
        }
        public static void EditSelectTK(string manv, string macv, string tennv, string account, string matkhau, string diachi, string email, string dienthoai, string chucvu, string gioitinh)
        {
            TAIKHOANDAL.EditSelectTK(manv, macv, tennv, account, matkhau, diachi, email, dienthoai, chucvu, gioitinh);
        }
    }
}
