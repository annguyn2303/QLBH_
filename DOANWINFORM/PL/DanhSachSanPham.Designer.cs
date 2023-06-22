namespace DOANWINFORM.PL
{
    partial class DanhSachSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboloaisp = new System.Windows.Forms.ComboBox();
            this.rdtheonhom = new System.Windows.Forms.RadioButton();
            this.rdtheoloai = new System.Windows.Forms.RadioButton();
            this.rdtatca = new System.Windows.Forms.RadioButton();
            this.qLBH_winformDataSet = new DOANWINFORM.QLBH_winformDataSet();
            this.qLBHwinformDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndanhsach = new System.Windows.Forms.Button();
            this.qLBHwinformDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_winformDataSet1 = new DOANWINFORM.QLBH_winformDataSet1();
            this.loaiSanPhamTableAdapter = new DOANWINFORM.QLBH_winformDataSet1TableAdapters.LoaiSanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_winformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHwinformDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHwinformDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_winformDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.BackColor = System.Drawing.Color.LightBlue;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(751, 534);
            this.reportViewer1.TabIndex = 0;
            // 
            // cboloaisp
            // 
            this.cboloaisp.Font = new System.Drawing.Font("Arial", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboloaisp.FormattingEnabled = true;
            this.cboloaisp.Location = new System.Drawing.Point(932, 292);
            this.cboloaisp.Name = "cboloaisp";
            this.cboloaisp.Size = new System.Drawing.Size(114, 26);
            this.cboloaisp.TabIndex = 7;
            // 
            // rdtheonhom
            // 
            this.rdtheonhom.AutoSize = true;
            this.rdtheonhom.Font = new System.Drawing.Font("Arial", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdtheonhom.Location = new System.Drawing.Point(757, 247);
            this.rdtheonhom.Name = "rdtheonhom";
            this.rdtheonhom.Size = new System.Drawing.Size(214, 23);
            this.rdtheonhom.TabIndex = 4;
            this.rdtheonhom.TabStop = true;
            this.rdtheonhom.Text = "Group theo loại sản phẩm";
            this.rdtheonhom.UseVisualStyleBackColor = true;
            this.rdtheonhom.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdtheoloai
            // 
            this.rdtheoloai.AutoSize = true;
            this.rdtheoloai.Font = new System.Drawing.Font("Arial", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdtheoloai.Location = new System.Drawing.Point(757, 292);
            this.rdtheoloai.Name = "rdtheoloai";
            this.rdtheoloai.Size = new System.Drawing.Size(169, 23);
            this.rdtheoloai.TabIndex = 5;
            this.rdtheoloai.TabStop = true;
            this.rdtheoloai.Text = "Theo loại sản phẩm";
            this.rdtheoloai.UseVisualStyleBackColor = true;
            // 
            // rdtatca
            // 
            this.rdtatca.AutoSize = true;
            this.rdtatca.Font = new System.Drawing.Font("Arial", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdtatca.Location = new System.Drawing.Point(757, 202);
            this.rdtatca.Name = "rdtatca";
            this.rdtatca.Size = new System.Drawing.Size(203, 23);
            this.rdtatca.TabIndex = 6;
            this.rdtatca.TabStop = true;
            this.rdtatca.Text = "Hiển thị tất cả sản phẩm";
            this.rdtatca.UseVisualStyleBackColor = true;
            // 
            // qLBH_winformDataSet
            // 
            this.qLBH_winformDataSet.DataSetName = "QLBH_winformDataSet";
            this.qLBH_winformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBHwinformDataSetBindingSource
            // 
            this.qLBHwinformDataSetBindingSource.DataSource = this.qLBH_winformDataSet;
            this.qLBHwinformDataSetBindingSource.Position = 0;
            // 
            // loaiSanPhamBindingSource
            // 
            this.loaiSanPhamBindingSource.DataMember = "LoaiSanPham";
            this.loaiSanPhamBindingSource.DataSource = this.qLBHwinformDataSet1BindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.96639F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(788, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "LỌC DANH SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(840, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btndanhsach
            // 
            this.btndanhsach.BackColor = System.Drawing.SystemColors.Window;
            this.btndanhsach.Font = new System.Drawing.Font("Arial", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndanhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndanhsach.Location = new System.Drawing.Point(818, 367);
            this.btndanhsach.Name = "btndanhsach";
            this.btndanhsach.Size = new System.Drawing.Size(173, 38);
            this.btndanhsach.TabIndex = 1;
            this.btndanhsach.Text = "  Lọc danh sách";
            this.btndanhsach.UseVisualStyleBackColor = false;
            this.btndanhsach.Click += new System.EventHandler(this.btndanhsach_Click);
            // 
            // qLBHwinformDataSet1BindingSource
            // 
            this.qLBHwinformDataSet1BindingSource.DataSource = this.qLBH_winformDataSet1;
            this.qLBHwinformDataSet1BindingSource.Position = 0;
            // 
            // qLBH_winformDataSet1
            // 
            this.qLBH_winformDataSet1.DataSetName = "QLBH_winformDataSet1";
            this.qLBH_winformDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiSanPhamTableAdapter
            // 
            this.loaiSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // DanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1078, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdtheonhom);
            this.Controls.Add(this.rdtatca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdtheoloai);
            this.Controls.Add(this.cboloaisp);
            this.Controls.Add(this.btndanhsach);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "DanhSachSanPham";
            this.ShowIcon = false;
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.DanhSachSanPham_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DanhSachSanPham_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_winformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHwinformDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHwinformDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_winformDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btndanhsach;
        private System.Windows.Forms.ComboBox cboloaisp;
        private System.Windows.Forms.RadioButton rdtheonhom;
        private System.Windows.Forms.RadioButton rdtheoloai;
        private System.Windows.Forms.RadioButton rdtatca;
        private System.Windows.Forms.BindingSource qLBHwinformDataSet1BindingSource;
        private QLBH_winformDataSet1 qLBH_winformDataSet1;
        private QLBH_winformDataSet qLBH_winformDataSet;
        private System.Windows.Forms.BindingSource qLBHwinformDataSetBindingSource;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource;
        private QLBH_winformDataSet1TableAdapters.LoaiSanPhamTableAdapter loaiSanPhamTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}