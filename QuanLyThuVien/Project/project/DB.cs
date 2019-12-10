//Tran Trong Qui
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace project
{
    public class DB
    {
        static string connectString = @"Data Source=.;Initial Catalog=QL_CUAHANGDTDD;Integrated Security=True";
        //static string connectString = @"Data Source=MAY14\SQLEXPRESS;Initial Catalog=QL_CUAHANGDTDD;Integrated Security=True";
        public static DataTable tableTruyVan(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                conn.Close();
                return table;
            }
        }
    }
}