namespace CS464_QuanLySinhVien_Nhom6
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ThemTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SV = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_MonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_GiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_DiemThi = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_LopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_HeThong,
            this.quảnLýToolStripMenuItem,
            this.troGiupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btn_HeThong
            // 
            this.btn_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ThemTaiKhoan,
            this.btn_DoiMK,
            this.btn_Thoat});
            this.btn_HeThong.Name = "btn_HeThong";
            this.btn_HeThong.Size = new System.Drawing.Size(85, 24);
            this.btn_HeThong.Text = "Hệ thống";
            // 
            // btn_ThemTaiKhoan
            // 
            this.btn_ThemTaiKhoan.Name = "btn_ThemTaiKhoan";
            this.btn_ThemTaiKhoan.Size = new System.Drawing.Size(224, 26);
            this.btn_ThemTaiKhoan.Text = "Thêm tài khoản";
            this.btn_ThemTaiKhoan.Click += new System.EventHandler(this.thêmTàiKhoảnToolStripMenuItem_Click);
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(224, 26);
            this.btn_DoiMK.Text = "Đổi mật khẩu";
            this.btn_DoiMK.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(224, 26);
            this.btn_Thoat.Text = "Đăng xuất";
            this.btn_Thoat.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_SV,
            this.btn_MonHoc,
            this.btn_GiaoVien,
            this.btn_DiemThi,
            this.btn_LopHoc});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // btn_SV
            // 
            this.btn_SV.Name = "btn_SV";
            this.btn_SV.Size = new System.Drawing.Size(154, 26);
            this.btn_SV.Text = "Sinh viên";
            this.btn_SV.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click);
            // 
            // btn_MonHoc
            // 
            this.btn_MonHoc.Name = "btn_MonHoc";
            this.btn_MonHoc.Size = new System.Drawing.Size(154, 26);
            this.btn_MonHoc.Text = "Môn học";
            this.btn_MonHoc.Click += new System.EventHandler(this.monHocToolStripMenuItem_Click);
            // 
            // btn_GiaoVien
            // 
            this.btn_GiaoVien.Name = "btn_GiaoVien";
            this.btn_GiaoVien.Size = new System.Drawing.Size(154, 26);
            this.btn_GiaoVien.Text = "Giáo viên";
            this.btn_GiaoVien.Click += new System.EventHandler(this.sinhVienToolStripMenuItem1_Click);
            // 
            // btn_DiemThi
            // 
            this.btn_DiemThi.Name = "btn_DiemThi";
            this.btn_DiemThi.Size = new System.Drawing.Size(154, 26);
            this.btn_DiemThi.Text = "Điểm thi";
            this.btn_DiemThi.Click += new System.EventHandler(this.diemThiToolStripMenuItem_Click);
            // 
            // btn_LopHoc
            // 
            this.btn_LopHoc.Name = "btn_LopHoc";
            this.btn_LopHoc.Size = new System.Drawing.Size(154, 26);
            this.btn_LopHoc.Text = "Lớp học";
            this.btn_LopHoc.Click += new System.EventHandler(this.lophocToolStripMenuItem_Click);
            // 
            // troGiupToolStripMenuItem
            // 
            this.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            this.troGiupToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.troGiupToolStripMenuItem.Text = "Trợ giúp";
            this.troGiupToolStripMenuItem.Click += new System.EventHandler(this.troGiupToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frm_Main";
            this.Text = "Hệ thống admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_HeThong;
        private System.Windows.Forms.ToolStripMenuItem btn_DoiMK;
        private System.Windows.Forms.ToolStripMenuItem btn_Thoat;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_SV;
        private System.Windows.Forms.ToolStripMenuItem btn_MonHoc;
        private System.Windows.Forms.ToolStripMenuItem btn_GiaoVien;
        private System.Windows.Forms.ToolStripMenuItem btn_DiemThi;
        private System.Windows.Forms.ToolStripMenuItem troGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_ThemTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem btn_LopHoc;
    }
}