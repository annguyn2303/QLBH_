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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
            dgvDSKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSKH.ReadOnly = true;
            dgvDSKH.MultiSelect = true;
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            this.KeyPreview = true;
            this.KeyDown += QuanLyKhachHang_KeyDown;
        }
        private void LoadDataGridView()
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
            dgvDSKH.DataSource = listkh;
            dgvDSKH.Columns[0].HeaderText = "Mã Khách hàng";
            dgvDSKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvDSKH.Columns[2].HeaderText = "Giới tính";
            dgvDSKH.Columns[3].HeaderText = "Điện thoại";
            dgvDSKH.Columns[4].HeaderText = "Địa chỉ";
            //dgvHDBanHang.Columns[0].Visible = false;
            dgvDSKH.Columns[0].Width = 100;
            dgvDSKH.Columns[1].Width = 200;
            dgvDSKH.Columns[2].Width = 50;
            dgvDSKH.Columns[3].Width = 120;
            dgvDSKH.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtDiaChi.Text = "";
            txtMaKH.Text = "";
            txtSDT.Text = "";
            txtTenKH.Text = "";
            radNam.Checked = true;

            dgvDSKH.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSKH.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSKH.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSKH.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSKH.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSKH.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSKH.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSKH.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSKH.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSKH.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radNam.Checked)
            KHACHHANGBLL.AddKH(txtMaKH.Text, txtTenKH.Text, radNam.Text, txtSDT.Text, txtDiaChi.Text);
            else
            KHACHHANGBLL.AddKH(txtMaKH.Text, txtTenKH.Text, radNu.Text, txtSDT.Text, txtDiaChi.Text);
            LoadDataGridView();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            KHACHHANGBLL.DeleteSelectKH(txtMaKH.Text);
            LoadDataGridView();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            KHACHHANGBLL.EditSelectKH(txtMaKH.Text, txtTenKH.Text, radNam.Text, txtSDT.Text, txtDiaChi.Text);
            LoadDataGridView();
        }

        private void dgvDSKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSKH.SelectedRows.Count > 0)
            {
                txtMaKH.Text = dgvDSKH.SelectedRows[0].Cells[0].Value.ToString();
                txtTenKH.Text = dgvDSKH.SelectedRows[0].Cells[1].Value.ToString();
                txtSDT.Text = dgvDSKH.SelectedRows[0].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvDSKH.SelectedRows[0].Cells[4].Value.ToString();
                if(radNam.Text.ToLower().Equals(dgvDSKH.SelectedRows[0].Cells[2].Value.ToString().ToLower()))
                {
                    radNam.Checked=true;
                }
                else
                {
                    radNu.Checked=true;
                }

            }
        }

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnLoad_Click(sender, e);
            }
        }

        private void QuanLyKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }
    }
}
