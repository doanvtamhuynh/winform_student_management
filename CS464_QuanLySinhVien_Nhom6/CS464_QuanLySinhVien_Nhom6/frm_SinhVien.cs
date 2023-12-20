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
    public partial class frm_SinhVien : Form
    {
        XuLyDuLieu xuly = new XuLyDuLieu();
        public frm_SinhVien(string ma, string tentk)
        {
            this.ma = ma;
            InitializeComponent();
            this.tentk = tentk;
        }
        string ma;
        string tentk;
        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ma))
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật sinh viên";
                var r = new XuLyDuLieu().Select("selectSV '" + ma + "'");
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

                txt_QueQuan.Text = r["quequan"].ToString();
                txt_DiaChi.Text = r["diachi"].ToString();
                txt_DienThoai.Text = r["dienthoai"].ToString();
                txt_Email.Text = r["email"].ToString();

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            int kq;
            string sql = "";
            string ho = txt_Ho.Text;
            string tendem = txt_TenDem.Text;
            string ten = txt_Ten.Text;
            DateTime ngaysinh;

            try
            {
                ngaysinh = DateTime.ParseExact(mkt_ngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mkt_ngaysinh.Select();
                return;
            }
            string gioitinh = rd_Nam.Checked ? "1" : "0";
            string quequan = txt_QueQuan.Text;
            string diachi = txt_DiaChi.Text;
            string dienthoai = txt_DienThoai.Text;
            string email = txt_Email.Text;

            if (string.IsNullOrEmpty(ma))
            {
                kq = xuly.ThemXoaSua("insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh,quequan,diachi,dienthoai,email) values('SV' + CAST(next value for sinhvienSeq as varchar(30)), N'"+ho+"', N'"+tendem+"', N'"+ten+"', '"+ngaysinh+"', '"+gioitinh+"', N'"+quequan+"', N'"+diachi+"', '"+dienthoai+"', '"+email+"')");
                
            }
            else
            {
                kq = xuly.ThemXoaSua("exec updateSV '"+ma+ "',N'"+ho+"', N'"+tendem+"', N'"+ten+"', '"+ngaysinh+"', '"+gioitinh+"', N'"+quequan+"', N'"+diachi+"', '"+dienthoai+"', '"+email+"'    ");
                
            }


            if (kq == 1)
            {
                if (string.IsNullOrEmpty(ma))
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
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
