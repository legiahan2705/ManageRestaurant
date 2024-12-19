using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_Users : DL_Connect
    {
        public Users GetUsers(string username, string password)
        {
            Users user = null; // Khởi tạo null, sẽ trả về nếu không tìm thấy thông tin

            try
            {
                // Mở kết nối
                _connection.Open();

                // Sử dụng stored procedure
                using (SqlCommand cmd = new SqlCommand("us_procLogin", _connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Gắn tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    // Thực thi lệnh và đọc kết quả
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Gắn thông tin từ cơ sở dữ liệu vào đối tượng Users
                                user = new Users
                                {
                                    UserName = username,             // Lấy từ tham số
                                    Password = password,             // Lấy từ tham số
                                    Status = reader.GetString(2),    // Lấy cột thứ 4
                                    Role = reader.GetString(3)       // Lấy cột thứ 3 (quyền)
                                };
                                break; // Thoát vòng lặp khi tìm được thông tin
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi (có thể mở rộng thêm nếu cần)
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }

            return user; // Trả về đối tượng Users hoặc null nếu không tìm thấy
        }
    }
}
