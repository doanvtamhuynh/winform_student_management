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
    public partial class frm_LopHoc : Form
    {
        XuLyDuLieu xuly = new XuLyDuLieu();
        string ma;
        string tentk;
        public frm_LopHoc(string ma, string tentk)
        {
            InitializeComponent();
            this.ma = ma;
            this.tentk = tentk;
        }

        private void frm_LopHoc_Load(object sender, EventArgs e)
        {
            cb_monHoc.DataSource = xuly.LoadDL("select * from tblMonHoc");
            cb_monHoc.DisplayMember = "tenmonhoc";
            cb_monHoc.ValueMember = "mamonhoc";
            cb_monHoc.SelectedIndex = -1;
            cb_giaoVien.DataSource = xuly.LoadDL("exec selectAllGiaoVien");
            cb_giaoVien.DisplayMember = "hoten";
            cb_giaoVien.ValueMember = "magiaovien";
            cb_giaoVien.SelectedIndex = -1;

            if (string.IsNullOrEmpty(ma))
            {
                this.Text = "Thêm mới lớp";
            }
            else
            {
                this.Text = "Cập nhật lớp";
                var r = xuly.Select("exec selectLop '"+ma+"'");
                cb_giaoVien.SelectedValue = r["magiaovien"].ToString();
                cb_monHoc.SelectedValue = r["mamonhoc"].ToString() ;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int kq;            
            string magiaovien = cb_giaoVien.SelectedValue.ToString();
            string mamonhoc = cb_monHoc.SelectedValue.ToString();
            if (string.IsNullOrEmpty(ma))
            {
                
                kq = xuly.ThemXoaSua("insert into tblLop(nguoitao,mamonhoc,magiaovien) values('"+tentk+"','" + int.Parse(magiaovien) + "','" + int.Parse(mamonhoc) + "')  ");

            }
            else
            {
                kq = xuly.ThemXoaSua("update tblLop set  nguoicapnhat = '"+tentk+"' ,  mamonhoc = '"+int.Parse(mamonhoc)+"', magiaovien = "+int.Parse(magiaovien)+" where malophoc = '"+int.Parse(ma)+"'");

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
