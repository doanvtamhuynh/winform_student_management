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
    public partial class frm_Main : Form
    {
        string loaitk,tentk;
        public frm_Main(string loaitk,string tentk)
        {
            InitializeComponent();
            this.loaitk = loaitk;
            this.tentk = tentk;
        }

        XuLyDuLieu xuly = new XuLyDuLieu();
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            if(loaitk == "giaovien")
            {
                btn_ThemTaiKhoan.Enabled = false;
                this.Text = "Hệ thống giáo viên";
            }
            if(loaitk == "sinhvien")
            {
                btn_ThemTaiKhoan.Enabled=false;
                this.Text = "Hệ thống sinh viên";
            }
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DSSV ds = new frm_DSSV(loaitk,tentk);
            ds.MdiParent = this;
            ds.Show();
            ds.Text = "Danh sách sinh viên";            
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DSM ds = new frm_DSM(loaitk, tentk);
            ds.MdiParent = this;
            ds.Show();
            ds.Text = "Danh sách môn học";
            

        }

        private void sinhVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_DSGV ds = new frm_DSGV(loaitk, tentk);
            ds.MdiParent = this;
            ds.Show();
            ds.Text = "Danh sách giáo viên";           

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            frm_DangNhap dn = new frm_DangNhap();
            dn.Show();
        }

        private void diemThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DSDiemThi ds = new frm_DSDiemThi(loaitk, tentk);
            ds.MdiParent = this;
            ds.Show();
            ds.Text = "Danh sách điểm thi";
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThemTaiKhoan them = new frm_ThemTaiKhoan();
            them.MdiParent = this;
            them.Show();
        }

        private void lophocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DSLopHoc ds = new frm_DSLopHoc(loaitk, tentk);
            ds.MdiParent = this;
            ds.Show();
            ds.Text = "Danh sách lớp";
        }

        private void troGiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TroGiup tg = new frm_TroGiup();
            tg.MdiParent = this;
            tg.Text = "Trợ giúp";
            tg.Show();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau doi = new frm_DoiMatKhau(tentk);
            doi.MdiParent = this;
            doi.Show();
        }
    }
}
