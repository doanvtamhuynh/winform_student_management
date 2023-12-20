namespace CS464_QuanLySinhVien_Nhom6
{
    partial class frm_DSDiemThi
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.dataGridDanhSachDiem = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(750, 80);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_Xoa.TabIndex = 34;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(883, 80);
            this.btn_All.Margin = new System.Windows.Forms.Padding(4);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(140, 28);
            this.btn_All.TabIndex = 33;
            this.btn_All.Text = "Hiển thị danh sách";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(1059, 82);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(100, 28);
            this.btn_Dong.TabIndex = 32;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // dataGridDanhSachDiem
            // 
            this.dataGridDanhSachDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDanhSachDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDanhSachDiem.Location = new System.Drawing.Point(40, 131);
            this.dataGridDanhSachDiem.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDanhSachDiem.Name = "dataGridDanhSachDiem";
            this.dataGridDanhSachDiem.RowHeadersWidth = 51;
            this.dataGridDanhSachDiem.Size = new System.Drawing.Size(1165, 398);
            this.dataGridDanhSachDiem.TabIndex = 31;
            this.dataGridDanhSachDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDanhSachDiem_CellClick);
            this.dataGridDanhSachDiem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDanhSachDiem_CellDoubleClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(1059, 46);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 28);
            this.btn_Them.TabIndex = 30;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(923, 44);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(100, 28);
            this.btn_Tim.TabIndex = 29;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(636, 47);
            this.txt_MaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(277, 22);
            this.txt_MaSV.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã sinh viên";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(225, 49);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(277, 22);
            this.txt_MaLop.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã lớp học";
            // 
            // frm_DSDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 609);
            this.Controls.Add(this.txt_MaLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.dataGridDanhSachDiem);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.label1);
            this.Name = "frm_DSDiemThi";
            this.Text = "frm_DSDiemThi";
            this.Load += new System.EventHandler(this.frm_DSDiemThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_Dong;
        public System.Windows.Forms.DataGridView dataGridDanhSachDiem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label label2;
    }
}