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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9OUV00A\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
        //kai bao dataTable
        DataTable dt; // 3

        /// <summary>
        /// BẠN ĐỌC
        /// </summary>
        /// <param name="_dvgBanDoc"></param>
        //Load
        public void loadBD(DataGridView _dvgBanDoc)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) //đóng
                {
                    conn.Open(); //mở
                    string sql = "SP_LOAD_KHACHHANG"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, conn); //command kb                  
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
                conn.Close(); // đóng
            }
        }
        //Thêm 
        public void themBD(string maBD, string tenBD, string diaChi, string soDienThoai, string ngayMuon,string ngayTra)        {
           
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SP_THEM_KHACHHANG";
                    SqlCommand command = new SqlCommand(sql, conn);
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
                conn.Close();
            }
        }
        //Xóa 
        public void xoaBD(string maBD)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SP_XOA_KHACHHANG";
                    SqlCommand command = new SqlCommand(sql, conn);
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
                conn.Close();
            }
        }
        //Sưa
        public void suaBD(string maBD, string tenBD, string diaChi, string soDienThoai, string ngayMuon, string ngayTra)
        {

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SP_SUA_KHACHHANG";
                    SqlCommand command = new SqlCommand(sql, conn);
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
                conn.Close();
            }
        }
        //tìm kiếm
        public DataTable timKiemBD(string chuoiTimKiem)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SP_TIMKIEM_KHACH_HANG", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaKhachHang", chuoiTimKiem);

                DataTable dtTable = new DataTable();
                SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                dtAdapter.Fill(dtTable);
                return dtTable;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// SÁCH
        /// </summary>
        /// <param name="_dvgSachTV"></param>
        //load
        public void loadSachTV(DataGridView _dvgSachTV)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) //đóng
                {
                    conn.Open(); //mở
                    string sql = "SP_LOAD_SACHTV"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, conn); //command kb                  
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dvgSachTV.DataSource = dt; //dgv.soure = table
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message); // lỗi
            }
            finally
            {
                conn.Close(); // đóng
            }
        }
        //Thêm 
        public void themSach(string ma, string ten, string tacgia, string loai, string anh)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SP_THEM_SACHTV";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaSach", SqlDbType.NVarChar)).Value = ma;
                    command.Parameters.Add(new SqlParameter("TenSach", SqlDbType.NVarChar)).Value = ten;
                    command.Parameters.Add(new SqlParameter("TacGia", SqlDbType.NVarChar)).Value = tacgia;
                    command.Parameters.Add(new SqlParameter("LoaiSach", SqlDbType.NVarChar)).Value = loai;
                    command.Parameters.Add(new SqlParameter("AnhSach", SqlDbType.NVarChar)).Value = anh;

                    command.ExecuteNonQuery(); //thực thi

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //Xóa 
        public void xoaSach(string ma)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SP_XOA_SACHTV";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaSach", SqlDbType.NVarChar)).Value = ma;

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //Sưa
        public void suaSach(string ma, string ten, string tacgia, string loai, string anh)
        {

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SP_SUA_SACHTV";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaSach", SqlDbType.NVarChar)).Value = ma;
                    command.Parameters.Add(new SqlParameter("TenSach", SqlDbType.NVarChar)).Value = ten;
                    command.Parameters.Add(new SqlParameter("TacGia", SqlDbType.NVarChar)).Value = tacgia;
                    command.Parameters.Add(new SqlParameter("LoaiSach", SqlDbType.NVarChar)).Value = loai;
                    command.Parameters.Add(new SqlParameter("AnhSach", SqlDbType.NVarChar)).Value = anh;
                    command.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
