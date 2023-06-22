using DOANWINFORM.BLL;
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
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = true;
           


        }

        //============= Form Load ========
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();
            var listnv = from nhanVien in data.NhanViens
                         where nhanVien.TrangThai == true
                         select new
                         {
                             nhanVien.MaNV,
                             nhanVien.TenNV,
                             nhanVien.GioiTinh,
                             nhanVien.DiaChi,
                             nhanVien.DienThoai,
                             nhanVien.ChucVu,
                             nhanVien.account,
                             nhanVien.matkhau,
                             nhanVien.MaCV,
                             nhanVien.Email
                         };
            dataGridView1.DataSource = listnv;

            txtmanv.Text = "";
            txtmacv.Text = "";
            txttennv.Text = "";
            txttaikhoan.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtemail.Text = "";
            txtgioitinh.Text = "";
            txtmacv.Text = "";
            txtmatkhau.Text = "";
            cbochucvu.SelectedIndex = -1;


            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[4].HeaderText = "Điện thoại";
            dataGridView1.Columns[5].HeaderText = "Chức vụ";
            dataGridView1.Columns[6].HeaderText = "Tài khoản";
            dataGridView1.Columns[7].HeaderText = "Mật khẩu";
            dataGridView1.Columns[8].HeaderText = "Mã chức vụ";
            dataGridView1.Columns[9].HeaderText = "Email";

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var listlnv = from loainhanVien in data.LoaiNhanViens
                          select new
                          {
                              loainhanVien.TenLoaiNhanVien,
                              loainhanVien.MaLoaiNhanVien
                          };
            cbochucvu.DataSource = listlnv;
            cbochucvu.DisplayMember = "TenLoaiNhanVien";
            cbochucvu.ValueMember = "MaLoaiNhanVien";
            cbochucvu.SelectedIndex = -1;
            this.KeyPreview = true;
            this.KeyDown += QuanLyTaiKhoan_KeyDown;
        }

        //==== Thêm ========
        private void them_Click(object sender, EventArgs e)
        {
            TAIKHOANBLL.AddNewTK(txtmanv.Text, txtmacv.Text, txttennv.Text, txttaikhoan.Text, txtmatkhau.Text, txtdiachi.Text, txtemail.Text, txtdienthoai.Text, cbochucvu.Text.ToString(), txtgioitinh.Text);
            QuanLyTaiKhoan_Load(sender, e);
        }

        //==== Xóa =========
        private void xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string a = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                TAIKHOANBLL.DeleteSelectTK(a);
            }
            QuanLyTaiKhoan_Load(sender, e);
        }

        //==== Sửa =========
        private void sua_Click(object sender, EventArgs e)
        {
            TAIKHOANBLL.EditSelectTK(txtmanv.Text, txtmacv.Text, txttennv.Text, txttaikhoan.Text, txtmatkhau.Text, txtdiachi.Text, txtemail.Text, txtdienthoai.Text, cbochucvu.SelectedValue.ToString(), txtgioitinh.Text);
            QuanLyTaiKhoan_Load(sender, e);
        }
        //====== Selection Changed =========
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Binding
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtmanv.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txttennv.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtgioitinh.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtdiachi.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtdienthoai.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txttaikhoan.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtmatkhau.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtmacv.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                txtemail.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

                QLBHDataContext data = new QLBHDataContext();
                cbochucvu.DataSource = data.LoaiNhanViens.Where(lnv => lnv.MaLoaiNhanVien == dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                cbochucvu.DisplayMember = "TenLoaiNhanVien";
                cbochucvu.ValueMember = "MaLoaiNhanVien";
                txtmacv.Text=cbochucvu.SelectedValue.ToString();
            }
        }

        private void cbochucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbochucvu.SelectedIndex == 0)
            {
                txtmacv.Text = "NV";
            }
            if (cbochucvu.SelectedIndex == 1)
            {
                txtmacv.Text = "QL";
            }
        }
        

        private void QuanLyTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                xoa_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnlammoi_Click(sender, e);
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan_Load(sender, e);
        }

        private void QuanLyTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }
    }
}
