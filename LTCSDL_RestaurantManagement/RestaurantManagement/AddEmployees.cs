using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TO;

namespace RestaurantManagement
{
    public partial class AddEmployees : Form
    {
        internal Employees NewEmployee;

        public AddEmployees()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng Employees từ các textbox
                NewEmployee = new Employees
                {
                    Name = txtName.Text.Trim(),
                    Salary = decimal.Parse(txtSalary.Text),
                    WorkYears = int.Parse(txtWorkYears.Text),
                    Role = txtRole.Text.Trim()
                };

                // Đóng form và trả về kết quả
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Hủy thêm nhân viên
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
