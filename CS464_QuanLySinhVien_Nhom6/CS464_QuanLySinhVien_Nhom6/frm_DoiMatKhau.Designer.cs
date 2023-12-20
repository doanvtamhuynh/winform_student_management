namespace CS464_QuanLySinhVien_Nhom6
{
    partial class frm_DoiMatKhau
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
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.btn_DoiMK = new System.Windows.Forms.Button();
            this.txt_nhaplai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Thoát = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu mới";
            // 
            // txt_nhap
            // 
            this.txt_nhap.Location = new System.Drawing.Point(305, 80);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(303, 22);
            this.txt_nhap.TabIndex = 1;
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.Location = new System.Drawing.Point(238, 233);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(127, 51);
            this.btn_DoiMK.TabIndex = 2;
            this.btn_DoiMK.Text = "Đổi MK";
            this.btn_DoiMK.UseVisualStyleBackColor = true;
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMK_Click);
            // 
            // txt_nhaplai
            // 
            this.txt_nhaplai.Location = new System.Drawing.Point(305, 135);
            this.txt_nhaplai.Name = "txt_nhaplai";
            this.txt_nhaplai.Size = new System.Drawing.Size(303, 22);
            this.txt_nhaplai.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // btn_Thoát
            // 
            this.btn_Thoát.Location = new System.Drawing.Point(411, 233);
            this.btn_Thoát.Name = "btn_Thoát";
            this.btn_Thoát.Size = new System.Drawing.Size(122, 51);
            this.btn_Thoát.TabIndex = 5;
            this.btn_Thoát.Text = "Thoát";
            this.btn_Thoát.UseVisualStyleBackColor = true;
            this.btn_Thoát.Click += new System.EventHandler(this.btn_Thoát_Click);
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoát);
            this.Controls.Add(this.txt_nhaplai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DoiMK);
            this.Controls.Add(this.txt_nhap);
            this.Controls.Add(this.label1);
            this.Name = "frm_DoiMatKhau";
            this.Text = "frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.frm_DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.Button btn_DoiMK;
        private System.Windows.Forms.TextBox txt_nhaplai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Thoát;
    }
}