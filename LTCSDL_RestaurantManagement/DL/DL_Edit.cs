using Microsoft.Data.SqlClient;
using System;
using TO;

namespace DL
{
    public class DL_Edit : DL_Connect
    {
        public bool EditEmployee(Employees employee)
        {
            bool isUpdated = false;

            try
            {
                // Mở kết nối
                _connection.Open();

                // Câu lệnh SQL cập nhật nhân viên
                string sql = "UPDATE Employees SET Name = @NewName, Salary = @NewSalary, WorkYears = @NewWorkYears, Role = @NewRole WHERE Id = @EmployeeId";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    // Thêm tham số
                    cmd.Parameters.AddWithValue("@NewName", employee.Name);
                    cmd.Parameters.AddWithValue("@NewSalary", employee.Salary);
                    cmd.Parameters.AddWithValue("@NewWorkYears", employee.WorkYears);
                    cmd.Parameters.AddWithValue("@NewRole", employee.Role);
                    cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);  // Bổ sung ID

                    // Thực thi câu lệnh
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isUpdated = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
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

            return isUpdated;  // Trả về trạng thái cập nhật
        }
    }
}
