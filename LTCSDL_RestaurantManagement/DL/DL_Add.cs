using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_Add : DL_Connect
    {
        public bool AddEmployee(Employees employee)
        {
            bool isAdded = false;

            try
            {
                // Mở kết nối
                _connection.Open();

                // Câu lệnh SQL INSERT với OUTPUT để lấy Id vừa thêm
                string sql = "INSERT INTO Employees (Name, Salary, WorkYears, Role) " +
                             "OUTPUT INSERTED.Id " +
                             "VALUES (@Name, @Salary, @WorkYears, @Role)";

                // Tạo SqlCommand
                using (SqlCommand command = new SqlCommand(sql, _connection))
                {
                    // Gán giá trị tham số
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@Salary", employee.Salary);
                    command.Parameters.AddWithValue("@WorkYears", employee.WorkYears);
                    command.Parameters.AddWithValue("@Role", employee.Role);

                    // Thực thi câu lệnh và lấy Id được sinh ra
                    object result = command.ExecuteScalar();

                    // Kiểm tra xem result có phải là giá trị Id hợp lệ không
                    if (result != null)
                    {
                        employee.Id = Convert.ToInt32(result); // Gán Id tự động sinh vào đối tượng
                        isAdded = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm nhân viên: {ex.Message}");
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }

            return isAdded;
        }
    }
}
