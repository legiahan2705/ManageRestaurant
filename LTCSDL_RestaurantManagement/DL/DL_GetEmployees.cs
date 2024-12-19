using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_GetEmployees : DL_Connect
    {
        public List<Employees> GetEmployees()
        {
            List<Employees> employees = new List<Employees>(); // Tạo danh sách chứa thông tin nhân viên

            try
            {
                // Mở kết nối
                _connection.Open();

                // Sử dụng câu lệnh SQL để lấy danh sách nhân viên
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Name, Salary, WorkYears, Role FROM Employees", _connection))
                {
                    // Thực thi câu lệnh và đọc kết quả
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Tạo đối tượng Employees và gắn giá trị từ cơ sở dữ liệu
                            Employees employee = new Employees
                            {
                                Id = reader.GetInt32(0),         // Lấy giá trị cột Id
                                Name = reader.GetString(1),      // Lấy giá trị cột Name
                                Salary = reader.GetDecimal(2),   // Lấy giá trị cột Salary (decimal)
                                WorkYears = reader.GetInt32(3),  // Lấy giá trị cột WorkYears
                                Role = reader.GetString(4)       // Lấy giá trị cột Role
                            };

                            // Thêm đối tượng vào danh sách
                            employees.Add(employee);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
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

            return employees; // Trả về danh sách nhân viên
        }
    }
}
