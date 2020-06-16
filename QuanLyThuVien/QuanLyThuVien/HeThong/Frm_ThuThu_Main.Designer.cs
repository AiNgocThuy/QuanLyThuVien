namespace QuanLyThuVien.HeThong
{
    partial class Frm_ThuThu_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThuThu_Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.tsbXuatExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbThoat = new System.Windows.Forms.ToolStripButton();
            this.dgvThuThu = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.tsbSua,
            this.tsbXoa,
            this.tsbXuatExcel,
            this.tsbThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(724, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbThem
            // 
            this.tsbThem.Image = ((System.Drawing.Image)(resources.GetObject("tsbThem.Image")));
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Size = new System.Drawing.Size(58, 22);
            this.tsbThem.Text = "Thêm";
            // 
            // tsbSua
            // 
            this.tsbSua.Image = ((System.Drawing.Image)(resources.GetObject("tsbSua.Image")));
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Size = new System.Drawing.Size(46, 22);
            this.tsbSua.Text = "Sửa";
            // 
            // tsbXoa
            // 
            this.tsbXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbXoa.Image")));
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Size = new System.Drawing.Size(47, 22);
            this.tsbXoa.Text = "Xóa";
            // 
            // tsbXuatExcel
            // 
            this.tsbXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbXuatExcel.Image")));
            this.tsbXuatExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXuatExcel.Name = "tsbXuatExcel";
            this.tsbXuatExcel.Size = new System.Drawing.Size(80, 22);
            this.tsbXuatExcel.Text = "Xuất Excel";
            // 
            // tsbThoat
            // 
            this.tsbThoat.Image = ((System.Drawing.Image)(resources.GetObject("tsbThoat.Image")));
            this.tsbThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThoat.Name = "tsbThoat";
            this.tsbThoat.Size = new System.Drawing.Size(58, 22);
            this.tsbThoat.Text = "Thoát";
            // 
            // dgvThuThu
            // 
            this.dgvThuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuThu.Location = new System.Drawing.Point(0, 25);
            this.dgvThuThu.Name = "dgvThuThu";
            this.dgvThuThu.Size = new System.Drawing.Size(724, 237);
            this.dgvThuThu.TabIndex = 1;
            // 
            // Frm_ThuThu_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 262);
            this.Controls.Add(this.dgvThuThu);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_ThuThu_Main";
            this.Text = "Frm_ThuThu_Main";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripButton tsbXuatExcel;
        private System.Windows.Forms.ToolStripButton tsbThoat;
        private System.Windows.Forms.DataGridView dgvThuThu;
    }
}