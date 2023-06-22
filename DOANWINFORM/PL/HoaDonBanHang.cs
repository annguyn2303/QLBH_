
using DOANWINFORM.BLL;
using DOANWINFORM.DAL;
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
    public partial class HoaDonBanHang : Form
    {
        public HoaDonBanHang()
        {
            InitializeComponent();
        }
        //============= Form Load ============
        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {

            QLBHDataContext data = new QLBHDataContext();
            //cbonhanvien
            var listnhanvien = from nhanvien in data.NhanViens
                               where nhanvien.TrangThai==true
                               select new
                               {
                                   nhanvien.MaNV,
                                   nhanvien.TenNV
                               };
            cboMaNhanVien.DataSource = listnhanvien;
            cboMaNhanVien.DisplayMember = "MaNV";
            cboMaNhanVien.ValueMember = "TenNV";
            txtTenNhanVien.Text = "";
            cboMaNhanVien.SelectedIndex = -1;

            //cboKhachang
            var listkh = from khachHang in data.KhachHangs
                         where khachHang.TrangThai==true
                         select new
                         {
                             khachHang.MaKH,
                             khachHang.TenKH
                         };
            cboTenKhach.DataSource = listkh;

            cboTenKhach.DisplayMember = "TenKH";
            cboTenKhach.ValueMember = "MaKH";
            txtMaKhach.Text = "";
            cboTenKhach.SelectedIndex = -1;

            

            //cbosanpham
            var listsanpham = from SanPham in data.SanPhams
                              where SanPham.TrangThai==true
                              select new
                              {
                                  SanPham.TenSP,
                                  SanPham.MaSP,
                                  SanPham.DonGia
                              };
            cboMaHang.DataSource = listsanpham;


            cboMaHang.DisplayMember = "MaSP";
            cboMaHang.ValueMember = "TenSP";
            txtTenHang.Text = "";
            cboMaHang.SelectedIndex = -1;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnInHoaDon.Enabled = true;
            btnInHoaDon.Enabled = false;
            txtMaHDBan.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            txtMaKhach.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDonGiaBan.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtTongTien.Text = "0";
            
        }
        private void LoadDataGridView()
        {
            QLBHDataContext data = new QLBHDataContext();
            var listcthd = from cthd in data.ChiTietHoaDons
                           join sp in data.SanPhams on cthd.MaSP equals sp.MaSP
                           where cthd.MaHD == txtMaHDBan.Text
                           select new
                           {
                               cthd.MaHD,
                               cthd.MaSP,
                               sp.TenSP,
                               cthd.SoLuong,
                               sp.DonGia,
                               cthd.ThanhTien
                           };
            dgvHDBanHang.DataSource = listcthd;
            dgvHDBanHang.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHDBanHang.Columns[1].HeaderText = "Mã sản phẩm";
            dgvHDBanHang.Columns[2].HeaderText = "Tên sản phẩm";
            dgvHDBanHang.Columns[3].HeaderText = "Số lượng";
            dgvHDBanHang.Columns[4].HeaderText = "Đơn giá";
            dgvHDBanHang.Columns[5].HeaderText = "Thành tiền";

            dgvHDBanHang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; ;
            dgvHDBanHang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHDBanHang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHDBanHang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHDBanHang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHDBanHang.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvHDBanHang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHDBanHang.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        //=============== Selected Index Changed (Mã nhân viên) ==================
        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();
            var listnhanvien = from nhanvien in data.NhanViens
                               select new

                               {
                                   nhanvien.MaNV,
                                   nhanvien.TenNV
                               };
            if (cboMaNhanVien.SelectedIndex > -1)
            {
                foreach (var item in listnhanvien)
                {

                    if (cboMaNhanVien.SelectedValue.ToString().Equals(item.TenNV.ToString()))
                    {
                        txtTenNhanVien.Text = item.TenNV.ToString();
                    }
                }
            }
        }
        //===============Selected Index Changed (Mã Khách) =======================
        private void cboMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();
            var listkh = from khachHang in data.KhachHangs
                         select new
                         {
                             khachHang.MaKH,
                             khachHang.TenKH,
                             khachHang.DiaChi,
                             khachHang.DienThoai
                         };
            if (cboTenKhach.SelectedIndex > -1)
            {
                foreach (var item in listkh)
                {

                    if (cboTenKhach.SelectedValue.ToString().Equals(item.MaKH.ToString()))
                    {
                        txtMaKhach.Text = item.MaKH.ToString();
                        txtDiaChi.Text = item.DiaChi.ToString();
                        txtDienThoai.Text = item.DienThoai.ToString();
                    }
                }
            }
        }
        //===============Selected Index Changed (Mã Hàng) =======================
        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();
            var listsanpham = from SanPham in data.SanPhams
                              select new

                              {
                                  SanPham.TenSP,
                                  SanPham.DonGia
                              };
            if (cboMaHang.SelectedIndex > -1)
            {
                foreach (var item in listsanpham)
                {

                    if (cboMaHang.SelectedValue.ToString().Equals(item.TenSP.ToString()))
                    {
                        txtTenHang.Text = item.TenSP.ToString();
                        txtDonGiaBan.Text = item.DonGia.ToString();
                    }
                }
            }
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //============ Lưu =====================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();

            txtThanhTien.Text = Convert.ToString(int.Parse(txtSoLuong.Text) * int.Parse(txtDonGiaBan.Text));
            if (CheckMaHD(txtMaHDBan.Text))
            {
                CHITIETHOADONDAL.AddChitiethoadon(cboMaHang.Text.ToString(), txtMaHDBan.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDonGiaBan.Text), int.Parse(txtThanhTien.Text));
                var sp1 = from gia in data.HoaDons
                          where gia.MaHD == txtMaHDBan.Text
                          select gia;
                foreach (HoaDon gia in sp1)
                {
                    double Tongmoi = Convert.ToDouble(gia.ThanhTien) + Convert.ToDouble(txtThanhTien.Text);
                    txtTongTien.Text = Tongmoi.ToString();
                    lblBangChu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(Tongmoi);

                    var sp2 = (from val in data.HoaDons
                               where val.MaHD == txtMaHDBan.Text
                               select val).Single();
                    sp2.ThanhTien = int.Parse(txtTongTien.Text);
                    data.SubmitChanges();
                }
                cboMaHang.SelectedIndex = -1;
                txtSoLuong.Text = "";
                txtThanhTien.Text = "";
                LoadDataGridView();
                return;

            }
            HOADONBLL.AddHoaDon(txtMaHDBan.Text, txtMaKhach.Text.ToString(), cboMaNhanVien.Text.ToString(), dtpNgayBan.Value, int.Parse(txtThanhTien.Text));
            CHITIETHOADONDAL.AddChitiethoadon(cboMaHang.Text.ToString(), txtMaHDBan.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDonGiaBan.Text), int.Parse(txtThanhTien.Text));
            LoadDataGridView();
            //Cập nhật hóa đơn



            var sp = from gia in data.HoaDons
                     where gia.MaHD == txtMaHDBan.Text
                     select gia;
            foreach (HoaDon gia in sp)
            {
                txtTongTien.Text = txtThanhTien.Text;
                lblBangChu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(Double.Parse(txtThanhTien.Text));
            }


            //ResetValuesHang();
            btnThem.Enabled = true;
            btnInHoaDon.Enabled = true;
            cboMaHang.SelectedIndex = -1;
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
            LoadDataGridView();
        }
        public bool CheckMaHD(string maHD)
        {
            bool b = false;
            QLBHDataContext data = new QLBHDataContext();
            var hd = from mahd in data.HoaDons
                     select mahd;
            foreach (var mahd in hd)
            {
                if (mahd.MaHD == maHD)
                {
                    b = true;
                }
            }
            return b;
        }
        //============ Thêm ====================
        private void btnThem_Click(object sender, EventArgs e)
        {
            dtpNgayBan.Enabled = true;
            cboMaHang.Enabled = true;
            cboMaNhanVien.Enabled = true;
            cboTenKhach.Enabled = true;
            txtSoLuong.Enabled = true;
            txtThanhTien.Enabled = true;
            btnLuu.Enabled = true;
 
            btnInHoaDon.Enabled = true;
            txtMaHDBan.Text = Function.CreateKey("HD");
            LoadDataGridView();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();
            var listcthd = from cthd in data.ChiTietHoaDons
                           join sp in data.SanPhams on cthd.MaSP equals sp.MaSP
                           where cthd.MaHD == txtMaHDBan.Text
                           select new
                           {
                               cthd.MaHD,
                               cthd.MaSP,
                               sp.TenSP,
                               cthd.SoLuong,
                               sp.DonGia,
                               cthd.ThanhTien
                           };
            dgrvinhoadon.DataSource = listcthd;
            dgrvinhoadon.Columns[0].HeaderText = "Mã hóa đơn";
            dgrvinhoadon.Columns[1].HeaderText = "Mã sản phẩm";
            dgrvinhoadon.Columns[2].HeaderText = "Tên sản phẩm";
            dgrvinhoadon.Columns[3].HeaderText = "Số lượng";
            dgrvinhoadon.Columns[4].HeaderText = "Đơn giá";
            dgrvinhoadon.Columns[5].HeaderText = "Thành tiền";


            dgrvinhoadon.Columns[0].Visible = false;
            dgrvinhoadon.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHDBanHang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            dgvHDBanHang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHDBanHang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHDBanHang.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            txtintenkh.Text = txtMaKhach.Text;
            txtinmahd.Text = txtMaHDBan.Text;
            txtintongtien.Text = txtTongTien.Text;
            txtInTenNV.Text = txtTenNhanVien.Text;
            txtInDate.Text = DateTime.Now.ToString();
            txtInDC.Text = txtDiaChi.Text;
            var sp1 = from gia in data.HoaDons
                      where gia.MaHD == txtMaHDBan.Text
                      select gia;
            foreach (HoaDon gia in sp1)
            {
                lbInBangChu.Text = "Tổng tiền (viết bằng chữ): " + Function.ChuyenSoSangChuoi(Double.Parse(txtTongTien.Text));
            }
            txtintenkh.Enabled = false;
            txtinmahd.Enabled = false;
            txtintongtien.Enabled = false;
            txtInTenNV.Enabled = false;
            txtInDate.Enabled = false;
            txtInDC.Enabled = false;


            TabPage t = tabControl1.TabPages[1];
            tabControl1.SelectTab(t); //go to tab
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void LoadInfoHoaDon()
        {
            QLBHDataContext data = new QLBHDataContext();
            var load = from a in data.HoaDons
                       where a.MaHD == txtMaHDBan.Text
                       select a;
            foreach (var a in load)
            {
                cboMaNhanVien.Text = a.MaNV;
                txtMaKhach.Text = a.MaKH;
                txtTongTien.Text = a.ThanhTien.ToString();
                lblBangChu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(Double.Parse(txtTongTien.Text));
            }
        }
        

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgrvinhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDonBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(sender, e);
            }
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
