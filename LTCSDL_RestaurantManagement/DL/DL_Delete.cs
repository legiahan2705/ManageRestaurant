using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DL_Delete:DL_Connect
    {
        public bool Delete_Employee(int employeeId)
        {
            bool isDeleted = false; // Biến kiểm tra trạng thái xóa

            try
            {
                // Mở kết nối
                _connection.Open();

                // Tạo câu lệnh SQL
                string sql = "DELETE FROM Employees WHERE Id = @EmployeeId";

                // Tạo SqlCommand
                using (SqlCommand command = new SqlCommand(sql, _connection))
                {
                    // Thêm tham số
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    // Thực thi câu lệnh
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra nếu có ít nhất một dòng bị ảnh hưởng
                    isDeleted = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Log lỗi
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

            return isDeleted; // Trả về trạng thái xóa
        }
    }
}
