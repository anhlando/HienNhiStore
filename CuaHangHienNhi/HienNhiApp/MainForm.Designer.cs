namespace HienNhiApp
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDonHang = new System.Windows.Forms.TabPage();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.tabChiTieu = new System.Windows.Forms.TabPage();
            this.tabNhapHang = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSanPham);
            this.tabControl1.Controls.Add(this.tabDonHang);
            this.tabControl1.Controls.Add(this.tabNhapHang);
            this.tabControl1.Controls.Add(this.tabChiTieu);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDonHang
            // 
            this.tabDonHang.Location = new System.Drawing.Point(4, 22);
            this.tabDonHang.Name = "tabDonHang";
            this.tabDonHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonHang.Size = new System.Drawing.Size(560, 351);
            this.tabDonHang.TabIndex = 0;
            this.tabDonHang.Text = "Đơn hàng";
            this.tabDonHang.UseVisualStyleBackColor = true;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Location = new System.Drawing.Point(4, 22);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(560, 351);
            this.tabSanPham.TabIndex = 1;
            this.tabSanPham.Text = "Sản phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // tabChiTieu
            // 
            this.tabChiTieu.Location = new System.Drawing.Point(4, 22);
            this.tabChiTieu.Name = "tabChiTieu";
            this.tabChiTieu.Size = new System.Drawing.Size(560, 351);
            this.tabChiTieu.TabIndex = 4;
            this.tabChiTieu.Text = "Chi tiêu";
            this.tabChiTieu.UseVisualStyleBackColor = true;
            // 
            // tabNhapHang
            // 
            this.tabNhapHang.Location = new System.Drawing.Point(4, 22);
            this.tabNhapHang.Name = "tabNhapHang";
            this.tabNhapHang.Size = new System.Drawing.Size(560, 351);
            this.tabNhapHang.TabIndex = 5;
            this.tabNhapHang.Text = "Nhập hàng";
            this.tabNhapHang.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 376);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Cửa hàng phụ tùng ôtô Hiền Nhi";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabDonHang;
        private System.Windows.Forms.TabPage tabNhapHang;
        private System.Windows.Forms.TabPage tabChiTieu;
    }
}