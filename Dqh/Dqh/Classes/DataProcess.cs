using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dqh.Classes
{
    internal class DataProcess
    {
        string strConnect = "Data Source = DESKTOP-LJTIROB\\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True";
        SqlConnection sqlConnect = null;
        // Ham mo ket noi
        private void ConnectDB()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
            {
                sqlConnect.Open();
            }
        }
        // Ham dong ket noi
        private void DisconnectDB()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
            }
            sqlConnect.Dispose();
        }
        // Ham thuc thi cau lenh select
        public DataTable ReadTable(string sql)
        {
            DataTable table = new DataTable();
            ConnectDB();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnect);
            adapter.Fill(table);
            DisconnectDB();
            return table;
        }
        // Ham thuc thi cau lenh update, delete
        public void UpdateDB(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnect;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DisconnectDB();
            cmd.Dispose();
        }

    }
}

