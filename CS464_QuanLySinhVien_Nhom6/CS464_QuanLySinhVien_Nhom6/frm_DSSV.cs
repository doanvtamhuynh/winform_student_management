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
    public partial class frm_DSSV : Form
    {
        string loaitk;
        string tentk;
        XuLyDuLieu xuly = new XuLyDuLieu();
        public frm_DSSV(string loaitk, string tentk)
        {
            InitializeComponent();
            this.loaitk = loaitk;
            this.tentk = tentk;
        }
        private void dataGridDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dataGridDanhSach.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                new frm_SinhVien(msv, tentk).ShowDialog();
                LoadSinhVien();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_SinhVien sv = new frm_SinhVien(null, tentk);
            sv.ShowDialog();
            LoadSinhVien() ;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (txt_MaSV.Text == "")
            {
                MessageBox.Show("Nhập mã sinh viên");
            }
            else
            {
                string ma = txt_MaSV.Text;
                dataGridDanhSach.DataSource = xuly.LoadDL("exec selectSV " + ma);
            }
        }

        private void dataGridDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSV.Text = dataGridDanhSach.CurrentRow.Cells["masinhvien"].Value.ToString();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            LoadSinhVien();
        }

        private void frm_DSSV_Load(object sender, EventArgs e)
        {
            if (loaitk == "sinhvien")
            {
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                dataGridDanhSach.CellDoubleClick -= dataGridDanhSach_CellDoubleClick;
            }
            LoadSinhVien();
        }
        public void LoadSinhVien()
        {
            dataGridDanhSach.DataSource = null;
            dataGridDanhSach.DataSource = xuly.LoadDL("exec SelectAllSinhVien");
            dataGridDanhSach.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dataGridDanhSach.Columns["hoten"].HeaderText = "Họ tên";
            dataGridDanhSach.Columns["nsinh"].HeaderText = "Ngày sinh";
            dataGridDanhSach.Columns["gt"].HeaderText = "Giới tính";
            dataGridDanhSach.Columns["quequan"].HeaderText = "Quê quán";
            dataGridDanhSach.Columns["diachi"].HeaderText = "Địa chỉ";
            dataGridDanhSach.Columns["dienthoai"].HeaderText = "Điện thoại";
            dataGridDanhSach.Columns["email"].HeaderText = "Email";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn xóa sinh viên '"+txt_MaSV.Text+"' không?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DialogResult.Yes == dt)
            {
                int kq = xuly.ThemXoaSua("delete tblSinhVien where masinhvien = '" + txt_MaSV.Text + "'");
                if (kq >= 1)
                {
                    MessageBox.Show("Xoá sinh viên thành công");
                    LoadSinhVien();
                }
                else MessageBox.Show("Xoá sinh viên thất bại");
            }
            
        }
    }
}
