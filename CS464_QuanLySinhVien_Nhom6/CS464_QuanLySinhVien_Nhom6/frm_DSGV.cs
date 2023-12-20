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
    public partial class frm_DSGV : Form
    {
        string loaitk, tentk;
        XuLyDuLieu xuly = new XuLyDuLieu();
        public frm_DSGV(string loaitk,string tentk)
        {
            InitializeComponent();
            this.loaitk = loaitk;
            this.tentk = tentk;
        }

        private void frm_DSGV_Load(object sender, EventArgs e)
        {
            if (loaitk == "sinhvien" || loaitk == "giaovien")
            {
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                dataGridDanhSachGiaoVien.CellDoubleClick -= dataGridDanhSachGiaoVien_CellDoubleClick;
            }
            LoadDSGV();
        }
        public void LoadDSGV()
        {
            dataGridDanhSachGiaoVien.DataSource = null;
            dataGridDanhSachGiaoVien.DataSource = xuly.LoadDL("exec selectAllGiaoVien");
            dataGridDanhSachGiaoVien.Columns["magiaovien"].HeaderText = "Mã sinh viên";
            dataGridDanhSachGiaoVien.Columns["hoten"].HeaderText = "Họ tên";
            dataGridDanhSachGiaoVien.Columns["gt"].HeaderText = "Giới tính";
            dataGridDanhSachGiaoVien.Columns["nsinh"].HeaderText = "Ngày sinh";
            dataGridDanhSachGiaoVien.Columns["dienthoai"].HeaderText = "Điện thoại";
            dataGridDanhSachGiaoVien.Columns["email"].HeaderText = "Email";
            dataGridDanhSachGiaoVien.Columns["diachi"].HeaderText = "Địa chỉ";
        }

        private void dataGridDanhSachGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGV.Text = dataGridDanhSachGiaoVien.CurrentRow.Cells["magiaovien"].Value.ToString();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if(txt_MaGV.Text == "")
            {
                MessageBox.Show("Nhập mã giáo viên");
            }
            else
            {
                int ma = int.Parse(txt_MaGV.Text);
                dataGridDanhSachGiaoVien.DataSource = xuly.LoadDL("exec selectGV " + ma);
            }          
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_GiaoVien sv = new frm_GiaoVien(null,tentk);
            sv.ShowDialog();
            LoadDSGV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn giáo viên '" + txt_MaGV.Text + "' không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dt)
            {
                int kq = xuly.ThemXoaSua("delete tblGiaoVien where magiaovien = '" + txt_MaGV.Text + "'");
                if (kq >= 1)
                {
                    MessageBox.Show("Xoá giáo viên thành công");
                    LoadDSGV();
                }
                else MessageBox.Show("Xoá giáo viên thất bại");
            }
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            LoadDSGV();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridDanhSachGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridDanhSachGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dataGridDanhSachGiaoVien.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frm_GiaoVien(mgv,tentk).ShowDialog();
                LoadDSGV() ;
            }
        }
    }
}
