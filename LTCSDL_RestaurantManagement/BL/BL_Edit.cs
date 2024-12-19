using DL;
using TO;
using System.Collections.Generic;

namespace BL
{
    public class BL_Edit
    {
        private DL_Edit _dlEdit;
        private DL_GetEmployees _dlGetEmployees;  // Sử dụng lớp lấy nhân viên

        public BL_Edit()
        {
            _dlEdit = new DL_Edit();
            _dlGetEmployees = new DL_GetEmployees();
        }

        // Phương thức chỉnh sửa nhân viên
        public bool EditEmployee(Employees employee)
        {
            return _dlEdit.EditEmployee(employee);
        }

        // Phương thức lấy danh sách nhân viên
        public List<Employees> GetEmployees()
        {
            return _dlGetEmployees.GetEmployees();  // Gọi từ lớp DL_GetEmployees
        }
    }
}
