namespace QuanLyThuVien.HeThong
{
    partial class Frm_DoiMatKhau
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
            this.gbCapLaiMatKhau = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboThuthu = new System.Windows.Forms.ComboBox();
            this.bntCapLai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatKhaumoi = new System.Windows.Forms.TextBox();
            this.txtNhaplaimkmoi = new System.Windows.Forms.TextBox();
            this.bntDoiMatKhau = new System.Windows.Forms.Button();
            this.gbCapLaiMatKhau.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCapLaiMatKhau
            // 
            this.gbCapLaiMatKhau.Controls.Add(this.bntCapLai);
            this.gbCapLaiMatKhau.Controls.Add(this.cboThuthu);
            this.gbCapLaiMatKhau.Controls.Add(this.label1);
            this.gbCapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCapLaiMatKhau.Location = new System.Drawing.Point(12, 12);
            this.gbCapLaiMatKhau.Name = "gbCapLaiMatKhau";
            this.gbCapLaiMatKhau.Size = new System.Drawing.Size(459, 182);
            this.gbCapLaiMatKhau.TabIndex = 0;
            this.gbCapLaiMatKhau.TabStop = false;
            this.gbCapLaiMatKhau.Text = "Cấp lại mật khẩu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntDoiMatKhau);
            this.groupBox2.Controls.Add(this.txtNhaplaimkmoi);
            this.groupBox2.Controls.Add(this.txtmatKhaumoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đổi mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thủ thư";
            // 
            // cboThuthu
            // 
            this.cboThuthu.FormattingEnabled = true;
            this.cboThuthu.Location = new System.Drawing.Point(10, 96);
            this.cboThuthu.Name = "cboThuthu";
            this.cboThuthu.Size = new System.Drawing.Size(443, 32);
            this.cboThuthu.TabIndex = 1;
            // 
            // bntCapLai
            // 
            this.bntCapLai.Location = new System.Drawing.Point(292, 134);
            this.bntCapLai.Name = "bntCapLai";
            this.bntCapLai.Size = new System.Drawing.Size(87, 32);
            this.bntCapLai.TabIndex = 2;
            this.bntCapLai.Text = "Cấp lại";
            this.bntCapLai.UseVisualStyleBackColor = true;
            this.bntCapLai.Click += new System.EventHandler(this.bntCapLai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "nhập lại mật khẩu mới";
            // 
            // txtmatKhaumoi
            // 
            this.txtmatKhaumoi.Location = new System.Drawing.Point(209, 49);
            this.txtmatKhaumoi.Name = "txtmatKhaumoi";
            this.txtmatKhaumoi.Size = new System.Drawing.Size(244, 29);
            this.txtmatKhaumoi.TabIndex = 3;
            // 
            // txtNhaplaimkmoi
            // 
            this.txtNhaplaimkmoi.Location = new System.Drawing.Point(209, 89);
            this.txtNhaplaimkmoi.Name = "txtNhaplaimkmoi";
            this.txtNhaplaimkmoi.Size = new System.Drawing.Size(244, 29);
            this.txtNhaplaimkmoi.TabIndex = 4;
            this.txtNhaplaimkmoi.TextChanged += new System.EventHandler(this.txtNhaplaimkmoi_TextChanged);
            this.txtNhaplaimkmoi.Leave += new System.EventHandler(this.txtNhaplaimkmoi_Leave);
            // 
            // bntDoiMatKhau
            // 
            this.bntDoiMatKhau.Location = new System.Drawing.Point(292, 129);
            this.bntDoiMatKhau.Name = "bntDoiMatKhau";
            this.bntDoiMatKhau.Size = new System.Drawing.Size(87, 32);
            this.bntDoiMatKhau.TabIndex = 5;
            this.bntDoiMatKhau.Text = "Đổi mật khẩu";
            this.bntDoiMatKhau.UseVisualStyleBackColor = true;
            this.bntDoiMatKhau.Click += new System.EventHandler(this.bntDoiMatKhau_Click);
            // 
            // Frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCapLaiMatKhau);
            this.Name = "Frm_DoiMatKhau";
            this.Text = "Frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.Frm_DoiMatKhau_Load);
            this.gbCapLaiMatKhau.ResumeLayout(false);
            this.gbCapLaiMatKhau.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCapLaiMatKhau;
        private System.Windows.Forms.Button bntCapLai;
        private System.Windows.Forms.ComboBox cboThuthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntDoiMatKhau;
        private System.Windows.Forms.TextBox txtNhaplaimkmoi;
        private System.Windows.Forms.TextBox txtmatKhaumoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}