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
using DOANWINFORM.DTO;
using Microsoft.VisualBasic.Devices;
using System.Windows.Input;

namespace DOANWINFORM.PL
{
    public partial class QuanLySanPhamcs : Form
    {
        public QuanLySanPhamcs()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = true;
        }
        //========== Thêm ==============
        private void thêm_Click(object sender, EventArgs e)
        {
            SANPHAMDAL.AddNewSP(masp.Text, tensp.Text, dvtinh.Text, int.Parse(dongia.Text), cbmaloai.SelectedValue.ToString());
            QuanLySanPhamcs_Load(sender, e);
           

        }
        //========== Xóa ===============
        private void xoa_Click(object sender, EventArgs e)
        {
            SANPHAMDAL.DeleteSelectSP(masp.Text);
            QuanLySanPhamcs_Load(sender, e);
        }
        //========= Sửa ================
        private void sua_Click(object sender, EventArgs e)
        {
            SANPHAMDAL.EditSelectSP(masp.Text, tensp.Text, dvtinh.Text, int.Parse(dongia.Text), cbmaloai.SelectedValue.ToString());
            QuanLySanPhamcs_Load(sender, e);

        }
        //========= Selection Changed ===========
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                masp.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tensp.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dvtinh.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dongia.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                

                QLBHDataContext data = new QLBHDataContext();
                cbmaloai.DataSource = data.LoaiSanPhams.Where(lsp=>lsp.MaLoai== dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                cbmaloai.DisplayMember = "TenLoai";
                cbmaloai.ValueMember = "MaLoai";

            }
        }
        // ======== Form Load =======
        private void QuanLySanPhamcs_Load(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();
            //dataGridView1.DataSource = db.SanPhams.Where(p => p.TrangThai == True);
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
            dataGridView1.DataSource = listsp;


            var listloaisanpham = from LoaiSanPham in data.LoaiSanPhams
                                  select new
                                  {
                                      LoaiSanPham.MaLoai,
                                      LoaiSanPham.TenLoai,
                                  };
            cbmaloai.DataSource = listloaisanpham;
            cbmaloai.DisplayMember = "TenLoai";
            cbmaloai.ValueMember = "MaLoai";        
            //==============================
            dataGridView1.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[2].HeaderText = "Đơn vị tính";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
            dataGridView1.Columns[4].HeaderText = "Mã  loại";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //=====================
            masp.Text = "";
            tensp.Text = "";
            dvtinh.Text = "";
            dongia.Text = "";
            cbmaloai.SelectedIndex = -1;
            this.KeyPreview = true;
            this.KeyDown += QuanLySanPhamcs_KeyDown;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            QuanLySanPhamcs_Load(sender, e);
        }

        private void QuanLySanPhamcs_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Delete)
            {
                xoa_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnlammoi_Click(sender, e);
            }
        }      
    }
}
