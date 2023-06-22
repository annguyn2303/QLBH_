using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DOANWINFORM.PL
{
    public partial class QuanLyBanHang : Form
    {
        public QuanLyBanHang()
        {
            InitializeComponent();
        }


        private void QuanLyBanHang_Load(object sender, EventArgs e)
        {
            DisabledMenu();


        }

        private void DisabledMenu()
        {
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.Enabled = false;
            }
            đăngNhâpToolStripMenuItem1.Enabled = true;
            foreach (ToolStripMenuItem item in quanLyToolStripMenuItem.DropDownItems)
            {
                item.Enabled = false;
            }

            foreach (ToolStripMenuItem item in lâpHoaĐơnToolStripMenuItem.DropDownItems)
            {
                item.Enabled = false;
            }
        }

        private void taiKhoanCaNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanLyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            QuanLyTaiKhoan form_qltk = new QuanLyTaiKhoan();
            form_qltk.MdiParent = this;
            form_qltk.Show();
        }

        private void đăngNhâpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.IsMdiContainer = true;
            DANGNHAPNV form_login = new DANGNHAPNV();
            //============================
            if (form_login.ShowDialog() == DialogResult.OK)
            {                
                string username = form_login.txttaikhoan.Text;
                string password = form_login.txtmatkhau.Text;
                string hashPass = MaHoa(password);
                    
                QLBHDataContext data = new QLBHDataContext();
                //=========== Mã hóa =========
                //======== Checklogin =============
                int login = data.NhanViens.Where(p => p.account == username && p.matkhau == hashPass.Trim()).Count();
                bool i = false;
                foreach (var nv in data.NhanViens)
                {
                    if (login > 0 && nv.account == username)
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        form_login.Hide();
                        phanquyen(nv.MaCV);
                        i=true;
                        đăngNhâpToolStripMenuItem1.Enabled = false;
                    }
                }
                if (i == false)
                {
                    form_login.txttaikhoan.Text = "";
                    form_login.txtmatkhau.Text = "";
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông Báo");
                }
            }
        }
        // Mã hóa mật khẩu 
        string MaHoa(string password)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(password));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public void QUANLY()
        {
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                menuItem.Enabled = true;

            }
            foreach (ToolStripMenuItem mnuitem in xemthongtinToolStripMenuItem.DropDownItems)
            {
                mnuitem.Enabled = true;
            }
            foreach (ToolStripMenuItem mnuitem in quanLyToolStripMenuItem.DropDownItems)
            {

                mnuitem.Enabled = true;
            }
            foreach (ToolStripMenuItem mnuitem in lâpHoaĐơnToolStripMenuItem.DropDownItems)
            {

                mnuitem.Enabled = true;
            }
            thôngKêDoanhThuToolStripMenuItem.Enabled = true;

        }
        private void NHANVIEN()
        {
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                menuItem.Enabled = true;

            }
            int i = 0;
            foreach (ToolStripMenuItem mnuitem in xemthongtinToolStripMenuItem.DropDownItems)
            {

                if (i == 4 || i == 5)
                    mnuitem.Enabled = false;
                else
                    mnuitem.Enabled = true;
                i++;
            }
            i = 0;
            foreach (ToolStripMenuItem mnuitem in quanLyToolStripMenuItem.DropDownItems)
            {

                if (i == 0)
                    mnuitem.Enabled = true;
                else
                    mnuitem.Enabled = false;
                i++;
            }
            i = 0;
            foreach (ToolStripMenuItem mnuitem in lâpHoaĐơnToolStripMenuItem.DropDownItems)
            {

                if (i == 0)
                    mnuitem.Enabled = true;
                else
                    mnuitem.Enabled = false;
                i++;
            }
            thôngKêDoanhThuToolStripMenuItem.Enabled = false;
        }
        private void phanquyen(string Phanquyen)
        {
            switch (Phanquyen)
            {
                case "QL":
                    QUANLY();
                    break;
                case "NV":
                    NHANVIEN();
                    break;
                default:
                    menuStrip1.Enabled = false;
                    break;
            }
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisabledMenu();
            foreach(Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void danhSachSanPhâmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            DanhSachSanPham form_dssp = new DanhSachSanPham();
            form_dssp.MdiParent = this;
            form_dssp.Show();
        }

        private void sanPhâmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            QuanLySanPhamcs form_qlsp = new QuanLySanPhamcs();
            form_qlsp.MdiParent = this;
            form_qlsp.Show();
        }

        private void timKiêmSanPhâmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            TimKiemSanPhamcs form_tksp = new TimKiemSanPhamcs();
            form_tksp.MdiParent = this;
            form_tksp.Show();
        }

        private void lâpHoaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            HoaDonBanHang form_hdbh = new HoaDonBanHang();
            form_hdbh.MdiParent = this;
            form_hdbh.Show();
        }

        private void danhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            DanhSachKhachHang form_dskh = new DanhSachKhachHang();
            form_dskh.MdiParent = this;
            form_dskh.Show();
        }

        private void timKiêmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timKiêmKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            TimKiemKhachHang form_tkkh = new TimKiemKhachHang();
            form_tkkh.MdiParent = this;
            form_tkkh.Show();
        }

        private void timKiêmHoaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            TimKiemHoaDon form_tkhd = new TimKiemHoaDon();
            form_tkhd.MdiParent = this;
            form_tkhd.Show();
        }

        private void thôngTinKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            QuanLyKhachHang form_qlkh = new QuanLyKhachHang();
            form_qlkh.MdiParent = this;
            form_qlkh.Show();
        }

        private void danhSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void danhSachHoaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            DanhSachHoaDon form_dshd = new DanhSachHoaDon();
            form_dshd.MdiParent = this;
            form_dshd.Show();
        }

        private void thôngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
