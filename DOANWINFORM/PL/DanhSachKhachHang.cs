using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANWINFORM.PL
{
    public partial class DanhSachKhachHang : Form
    {
        public DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();
            var listkh = from kh in data.KhachHangs
                         where kh.TrangThai == true
                         select new
                         {
                             kh.MaKH,
                             kh.TenKH,
                             kh.GioiTinh,
                             kh.DienThoai,
                             kh.DiaChi
                         };

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOANWINFORM.Reportdskh.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSKH", listkh));
            this.reportViewer1.RefreshReport();
            //this.reportViewer1.LocalReport.DataSources.Clear();
        }
    }
}
