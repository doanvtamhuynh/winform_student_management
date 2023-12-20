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
    public partial class frm_ThemTaiKhoan : Form
    {
        XuLyDuLieu xuly = new XuLyDuLieu();
        public frm_ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TK.Text.Length != 0 && txt_MK.Text.Length != 0 && cb_loaiTK.Text.Length != 0)
            {
                int kq = xuly.ThemXoaSua("insert into TaiKhoan values ('" + txt_TK.Text + "','" + txt_MK.Text + "','" + cb_loaiTK.Text + "') ");
                if (kq >= 1)
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            
        }

        private void frm_ThemTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
