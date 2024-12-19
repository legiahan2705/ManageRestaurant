using System;
using System.Windows.Forms;
using TO;
using BL;

namespace RestaurantManagement
{
    public partial class EditEmployee : Form
    {
        private BL_Edit _blEdit;  // Sử dụng lớp BL_Edit thay vì BL_Employees
        private int _employeeId;

        public Employees NewEmployee { get; private set; }

        // Constructor nhận employeeId
        public EditEmployee(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            _blEdit = new BL_Edit();
        }

        // Tải dữ liệu nhân viên khi form được load
        private void EditEmployee_Load(object sender, EventArgs e)
        {
            Employees employee = _blEdit.GetEmployees().Find(emp => emp.Id == _employeeId);  // Lấy thông tin từ cơ sở dữ liệu

            if (employee != null)
            {
                txtId.Text = employee.Id.ToString();  // Không cho phép chỉnh sửa ID
                txtName.Text = employee.Name;
                txtSalary.Text = employee.Salary.ToString("N2");
                txtWorkYears.Text = employee.WorkYears.ToString();
                txtRole.Text = employee.Role;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();  // Đóng form nếu không tìm thấy nhân viên
            }
        }

        // Lưu thay đổi khi nhấn nút Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng Employees từ các textbox
                NewEmployee = new Employees
                {
                    Id = _employeeId,
                    Name = txtName.Text.Trim(),
                    Salary = decimal.Parse(txtSalary.Text),
                    WorkYears = int.Parse(txtWorkYears.Text),
                    Role = txtRole.Text.Trim()
                };

                // Cập nhật thông tin nhân viên trong cơ sở dữ liệu
                bool isUpdated = _blEdit.EditEmployee(NewEmployee);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;  // Đóng form nếu thành công
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa nhân viên: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
