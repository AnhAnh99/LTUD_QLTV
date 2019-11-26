using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    class connectDB
    {
      
        //Kết nối SQL
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-9OUV00A\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");
        //kai bao dataTable
        DataTable dt; // 3

        //Load
        public void loadBD(DataGridView _dvgBanDoc)
        {
            //try-catch-finnaly
            //try: if
            //catch: tb lỗi k kết nối
            //finally: đóng kết nối
            try
            {
                if (connect.State == ConnectionState.Closed) //đóng
                {
                    connect.Open(); //mở
                    string sql = "SP_LOAD_KHACHHANG"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dvgBanDoc.DataSource = dt; //dgv.soure = table
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message); // lỗi
            }
            finally
            {
                connect.Close(); // đóng
            }
        }

        //Thêm sách vào thư viện
        public void themBD(string maBD, string tenBD, string diaChi, string soDienThoai, string ngayMuon,string ngayTra)        {
            //try-catch-finnaly
            //try: if
            //catch: tb lỗi k kết nối
            //finally: đóng kết nối
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_THEM_KHACHHANG";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaKhachHang", SqlDbType.NVarChar)).Value = maBD;
                    command.Parameters.Add(new SqlParameter("TenKhachHang", SqlDbType.NVarChar)).Value = tenBD;
                    command.Parameters.Add(new SqlParameter("DiaChiKH", SqlDbType.NVarChar)).Value = diaChi;
                    command.Parameters.Add(new SqlParameter("SoDienThoaiKH", SqlDbType.NVarChar)).Value = soDienThoai;
                    command.Parameters.Add(new SqlParameter("NgayDK", SqlDbType.NVarChar)).Value = ngayMuon;
                    command.Parameters.Add(new SqlParameter("NgayHetHan", SqlDbType.NVarChar)).Value = ngayTra;

                    command.ExecuteNonQuery(); //thực thi

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        //Xóa danh sách
        public void xoaBD(string maBD)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_XOA_KHACHHANG";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaKhachHang", SqlDbType.NVarChar)).Value = maBD;

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        //Sưa
        public void suaBD(string maBD, string tenBD, string diaChi, string soDienThoai, string ngayMuon, string ngayTra)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_SUA_KHACHHANG";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaKhachHang", SqlDbType.NVarChar)).Value = maBD;
                    command.Parameters.Add(new SqlParameter("TenKhachHang", SqlDbType.NVarChar)).Value = tenBD;
                    command.Parameters.Add(new SqlParameter("DiaChiKH", SqlDbType.NVarChar)).Value = diaChi;
                    command.Parameters.Add(new SqlParameter("SoDienThoaiKH", SqlDbType.NVarChar)).Value = soDienThoai;
                    command.Parameters.Add(new SqlParameter("NgayDK", SqlDbType.NVarChar)).Value = ngayMuon;
                    command.Parameters.Add(new SqlParameter("NgayHetHan", SqlDbType.NVarChar)).Value = ngayTra;

                    command.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        //tìm kiếm
        public void timKiemBD(string maBD)
        {

            //try-catch-finnaly
            //try: if
            //catch: tb lỗi k kết nối
            //finally: đóng kết nối
            try
            {
                if (connect.State == ConnectionState.Closed) 
                {
                    connect.Open(); //mở
                    string sql = "SP_TIMKIEM_KHACHHANG";
                    SqlCommand command = new SqlCommand(sql, connect); 
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaKhachHang", SqlDbType.NVarChar)).Value = maBD;

                    command.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message); // lỗi
            }
            finally
            {
                connect.Close(); // đóng
            }
        }
    }
}
