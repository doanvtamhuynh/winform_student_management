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
    public partial class frm_DSDiemThi : Form
    {
        string loaitk,tentk;
        XuLyDuLieu xuly = new XuLyDuLieu();
        public frm_DSDiemThi(string loaitk,string tentk)
        {
            InitializeComponent();
            this.loaitk = loaitk;
            this.tentk = tentk;
        }

        private void frm_DSDiemThi_Load(object sender, EventArgs e)
        {
            if(loaitk == "sinhvien")
            {
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                dataGridDanhSachDiem.CellDoubleClick -= dataGridDanhSachDiem_CellDoubleClick;
            }
            LoadDiem();
        }

        public void LoadDiem()
        {
            dataGridDanhSachDiem.DataSource = null;
            dataGridDanhSachDiem.DataSource = xuly.LoadDL("selectAllDiem");
            dataGridDanhSachDiem.Columns["malophoc"].HeaderText = "Mã lớp học";
            dataGridDanhSachDiem.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dataGridDanhSachDiem.Columns["lanhoc"].HeaderText = "Lần học";
            dataGridDanhSachDiem.Columns["diemthilan1"].HeaderText = "Điểm thi lần 1 ";
            dataGridDanhSachDiem.Columns["diemthilan2"].HeaderText = "Điểm thi lần 2";

        }

        private void dataGridDanhSachDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSV.Text = dataGridDanhSachDiem.CurrentRow.Cells["masinhvien"].Value.ToString();
            txt_MaLop.Text = dataGridDanhSachDiem.CurrentRow.Cells["malophoc"].Value.ToString();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            LoadDiem();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn sinh viên '" + txt_MaSV.Text + "' của lớp '"+txt_MaLop.Text+"' không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dt)
            {
                int kq = xuly.ThemXoaSua("delete tblDiem where malophoc = '" + txt_MaLop.Text + "' and masinhvien = '"+txt_MaSV.Text+"'");
                if (kq >= 1)
                {
                    MessageBox.Show("Xoá sinh viên thành công");
                    LoadDiem();
                }
                else MessageBox.Show("Xoá xóa sinh viên thất bại");
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (txt_MaSV.Text == "" && txt_MaLop.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu tìm kiếm");
            }
            else if(txt_MaSV.Text == "")
            {
                dataGridDanhSachDiem.DataSource = xuly.LoadDL("select * from tblDiem where malophoc = '" + txt_MaLop.Text + "'");
            }else if (txt_MaLop.Text == "")
            {
                dataGridDanhSachDiem.DataSource = xuly.LoadDL("select * from tblDiem where  masinhvien = '" + txt_MaSV.Text + "'");
            }          
            else
            {
                dataGridDanhSachDiem.DataSource = xuly.LoadDL("select * from tblDiem where malophoc = '"+txt_MaLop.Text+"' and masinhvien = '"+txt_MaSV.Text+"'");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_Diem sv = new frm_Diem(null);
            sv.ShowDialog();
            LoadDiem();
        }

        private void dataGridDanhSachDiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var diem = dataGridDanhSachDiem.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                new frm_Diem(diem).ShowDialog();
                LoadDiem();
            }
        }
    }
}
