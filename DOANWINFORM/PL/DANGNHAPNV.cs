using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOANWINFORM.PL;

namespace DOANWINFORM
{
    public partial class DANGNHAPNV : Form
    {
        public DANGNHAPNV()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
        }
        //======== Form Load ======
        private void DANGNHAPNV_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += txtmatkhau_KeyDown;
        }
        //======= Đăng nhập ======
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndangnhap_Click(sender, e);
            }
        }
        
    }
}
