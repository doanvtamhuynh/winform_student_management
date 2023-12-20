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
    public partial class frm_DSM : Form
    {
        string loaitk;
        string tentk;
        XuLyDuLieu xuly = new XuLyDuLieu();
        public frm_DSM(string loaitk, string tentk)
        {
            InitializeComponent();
            this.loaitk = loaitk;
            this.tentk = tentk;
        }

        private void frm_DSM_Load(object sender, EventArgs e)
        {
            if (loaitk == "sinhvien" || loaitk == "giaovien")
            {
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                dataGridDanhSachMon.CellDoubleClick -= dataGridDanhSachMon_CellDoubleClick;
            }
            LoadMon();
        }

        public void LoadMon()
        {
            dataGridDanhSachMon.DataSource = null;
            dataGridDanhSachMon.DataSource = xuly.LoadDL("exec selectAllMonHoc");
            dataGridDanhSachMon.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dataGridDanhSachMon.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dataGridDanhSachMon.Columns["sotinchi"].HeaderText = "Số tín chỉ";
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            LoadMon();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn môn học '" + txt_MaMon.Text + "' không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dt)
            {
                int kq = xuly.ThemXoaSua("delete tblMonHoc where mamonhoc = '" + txt_MaMon.Text + "'");
                if (kq >= 1)
                {
                    MessageBox.Show("Xoá môn học thành công");
                    LoadMon();
                }
                else MessageBox.Show("Xoá môn học thất bại");
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (txt_MaMon.Text == "")
            {
                MessageBox.Show("Nhập mã môn học");
            }
            else
            {
                string ma = txt_MaMon.Text;
                dataGridDanhSachMon.DataSource = xuly.LoadDL("exec selectMon " + ma);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_MonHoc sv = new frm_MonHoc(null, tentk);
            sv.ShowDialog();
            LoadMon();
        }

        private void dataGridDanhSachMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMon.Text = dataGridDanhSachMon.CurrentRow.Cells["mamonhoc"].Value.ToString();
        }

        private void dataGridDanhSachMon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamon = dataGridDanhSachMon.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new frm_MonHoc(mamon, tentk).ShowDialog();
                LoadMon();
            }
        }
    }
}
