using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_QuanLySinhVien_Nhom6
{
    public partial class frm_DoiMatKhau : Form
    {
        XuLyDuLieu xuly = new XuLyDuLieu();
        string loaitk, tentk;
        public frm_DoiMatKhau(string tentk)
        {
            InitializeComponent();
            this.tentk = tentk;
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            string nhapmk = txt_nhap.Text;
            string nhaplaimk = txt_nhaplai.Text;
            int kq = 0;
            if (nhapmk.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");                    
            }
            else
            {
                if (nhapmk == nhaplaimk)
                {
                    kq = xuly.ThemXoaSua("update TaiKhoan set matkhau = '" + nhapmk + "' where tentaikhoan = '" + tentk + "'" );
                    if(kq == 1) {
                        MessageBox.Show("Bạn đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không giống nhau");

                }
            }           
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
