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
    public partial class DanhSachHoaDon : Form
    {
        public DanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();
            var listhd = from hd in data.HoaDons
                         where hd.TrangThai == true
                         select new
                         {
                             hd.MaHD,
                             hd.MaKH,
                             hd.MaNV,
                             hd.NgayHD,
                             hd.ThanhTien,
                         };

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOANWINFORM.Reportdshd.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSHD", listhd));
            this.reportViewer1.RefreshReport();
            //this.reportViewer1.LocalReport.DataSources.Clear();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
