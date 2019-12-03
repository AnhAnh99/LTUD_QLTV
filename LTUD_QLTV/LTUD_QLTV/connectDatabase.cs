using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LTUD_QLTV
{
    class KetNoiDatabase
    {
        //Kết nối SQL
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True");
        //kai bao dataTable
        DataTable dt;
        public void dangNhap(string tenDN, string matKhau)
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
                    string sql = "SELECT COUNT(*) FROM DangKy WHERE TenTaiKhoan = '" + tenDN + "' AND MatKhau = '" + matKhau + "'"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable();
                    data.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        GiaoDien gd = new GiaoDien();
                        gd.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công.Vui lòng kiểm tra lại tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        /// <summary>
        /// BẢNG TRA SACH 
        /// </summary>
        /// <param name="_dvgLTraSach"></param>
        //Load dữ liệu từ bảng TRASACH 
        public void loadTraSach(DataGridView _dvgLTraSach)
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
                    string sql = "SP_LOAD_TRASACH"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dvgLTraSach.DataSource = dt; //dgv.soure = table
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
      
        //Thêm dữ liệu vào bảng TRASACH 
        public void addTraSach(string maTraSach, string maMuonSach, string tenKHMuon, string tenSachMuon, string ngayHenTra, string ngayTra, double phiPhat )
        {
            //try-catch-finnaly
            //try: if
            //catch: tb lỗi k kết nối
            //finally: đóng kết nối
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_THEM_TRASACH";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaTraSach", SqlDbType.NVarChar)).Value = maTraSach;
                    command.Parameters.Add(new SqlParameter("MaMuonSach", SqlDbType.NVarChar)).Value = maMuonSach;
                    command.Parameters.Add(new SqlParameter("TenKhachHang", SqlDbType.NVarChar)).Value = tenKHMuon;
                    command.Parameters.Add(new SqlParameter("TenSach", SqlDbType.NVarChar)).Value = tenSachMuon;
                    command.Parameters.Add(new SqlParameter("NgayHenTra", SqlDbType.SmallDateTime)).Value = ngayHenTra;
                    command.Parameters.Add(new SqlParameter("NgayTra", SqlDbType.SmallDateTime)).Value = ngayTra;
                    command.Parameters.Add(new SqlParameter("PhiPhat", SqlDbType.Money)).Value = phiPhat;


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

        //Xoa dữ liệu từ bảng TRASACH 
        public void removeTraSach(string maTraSach)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_XOA_TRASACH";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaTraSach", SqlDbType.NVarChar)).Value = maTraSach;

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

        //Sửa dữ liệu trong bảng TRASACH 
        public void updateTraSach(string maTraSach, string maMuonSach, string tenKHMuon, string tenSachMuon, string ngayHenTra, string ngayTra, double phiPhat )
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_SUA_TRASACH";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("MaTraSach", SqlDbType.NVarChar)).Value = maTraSach;
                    command.Parameters.Add(new SqlParameter("MaMuonSach", SqlDbType.NVarChar)).Value = maMuonSach;
                    command.Parameters.Add(new SqlParameter("TenKhachHang", SqlDbType.NVarChar)).Value = tenKHMuon;
                    command.Parameters.Add(new SqlParameter("TenSach", SqlDbType.NVarChar)).Value = tenSachMuon;
                    command.Parameters.Add(new SqlParameter("NgayHenTra", SqlDbType.SmallDateTime)).Value = ngayHenTra;
                    command.Parameters.Add(new SqlParameter("NgayTra", SqlDbType.SmallDateTime)).Value = ngayTra;
                    command.Parameters.Add(new SqlParameter("PhiPhat", SqlDbType.Money)).Value = phiPhat;

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

        //Tìm kiếm dữ liệu trong bảng TRASACH 
        public void timKiemTraSach(string str, string keyWord, DataGridView _dgvDLMuonSach)
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
                    string sql = "SELECT * FROM MUONSACH WHERE " + str + " LIKE N'%" + keyWord + "%'"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dgvDLMuonSach.DataSource = dt; //dgv.soure = table
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

        /// <summary>
        /// BANG MUON SACH
        /// </summary>
        /// <param name="_dvgLMuonSach"></param>
        //Load dữ liệu từ bảng MUONSACH
        public void loadMuonSach(DataGridView _dvgLMuonSach)
        {
            //try: if
            try
            {
                if (connect.State == ConnectionState.Closed) //đóng
                {
                    connect.Open(); //mở kết nối
                    string sql = "SP_LOAD_MUONSACH"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dvgLMuonSach.DataSource = dt; //dgv.soure = table
                }
            }
            //catch: tb lỗi k kết nối
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message); // lỗi
            }
            //finally: đóng kết nối
            finally
            {
                connect.Close(); // đóng
            }
        }
        //Load loại tên khác hàng từ bảng KHACHHANG
        public void loadTenKH(string cbxMaKH, TextBox _txtTenKHMuon)
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
                    string sql = "SELECT TenKhachHang FROM KHACHHANG WHERE MaKhachHang = '" + cbxMaKH + "'"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple)


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
        //Load loại mã khach hàng từ bảng KHACHHANG
        public void loadMaKH(ComboBox _cbxMaKH)
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
                    string sql = "SP_LOAD_MAKHACHHAG"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple)
                    _cbxMaKH.DataSource = dt;
                    //_cbxMaKH.DisplayMember = "TenTacGia";
                    _cbxMaKH.ValueMember = "MaKhachHang";
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
        //Load loại mã sách từ bảng SACHTV
        public void loadMaSachTV(ComboBox _cbxMaSachMuon)
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
                    string sql = "SP_LOAD_MASACHTV"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _cbxMaSachMuon.DataSource = dt; //dgv.soure = table
                    _cbxMaSachMuon.DataSource = dt;
                    //_cbxMaKH.DisplayMember = "TenTacGia";
                    _cbxMaSachMuon.ValueMember = "MaSach";
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

        //Thêm dữ liệu vào bảng MUONSACH
        public void addMuonSach(string maMuonSach, string maKHMuon, string tenKHMuon, string maSachMuon, string tenSachMuon, string ngayMuon, string ngayHenTra)
        {
            //try-catch-finnaly
            //try: if
            //catch: tb lỗi k kết nối
            //finally: đóng kết nối
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_THEM_MUONSACH";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaMuonSach", SqlDbType.NVarChar)).Value = maMuonSach;
                    command.Parameters.Add(new SqlParameter("MaKhachHang", SqlDbType.NVarChar)).Value = maKHMuon;
                    command.Parameters.Add(new SqlParameter("TenKhachHang", SqlDbType.NVarChar)).Value = tenKHMuon;
                    command.Parameters.Add(new SqlParameter("MaSach", SqlDbType.NVarChar)).Value = maSachMuon;
                    command.Parameters.Add(new SqlParameter("TenSach", SqlDbType.NVarChar)).Value = tenSachMuon;
                    command.Parameters.Add(new SqlParameter("NgayMuonSach", SqlDbType.SmallDateTime)).Value = ngayMuon;
                    command.Parameters.Add(new SqlParameter("NgayHenTra", SqlDbType.SmallDateTime)).Value = ngayHenTra;


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

        //Xoa dữ liệu từ bảng MUONSACH
        public void removeMuonSach(string maMuonSach)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_XOA_MUONSACH";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaMuonSach", SqlDbType.NVarChar)).Value = maMuonSach;
                    
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

        //Sửa dữ liệu trong bảng MUONSACH
        public void updateMuonSach(string maMuonSach, string maKHMuon, string tenKHMuon, string maSachMuon, string tenSachMuon, string ngayMuon, string ngayHenTra)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_SUA_MUONSACH";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaMuonSach", SqlDbType.NVarChar)).Value = maMuonSach;
                    command.Parameters.Add(new SqlParameter("MaKhachHang", SqlDbType.NVarChar)).Value = maKHMuon;
                    command.Parameters.Add(new SqlParameter("TenKhachHang", SqlDbType.NVarChar)).Value = tenKHMuon;
                    command.Parameters.Add(new SqlParameter("MaSach", SqlDbType.NVarChar)).Value = maSachMuon;
                    command.Parameters.Add(new SqlParameter("TenSach", SqlDbType.NVarChar)).Value = tenSachMuon;
                    command.Parameters.Add(new SqlParameter("NgayMuonSach", SqlDbType.SmallDateTime)).Value = ngayMuon;
                    command.Parameters.Add(new SqlParameter("NgayHenTra", SqlDbType.SmallDateTime)).Value = ngayHenTra;

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

        //Tìm kiếm dữ liệu trong bảng MUONSACH
        public void timKiemMuonSach(string str, string keyWord, DataGridView _dgvDLMuonSach)
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
                    string sql = "SELECT * FROM MUONSACH WHERE " + str + " LIKE N'%" + keyWord + "%'"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dgvDLMuonSach.DataSource = dt; //dgv.soure = table
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

        /// <summary>
        /// BẢNG KHACHHANG 
        /// </summary>
        /// <param name="_dvgLKhachHang"></param>

        //Load khách hàng từ bảng KHACHHANG
        public void loadKhachHang(DataGridView _dvgLKhachHang)
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
                    _dvgLKhachHang.DataSource = dt; //dgv.soure = table
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

        //Thêm khách hàng vào bảng KHACHHANG
        public void addKhachHang(string maKH, string tenKH, string soDTKH, string diaChiKH, string ngayDangKy, string ngayHetHan)
        {
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
                    command.Parameters.Add(new SqlParameter("MaKhachHang", SqlDbType.NVarChar)).Value = maKH;
                    command.Parameters.Add(new SqlParameter("TenKhachHang", SqlDbType.NVarChar)).Value = tenKH;
                    command.Parameters.Add(new SqlParameter("SoDienThoaiKH", SqlDbType.NVarChar)).Value = soDTKH;
                    command.Parameters.Add(new SqlParameter("DiaChiKH", SqlDbType.NVarChar)).Value = diaChiKH;
                    command.Parameters.Add(new SqlParameter("NgayDK", SqlDbType.NVarChar)).Value = ngayDangKy;
                    command.Parameters.Add(new SqlParameter("NgayHetHan", SqlDbType.NVarChar)).Value = ngayHetHan;


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

        //Xoa khách hàng từ bảng KHACHHANG
        public void removeKhachHang(string maKH)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_XOA_KHACHHANG";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaKhachHang", SqlDbType.NVarChar)).Value = maKH;
              
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

        //Sửa khách hàng trong bảng KHACHHANG
        public void updateKhachHang(string maKH, string tenKH, string soDTKH, string diaChiKH, string ngayDangKy, string ngayHetHan)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_SUA_KHACHHANG";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaKhachHang", SqlDbType.NVarChar)).Value = maKH;
                    command.Parameters.Add(new SqlParameter("TenKhachHang", SqlDbType.NVarChar)).Value = tenKH;
                    command.Parameters.Add(new SqlParameter("SoDienThoaiKH", SqlDbType.NVarChar)).Value = soDTKH;
                    command.Parameters.Add(new SqlParameter("DiaChiKH", SqlDbType.NVarChar)).Value = diaChiKH;
                    command.Parameters.Add(new SqlParameter("NgayDK", SqlDbType.NVarChar)).Value = ngayDangKy;
                    command.Parameters.Add(new SqlParameter("NgayHetHan", SqlDbType.NVarChar)).Value = ngayHetHan;

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

        //Tìm kiếm khách hàng trong bảng KHACHHANG
        public void timKiemKhachHang(string str, string keyWord, DataGridView _dgvDLKhachHang)
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
                    string sql = "SELECT * FROM KHACHHANG WHERE " + str + " LIKE N'%" + keyWord + "%'"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dgvDLKhachHang.DataSource = dt; //dgv.soure = table
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




        //Thêm tài khoản vào bảng DANGNHAP
        public void addTaiKhoan(string tenDangKy, string matKhau, string nhapLaiMK)
        {
            //try-catch-finnaly
            //try: if
            //catch: tb lỗi k kết nối
            //finally: đóng kết nối
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_THEM_DANGKY";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("TenTaiKhoan", SqlDbType.NVarChar)).Value = tenDangKy;
                    command.Parameters.Add(new SqlParameter("MatKhau", SqlDbType.NVarChar)).Value = matKhau;
                    command.Parameters.Add(new SqlParameter("NhapLaiMatKhau", SqlDbType.NVarChar)).Value = nhapLaiMK;
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

        /// <summary>
        /// BẢNG LOAISACH
        /// </summary>
        /// <param name="_dvgLoaiSach"></param>
        //Load loại sách từ bảng LOAISACH
        public void loadLoaiSach(DataGridView _dvgLoaiSach)
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
                    string sql = "SP_LOAD_LOAISACH"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dvgLoaiSach.DataSource = dt; //dgv.soure = table
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

        //Thêm loại sách vào bảng LOAISACH
        public void addLoaiSach(string maLoaiSach, string tenLoaiSach)
        {
            //try-catch-finnaly
            //try: if
            //catch: tb lỗi k kết nối
            //finally: đóng kết nối
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_THEM_LOAISACH";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaLoaiSach", SqlDbType.NVarChar)).Value = maLoaiSach;
                    command.Parameters.Add(new SqlParameter("TenLoaiSach", SqlDbType.NVarChar)).Value = tenLoaiSach;
                    
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

        //Xoa loại sách từ bảng LOAISACH
        public void removeLoaiSach(string maLoaiSach)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_DELETE_LOAISACH";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("MaLoaiSach", SqlDbType.NVarChar)).Value = maLoaiSach;
                    
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

        //Sửa loại sách trong bảng LOAISACH
        public void updateLoaiSach(string maLoaiSach, string tenLoaiSach)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_SUA_LOAISACH";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaLoaiSach", SqlDbType.NVarChar)).Value = maLoaiSach;
                    command.Parameters.Add(new SqlParameter("TenLoaiSach", SqlDbType.NVarChar)).Value = tenLoaiSach;

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

        //Tìm kiếm loại sách trong bảng LOAISACH
        public void timKiemLoaiSach(string str, string keyWord, DataGridView _dgvDLLoaiSach)
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
                    string sql = "SELECT * FROM LOAISACH WHERE " + str + " LIKE N'%" + keyWord + "%'"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dgvDLLoaiSach.DataSource = dt; //dgv.soure = table
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

        /// <summary>
        /// BẢNG TACGIA
        /// </summary>
        /// <param name="_dvgTacGia"></param>
        //Load tác giả từ bảng TACGIA
        public void loadTacGia(DataGridView _dvgTacGia)
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
                    string sql = "SP_LOAD_TACGIA"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dvgTacGia.DataSource = dt; //dgv.soure = table
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

        //Thêm tác giả vào bảng TACGIA
        public void addTacGia(string maTacGia, string tenTacGia, string diaChiTG)
        {
            //try-catch-finnaly
            //try: if
            //catch: tb lỗi k kết nối
            //finally: đóng kết nối
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_THEM_TACGIA";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaTacGia", SqlDbType.NVarChar)).Value = maTacGia;
                    command.Parameters.Add(new SqlParameter("TenTacGia", SqlDbType.NVarChar)).Value = tenTacGia;
                    command.Parameters.Add(new SqlParameter("DiaChiTG", SqlDbType.NVarChar)).Value = diaChiTG;
               
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

        //Xoa tác giả từ bảng TACGIA
        public void removeTacGia(string maTacGia)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_DELETE_TACGIA";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaTacGia", SqlDbType.NVarChar)).Value = maTacGia;
             
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

        //Sửa tác giả trong bảng TACGIA
        public void updateTacGia(string maTacGia, string tenTacGia, string diaChiTG)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_SUA_TACGIA";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaTacGia", SqlDbType.NVarChar)).Value = maTacGia;
                    command.Parameters.Add(new SqlParameter("TenTacGia", SqlDbType.NVarChar)).Value = tenTacGia;
                    command.Parameters.Add(new SqlParameter("DiaChiTG", SqlDbType.NVarChar)).Value = diaChiTG;

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

        //Tìm kiếm tác giả trong bảng TACGIA
        public void timKiemTacGia(string str, string keyWord, DataGridView _dgvDLTacGia)
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
                    string sql = "SELECT * FROM TACGIA WHERE " + str + " LIKE N'%" + keyWord + "%'"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dgvDLTacGia.DataSource = dt; //dgv.soure = table
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

        /// <summary>
        /// BẢNG SACHTHUVIEN
        /// </summary>
        /// <param name="_dvgSach"></param>
        //Load sách từ bảng SACHTHUVIEN
        public void loadSachThuVien(DataGridView _dvgSach)
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
                    string sql = "SP_LOAD_SACHTV"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dvgSach.DataSource = dt; //dgv.soure = table
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

        //Load tác giả từ bảng SACHTHUVIEN
        public void loadTacGia(ComboBox _cbxTGSach)
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
                    string sql = "SP_LOAD_TACGIA"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _cbxTGSach.DataSource = dt;
                    _cbxTGSach.DisplayMember = "TenTacGia";
                    _cbxTGSach.ValueMember = "MaTacGia";
                    
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

        //Load loại từ bảng SACHTHUVIEN
        public void loadLoaiSachTV(ComboBox _cbxLoaiSachTV)
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
                    string sql = "SP_LOAD_LOAISACH"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _cbxLoaiSachTV.DataSource = dt;
                    _cbxLoaiSachTV.DisplayMember = "LoaiSach";
                    _cbxLoaiSachTV.ValueMember = "MaLoaiSach";

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

        //Thêm sách vào bảng SACHTHUVIEN
        public void addSachThuVien(string maSach, string tenSach, string tacGia, string anhSach, string loaiSach)
        {
            //try-catch-finnaly
            //try: if
            //catch: tb lỗi k kết nối
            //finally: đóng kết nối
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_THEM_SACHTV";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaSach", SqlDbType.NVarChar)).Value = maSach;
                    command.Parameters.Add(new SqlParameter("TenSach", SqlDbType.NVarChar)).Value = tenSach;
                    command.Parameters.Add(new SqlParameter("TacGia", SqlDbType.NVarChar)).Value = tacGia;
                    command.Parameters.Add(new SqlParameter("AnhSach", SqlDbType.NVarChar)).Value = anhSach;
                    command.Parameters.Add(new SqlParameter("LoaiSach", SqlDbType.NVarChar)).Value = loaiSach;

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

        //Xoa sach từ bảng SACHTHUVIEN
        public void removeSachThuVien(string maSach)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_XOA_SACHTV";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaSach", SqlDbType.NVarChar)).Value = maSach;

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

        //Sửa sách trong bảng SACHTHUVIEN
        public void updateSachThuVien(string maSach, string tenSach, string tacGia, string anhSach, string loaiSach)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_SUA_SACHTV";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaSach", SqlDbType.NVarChar)).Value = maSach;
                    command.Parameters.Add(new SqlParameter("TenSach", SqlDbType.NVarChar)).Value = tenSach;
                    command.Parameters.Add(new SqlParameter("TacGia", SqlDbType.NVarChar)).Value = tacGia;
                    command.Parameters.Add(new SqlParameter("AnhSach", SqlDbType.NVarChar)).Value = anhSach;
                    command.Parameters.Add(new SqlParameter("LoaiSach", SqlDbType.NVarChar)).Value = loaiSach;

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

        //Tìm kiếm sách trong bảng SACHTHUVIEN
        public void timKiemSachTV(string str, string keyWord, DataGridView _dgvDLSach)
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
                    string sql = "SELECT * FROM SACHTHUVIEN WHERE " + str + " LIKE N'%" + keyWord + "%'"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dgvDLSach.DataSource = dt; //dgv.soure = table
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

        /// <summary>
        /// BẢNG NHANVIEN
        /// </summary>
        /// <param name="_dvgNhanVien"></param>
        //Load nhân viên từ bảng NHANVIEN
        //Load loại từ thư viện
        public void loadNhanVien(DataGridView _dvgNhanVien)
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
                    string sql = "SP_LOAD_NHANVIEN"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dvgNhanVien.DataSource = dt; //dgv.soure = table
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

        //Them nhân viên vào bảng NHANVIEN
        public void themNhanVien(string maNV, string tenNV, string chucVu, string soDT, string diaChi)
        {
            //try-catch-finnaly
            //try: if
            //catch: tb lỗi k kết nối
            //finally: đóng kết nối
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_THEM_NHANVIEN";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;

                    //Thêm
                    command.Parameters.Add(new SqlParameter("MaNhanVien", SqlDbType.NVarChar)).Value = maNV;
                    command.Parameters.Add(new SqlParameter("TenNhanVien", SqlDbType.NVarChar)).Value = tenNV;
                    command.Parameters.Add(new SqlParameter("ChucVu", SqlDbType.NVarChar)).Value = chucVu;
                    command.Parameters.Add(new SqlParameter("SoDienThoai", SqlDbType.NVarChar)).Value = soDT;
                    command.Parameters.Add(new SqlParameter("DiaChi", SqlDbType.NVarChar)).Value = diaChi;

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
        //Sua nhân viên tu bảng NHANVIEN
        public void suaNhanVien(string maNV, string tenNV, string chucVu, string soDT, string diaChi)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_SUA_NHANVIEN";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaNhanVien", SqlDbType.NVarChar)).Value = maNV;
                    command.Parameters.Add(new SqlParameter("TenNhanVien", SqlDbType.NVarChar)).Value = tenNV;
                    command.Parameters.Add(new SqlParameter("ChucVu", SqlDbType.NVarChar)).Value = chucVu;
                    command.Parameters.Add(new SqlParameter("SoDienThoai", SqlDbType.NVarChar)).Value = soDT;
                    command.Parameters.Add(new SqlParameter("DiaChi", SqlDbType.NVarChar)).Value = diaChi;

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

        //Xoa nhân viên từ bảng NHANVIEN
        public void xoaNhanVien(string maNV)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sql = "SP_DELETE_NHANVIEN";
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaNhanVien", SqlDbType.NVarChar)).Value = maNV;

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

        //Tìm kiếm nhân viên trong bảng NHANVIEN
        public void timKiemNhanVien(string str, string keyWord, DataGridView _dgvDLNhanVien)
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
                    string sql = "SELECT * FROM NHANVIEN WHERE " + str + " LIKE N'%" + keyWord + "%'"; //kb csdl
                    SqlCommand command = new SqlCommand(sql, connect); //command kb
                    //xoa từ đây
                    //  command.CommandType = CommandType.StoredProcedure; //commandType
                    SqlDataAdapter data = new SqlDataAdapter(command); //dataapter kb
                    dt = new DataTable(); //kb
                    data.Fill(dt); // ap.fill(taple) 1
                    _dgvDLNhanVien.DataSource = dt; //dgv.soure = table
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
