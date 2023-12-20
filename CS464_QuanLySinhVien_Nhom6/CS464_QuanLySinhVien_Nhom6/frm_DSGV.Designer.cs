namespace CS464_QuanLySinhVien_Nhom6
{
    partial class frm_DSGV
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
            this.dataGridDanhSachGiaoVien = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(702, 99);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_Xoa.TabIndex = 26;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(835, 99);
            this.btn_All.Margin = new System.Windows.Forms.Padding(4);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(140, 28);
            this.btn_All.TabIndex = 25;
            this.btn_All.Text = "Hiển thị danh sách";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(1011, 101);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(100, 28);
            this.btn_Dong.TabIndex = 24;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // dataGridDanhSachGiaoVien
            // 
            this.dataGridDanhSachGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDanhSachGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDanhSachGiaoVien.Location = new System.Drawing.Point(56, 151);
            this.dataGridDanhSachGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDanhSachGiaoVien.Name = "dataGridDanhSachGiaoVien";
            this.dataGridDanhSachGiaoVien.RowHeadersWidth = 51;
            this.dataGridDanhSachGiaoVien.Size = new System.Drawing.Size(1165, 398);
            this.dataGridDanhSachGiaoVien.TabIndex = 23;
            this.dataGridDanhSachGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDanhSachGiaoVien_CellClick);
            this.dataGridDanhSachGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDanhSachGiaoVien_CellContentClick);
            this.dataGridDanhSachGiaoVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDanhSachGiaoVien_CellDoubleClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(1011, 65);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 28);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(875, 63);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(100, 28);
            this.btn_Tim.TabIndex = 21;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Location = new System.Drawing.Point(588, 66);
            this.txt_MaGV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(277, 22);
            this.txt_MaGV.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã giáo viên";
            // 
            // frm_DSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 613);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.dataGridDanhSachGiaoVien);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_MaGV);
            this.Controls.Add(this.label1);
            this.Name = "frm_DSGV";
            this.Text = "frm_DSGV";
            this.Load += new System.EventHandler(this.frm_DSGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_Dong;
        public System.Windows.Forms.DataGridView dataGridDanhSachGiaoVien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_MaGV;
        private System.Windows.Forms.Label label1;
    }
}