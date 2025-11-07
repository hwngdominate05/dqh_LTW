using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBanHang.Classes
{
    internal class ConnectDataBase
    {
        SqlConnection sqlconnect = null;
        string strConnect = "Server=DESKTOP-LJTIROB;DataBase=QLBanHang; Intergrated Security = True";
        /* Các bước làm việc với ADO.NET
         * 1. Khai báo chuỗi kết nối
         * 2. Mở kết nối
         * 3. Khai báo lệnh sql
         * 4. Thực thi lệnh sql
         * 5. Đóng kết quả nối và hủy các đối tượng không cần thiết
         */
        //create a method to connect a DB
        void OpenConnect()
        {
            sqlconnect = new SqlConnection(strConnect);
            if (sqlconnect.State != ConnectionState.Open)
            {
                sqlconnect.Open();
            }
        }

        //create a disconnection method to DB
        void CloseConnect()
        {
            if (sqlconnect.State != ConnectionState.Closed)
            {
                sqlconnect.Close();
                sqlconnect.Dispose();
            }
        }

        //create a method to execute sql command
        public DataTable ReadData(string selectSql)
        {
            DataTable dt = new DataTable();
            //B1, B2
            OpenConnect();
            //B3: khai báo lệnh sql
            //B4: Thực thi sql
            SqlDataAdapter adapter = new SqlDataAdapter(selectSql,sqlconnect);
            adapter.Fill(dt);
            //B5
            CloseConnect();
            adapter.Dispose();
            return dt;
        }
        //Insert, Update, Delete command
        public void UpdateData(string sql)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = sqlconnect;
            cmd.ExecuteNonQuery();
            CloseConnect();
            cmd.Dispose();


        }

    }
}
