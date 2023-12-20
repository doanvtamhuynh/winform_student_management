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
    
    public partial class frm_MonHoc : Form
    {
        XuLyDuLieu xuly = new XuLyDuLieu();
        string ma;
        string tentk;
        public frm_MonHoc(string ma, string tentk)
        {
            this.ma = ma;
            InitializeComponent();
            this.tentk = tentk;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ma))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật môn học";
                var r = new XuLyDuLieu().Select("selectMon " + int.Parse(ma) + "");
                txt_TenMon.Text = r["tenmonhoc"].ToString();
                txt_SoTC.Text = r["sotinchi"].ToString();                

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            int kq;
            string tenmon = txt_TenMon.Text;

            string sotinchi = txt_SoTC.Text;           

            if (string.IsNullOrEmpty(ma))
            {
                if(sotinchi == "")
                {
                    sotinchi = "0";
                }
                kq = xuly.ThemXoaSua("insert into tblMonHoc(nguoitao,tenmonhoc,sotinchi) values('"+tentk+"',N'" + tenmon + "','"+int.Parse(sotinchi)+"')  ");

            }
            else
            {
                kq = xuly.ThemXoaSua("exec updateMon '" + int.Parse(ma) + "',N'" + tenmon + "', '" + int.Parse(sotinchi) + "'");

            }


            if (kq == 1)
            {
                if (string.IsNullOrEmpty(ma))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật môn học thành công");

                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực hiện thất bại");
            }
        }
    }
}
