using Microsoft.Reporting.WinForms;
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
    public partial class DanhSachSanPham : Form
    {
        public DanhSachSanPham()
        {
            InitializeComponent();
        }
        //======== Form Load ===========
        private void DanhSachSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_winformDataSet1.LoaiSanPham' table. You can move, or remove it, as needed.
            this.loaiSanPhamTableAdapter.Fill(this.qLBH_winformDataSet1.LoaiSanPham);
            QLBHDataContext data = new QLBHDataContext();
            var listlsp = from loaisanpham in data.LoaiSanPhams
                          select new
                          {
                              loaisanpham.TenLoai,
                              loaisanpham.MaLoai
                          };
            cboloaisp.DataSource = listlsp;
            cboloaisp.DisplayMember = "Tenloai";
            cboloaisp.ValueMember = "Maloai";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        //=========== Xem danh sách ==============
        private void btndanhsach_Click(object sender, EventArgs e)
        {
            if (rdtatca.Checked == true)
            {
                QLBHDataContext data = new QLBHDataContext();
                var listsp = from sanpham in data.SanPhams
                             where sanpham.TrangThai == true 
                             select new
                             {
                                 sanpham.MaSP,
                                 sanpham.TenSP,
                                 sanpham.DVTinh,
                                 sanpham.DonGia,
                                 sanpham.MaLoai,
                             };

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOANWINFORM.Reportdssp.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DATASANPHAM", listsp));
                this.reportViewer1.RefreshReport();
                //this.reportViewer1.LocalReport.DataSources.Clear();
            }
            if (rdtheoloai.Checked == true)
            {
                QLBHDataContext data = new QLBHDataContext();
                string a = cboloaisp.SelectedValue.ToString();
                var listsp = from sanpham in data.SanPhams
                             where sanpham.TrangThai == true && sanpham.MaLoai == a
                             select new
                             {
                                 sanpham.MaSP,
                                 sanpham.TenSP,
                                 sanpham.DVTinh,
                                 sanpham.DonGia,
                                 sanpham.MaLoai,
                             };
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOANWINFORM.Reportdsspl.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSSP", listsp));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paMALOAI", cboloaisp.Text));
                this.reportViewer1.RefreshReport();

            }
            if (rdtheonhom.Checked == true)
            {
                this.reportViewer1.LocalReport.DataSources.Clear();
                QLBHDataContext data = new QLBHDataContext();
                string a = cboloaisp.SelectedValue.ToString();
                var listlsp = from loaisanpham in data.LoaiSanPhams
                             where loaisanpham.TrangThai == true 
                             select new
                             {
                                 loaisanpham.MaLoai,
                                 loaisanpham.TenLoai
                             };
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOANWINFORM.Reportdsspnhom.rdlc";
                this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_Processing);
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSLSP", listlsp));
                this.reportViewer1.RefreshReport();
            }

        }
        //============= Report ==================
        private void LocalReport_Processing(object sender, SubreportProcessingEventArgs e)
        {
            string maloai = e.Parameters["pmMALOAI"].Values[0];
            // đổ dữ liệu
            QLBHDataContext data = new QLBHDataContext();
            var listsp = from sanpham in data.SanPhams
                         where sanpham.TrangThai == true && sanpham.MaLoai.Trim() == maloai
                         select new
                         {
                             sanpham.MaSP,
                             sanpham.TenSP,
                             sanpham.DVTinh,
                             sanpham.DonGia,
                             sanpham.MaLoai,
                         };
            e.DataSources.Add(new ReportDataSource("DSSP", listsp));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
               btndanhsach_Click(sender, e);
            }
        }
    }
}
/*NhanVien nv = (from nhanvien in data.NhanViens
               where nhanvien.MaNV == manv.Trim()
               select nhanvien).Single<NhanVien>();*/