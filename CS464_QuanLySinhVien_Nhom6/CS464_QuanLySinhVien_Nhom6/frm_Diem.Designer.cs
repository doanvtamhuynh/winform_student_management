namespace CS464_QuanLySinhVien_Nhom6
{
    partial class frm_Diem
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_LH1 = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lanHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_LH2 = new System.Windows.Forms.ComboBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cb_MaSV = new System.Windows.Forms.ComboBox();
            this.cb_MaLop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp học";
            // 
            // cb_LH1
            // 
            this.cb_LH1.FormattingEnabled = true;
            this.cb_LH1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_LH1.Location = new System.Drawing.Point(293, 205);
            this.cb_LH1.Name = "cb_LH1";
            this.cb_LH1.Size = new System.Drawing.Size(345, 24);
            this.cb_LH1.TabIndex = 1;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(294, 341);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(134, 39);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Lưu";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã sinh viên";
            // 
            // txt_lanHoc
            // 
            this.txt_lanHoc.Location = new System.Drawing.Point(293, 151);
            this.txt_lanHoc.Name = "txt_lanHoc";
            this.txt_lanHoc.Size = new System.Drawing.Size(345, 22);
            this.txt_lanHoc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lần học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Điểm lần 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Điểm lần 2";
            // 
            // cb_LH2
            // 
            this.cb_LH2.FormattingEnabled = true;
            this.cb_LH2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_LH2.Location = new System.Drawing.Point(293, 254);
            this.cb_LH2.Name = "cb_LH2";
            this.cb_LH2.Size = new System.Drawing.Size(345, 24);
            this.cb_LH2.TabIndex = 9;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(465, 341);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(134, 39);
            this.btn_Thoat.TabIndex = 11;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_MaSV
            // 
            this.cb_MaSV.FormattingEnabled = true;
            this.cb_MaSV.Location = new System.Drawing.Point(293, 101);
            this.cb_MaSV.Name = "cb_MaSV";
            this.cb_MaSV.Size = new System.Drawing.Size(345, 24);
            this.cb_MaSV.TabIndex = 13;
            // 
            // cb_MaLop
            // 
            this.cb_MaLop.FormattingEnabled = true;
            this.cb_MaLop.Location = new System.Drawing.Point(293, 52);
            this.cb_MaLop.Name = "cb_MaLop";
            this.cb_MaLop.Size = new System.Drawing.Size(345, 24);
            this.cb_MaLop.TabIndex = 12;
            // 
            // frm_Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.cb_MaSV);
            this.Controls.Add(this.cb_MaLop);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_LH2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_lanHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cb_LH1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Diem";
            this.Text = "frm_Diem";
            this.Load += new System.EventHandler(this.frm_Diem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_LH1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lanHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_LH2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox cb_MaSV;
        private System.Windows.Forms.ComboBox cb_MaLop;
    }
}