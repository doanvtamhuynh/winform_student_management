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
    public partial class frm_DangNhap : Form
    {
        XuLyDuLieu xuly = new XuLyDuLieu();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select COUNT (*) from TaiKhoan where tentaikhoan = '" + txt_TK.Text + "' and matkhau = '" + txt_MK.Text + "' and loaitaikhoan = '"+ cb_loaiTK.Text + "'";
            int kq = (int)xuly.Scalar(sql);
            if (kq >= 1)
            {
                frm_Main sv = new frm_Main(cb_loaiTK.Text,txt_TK.Text);
                sv.Show();
                this.Hide();
            }
            else MessageBox.Show("Bạn nhập sai tên hoặc mật khẩu");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
