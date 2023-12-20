using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_QuanLySinhVien_Nhom6
{
    public partial class frm_GiaoVien : Form
    {
        XuLyDuLieu xuly = new XuLyDuLieu();
        string ma;
        string tentk;
        public frm_GiaoVien(string ma, string tentk)
        {
            this.ma = ma;
            InitializeComponent();
            this.tentk = tentk;
        }

        private void frm_GiaoVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ma))
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật giáo viên";
                var r = new XuLyDuLieu().Select("selectGV " + int.Parse(ma) + "");
                txt_Ho.Text = r["ho"].ToString();
                txt_TenDem.Text = r["tendem"].ToString();
                txt_Ten.Text = r["ten"].ToString();
                mkt_ngaysinh.Text = r["ngsinh"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1)
                {
                    rd_Nam.Checked = true;
                }
                else
                {
                    rd_Nu.Checked = true;
                }

                txt_DiaChi.Text = r["diachi"].ToString();
                txt_DienThoai.Text = r["dienthoai"].ToString();
                txt_Email.Text = r["email"].ToString();

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            int kq;
            string ho = txt_Ho.Text;
            string tendem = txt_TenDem.Text;
            string ten = txt_Ten.Text;
            string gioitinh = rd_Nam.Checked ? "1" : "0";
            DateTime ngaysinh;

            try
            {
                ngaysinh = DateTime.ParseExact(mkt_ngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mkt_ngaysinh.Select();
                return;
            }            
            string dienthoai = txt_DienThoai.Text;
            string email = txt_Email.Text;
            string diachi = txt_DiaChi.Text;

            if (string.IsNullOrEmpty(ma))
            {
                kq = xuly.ThemXoaSua("insert into tblGiaoVien(nguoitao,ho,tendem,ten,gioitinh,ngaysinh,dienthoai,email,diachi) values('"+tentk+"',N'" + ho + "',N'" + tendem + "',N'" + ten + "','" + gioitinh + "','" + ngaysinh + "','" + dienthoai + "','" + email + "',N'" + diachi + "')  ");

            }
            else
            {
                kq = xuly.ThemXoaSua("exec updateGV '" + int.Parse(ma) + "',N'" + ho + "', N'" + tendem + "', N'" + ten + "', '" + gioitinh + "', '" + ngaysinh + "', N'" + dienthoai + "', N'" + email + "', N'" + diachi + "'    ");

            }


            if (kq == 1)
            {
                if (string.IsNullOrEmpty(ma))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật sinh viên thành công");

                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực hiện thất bại");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
