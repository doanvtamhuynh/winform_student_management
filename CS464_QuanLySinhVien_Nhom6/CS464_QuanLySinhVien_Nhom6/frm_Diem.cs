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
    public partial class frm_Diem : Form
    {
        XuLyDuLieu xuly = new XuLyDuLieu();
        string ma;
        public frm_Diem(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Diem_Load(object sender, EventArgs e)
        {
            cb_MaSV.DataSource = xuly.LoadDL("exec selectAllSinhVien");
            cb_MaSV.DisplayMember = "masinhvien";
            cb_MaSV.ValueMember = "hoten";
            cb_MaSV.SelectedIndex = -1;
            cb_MaLop.DataSource = xuly.LoadDL("select * from tblLop");
            cb_MaLop.DisplayMember = "malophoc";
            cb_MaLop.ValueMember = "malophoc";
            cb_MaLop.SelectedIndex = -1;
            if (string.IsNullOrEmpty(ma))
            {
                this.Text = "Thêm điểm";
            }
            else
            {
                this.Text = "Cập nhật điểm";
                var r = xuly.Select("select * from tblDiem");
                cb_MaSV.Text = r["masinhvien"].ToString();
                cb_MaLop.SelectedValue = r["malophoc"].ToString();
                txt_lanHoc.Text = r["lanhoc"].ToString();
                cb_LH1.Text = r["diemthilan1"].ToString();
                cb_LH2.Text = r["diemthilan2"].ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int kq;            

            if (string.IsNullOrEmpty(ma))
            {
                kq = xuly.ThemXoaSua("insert into tblDiem(malophoc,masinhvien,lanhoc,diemthilan1,diemthilan2) values('" + int.Parse(cb_MaLop.Text) + "','" + cb_MaSV.Text + "','" + int.Parse(txt_lanHoc.Text) + "','" + int.Parse(cb_LH1.Text) + "','" + int.Parse(cb_LH2.Text) + "')  ");

            }
            else
            {
                kq = xuly.ThemXoaSua(" update tblDiem set malophoc = '"+int.Parse(cb_MaLop.Text)+"', lanhoc = '"+int.Parse(txt_lanHoc.Text)+"', diemthilan1 = '"+int.Parse(cb_LH1.Text)+"', diemthilan2 = '"+int.Parse(cb_LH2.Text)+"' where masinhvien = '"+cb_MaSV.Text+"'   ");

            }


            if (kq == 1)
            {
                if (string.IsNullOrEmpty(ma))
                {
                    MessageBox.Show("Thêm mới điểm thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật điểm thành công");

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
