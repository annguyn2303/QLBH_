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
    public partial class TimKiemHoaDon : Form
    {
        public TimKiemHoaDon()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }
        //========= Form Load ===========
        private void TimKiemHoaDon_Load(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();
            var listhd = from hoadon in data.HoaDons
                         where hoadon.MaHD.ToLower().Contains(cbohoadon.Text.ToLower())
                         select new
                         {
                             hoadon.MaHD,
                             hoadon.MaKH,
                             hoadon.MaNV,
                             hoadon.ThanhTien,
                             
                         };
            dataGridView1.DataSource = listhd;
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns[1].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[2].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
          //  dataGridView1.Columns[4].HeaderText = "Mã  loại";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (var item in listhd)
            {
                cbohoadon.Items.Add(item.MaHD.ToString());
            }
            cbohoadon.SelectedIndex = -1;
            cbohoadon.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbohoadon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //where sanpham.TenSP.ToLower().Contains(comboBox1.SelectedItem.ToString().ToLower().Trim())
        }

        private void timhoadon_Click(object sender, EventArgs e)
        {
            QLBHDataContext data = new QLBHDataContext();
            var listhd = from hoadon in data.HoaDons
                         where hoadon.MaHD.ToLower().Contains(cbohoadon.Text.ToLower()) && hoadon.TrangThai == true
                         select new
                         {
                             hoadon.MaHD,
                             hoadon.MaKH,
                             hoadon.MaNV,
                             hoadon.ThanhTien,

                         };
            dataGridView1.DataSource = listhd;
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns[1].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[2].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[3].HeaderText = "Thành tiền";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void TimKiemHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                timhoadon_Click(sender, e);
            }
        }
    }
}
