using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;
namespace BL
{
    public class BL_Employees
    {
        private DL_GetEmployees _dlGetEmployees = new DL_GetEmployees();

        public List<Employees> GetAllEmployees()
        {
            // Gọi tầng DL để lấy dữ liệu
            List<Employees> employees = _dlGetEmployees.GetEmployees();

            // Kiểm tra nếu không có nhân viên nào
            if (employees == null || employees.Count == 0)
            {
                // Trả về danh sách rỗng hoặc ném thông báo lỗi
                Console.WriteLine("Không có nhân viên nào trong cơ sở dữ liệu.");
                return new List<Employees>();
            }

            // Trả về danh sách nhân viên nếu hợp lệ
            return employees;
        }


    }
}
