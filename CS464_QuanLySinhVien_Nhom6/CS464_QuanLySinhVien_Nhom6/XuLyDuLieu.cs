using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CS464_QuanLySinhVien_Nhom6
{
    internal class XuLyDuLieu
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt;
        public XuLyDuLieu()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CS464_QuanLySinhVien_Nhom6\CS464_QuanLySinhVien_Nhom6\CS464_QuanLySinhVien_Nhom6\Database\quanlysinhvien.mdf;Integrated Security=True");
        }
        public int ThemXoaSua(string sql)
        {
            int kq;
            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                kq = comm.ExecuteNonQuery();
            }
            catch
            {
                kq = 0;
            }
            finally
            {
                conn.Close();
            }
            return kq;
        }
        public object Scalar(string sql)
        {
            object kq;
            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                kq = comm.ExecuteScalar();
            }
            catch
            {
                kq = 0;
            }
            finally
            {
                conn.Close();
            }
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close ();
            }
        }

        
        

    }
}
