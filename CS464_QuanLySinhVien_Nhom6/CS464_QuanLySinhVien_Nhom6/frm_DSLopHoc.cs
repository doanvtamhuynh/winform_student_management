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
    public partial class frm_DSLopHoc : Form
    {
        string loaitk,tentk;
        XuLyDuLieu xuly = new XuLyDuLieu();
        public frm_DSLopHoc(string loaitk,string tentk)
        {
            InitializeComponent();
            this.loaitk = loaitk;
            this.tentk = tentk;
        }

        private void frm_DSLopHoc_Load(object sender, EventArgs e)
        {
            if (loaitk == "sinhvien" || loaitk == "giaovien")
            {
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                dataGridDanhSachLop.CellDoubleClick -= dataGridDanhSachLop_CellDoubleClick;
            }
            Loadlop();
        }
        public void Loadlop()
        {
            dataGridDanhSachLop.DataSource = null;
            dataGridDanhSachLop.DataSource = xuly.LoadDL("select tblLop.malophoc as malophoc,tblLop.magiaovien as magiaovien,tblLop.mamonhoc as mamonhoc,tblMonHoc.tenmonhoc as tenmon,\r\ncase\r\nwhen len(tblGiaoVien.tendem) > 0 then\r\nconcat(tblGiaoVien.ho,' ',tblGiaoVien.tendem,' ',tblGiaoVien.ten)\r\nelse concat (tblGiaoVien.ho,' ',tblGiaoVien.ten)\r\nend as hoten\r\nfrom tblLop,tblGiaoVien,tblMonHoc\r\nwhere tblLop.magiaovien = tblGiaoVien.magiaovien and tblLop.mamonhoc = tblMonHoc.mamonhoc");
            dataGridDanhSachLop.Columns["malophoc"].HeaderText = "Mã lớp học";
            dataGridDanhSachLop.Columns["magiaovien"].HeaderText = "Mã giáo viên";
            dataGridDanhSachLop.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dataGridDanhSachLop.Columns["tenmon"].HeaderText = "Tên môn học";
            dataGridDanhSachLop.Columns["hoten"].HeaderText = "Tên giáo viên";

        }

        private void dataGridDanhSachLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLop.Text = dataGridDanhSachLop.CurrentRow.Cells["malophoc"].Value.ToString();
        }

        private void dataGridDanhSachLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dataGridDanhSachLop.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                new frm_LopHoc(msv, tentk).ShowDialog();
                Loadlop();
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            Loadlop();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (txt_MaLop.Text == "")
            {
                MessageBox.Show("Nhập mã lớp");
            }
            else
            {
                string ma = txt_MaLop.Text;
                dataGridDanhSachLop.DataSource = xuly.LoadDL("exec selectLop " + int.Parse(ma));
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn xóa lớp học '" + txt_MaLop.Text + "' không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dt)
            {
                int kq = xuly.ThemXoaSua("delete tblLop where malophoc = '" + txt_MaLop.Text + "'");
                if (kq >= 1)
                {
                    MessageBox.Show("Xoá lớp thành công");
                    Loadlop();
                }
                else MessageBox.Show("Xoá lớp thất bại");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_LopHoc sv = new frm_LopHoc(null, tentk);
            sv.ShowDialog();
            Loadlop();
        }
    }
}
