using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using DoAnThoiTrang;

namespace DoAnThoiTrang
{
    public class QuanLyNguoiDung
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.ChuoiKetNoi == string.Empty)
                return 1;
            SqlConnection _sqlCon = new SqlConnection(Properties.Settings.Default.ChuoiKetNoi);
            try
            {
                if (_sqlCon.State == System.Data.ConnectionState.Closed)
                    _sqlCon.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
               
        }
        public int Check_User(string pUser,string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from NHANVIEN where MANV='" + pUser + "' and MATKHAU ='" + pPass + "'",
            Properties.Settings.Default.ChuoiKetNoi);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 10;// User không tồn tại
            else if (dt.Rows[0][8] == null || dt.Rows[0][8].ToString() == "False")
            {
                return 20;// Không hoạt động
            }
            return 30;// Đăng nhập thành công
        }
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
            "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " +
            pPass + "");
            da.Fill(dt);
            return dt;
        }
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            DoAnThoiTrang.Properties.Settings.Default.ChuoiKetNoi = "Data Source=" + pServer +
            ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
            DoAnThoiTrang.Properties.Settings.Default.Save();
        }
    }
}
