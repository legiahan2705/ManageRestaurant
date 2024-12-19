using BL;
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
    public partial class Dashboard : Form
    {
        private string _username;
        private BL_Employees _blEmployees;
        private BL_DeleteEmployee _blDeleteEmployee;
        private BL_Add BL_Add;
        private BL_Edit BL_Edit;
        public Dashboard(string username)
        {
            InitializeComponent();
            _username = username;
            _blEmployees = new BL_Employees();
            _blDeleteEmployee = new BL_DeleteEmployee();
            label2.Text = $"Chào mừng, {_username}";
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                List<Employees> employees = _blEmployees.GetAllEmployees();

                if (employees != null && employees.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (var employee in employees)
                    {
                        dataGridView1.Rows.Add(
                            employee.Id,
                            employee.Name,
                            employee.Salary,
                            employee.WorkYears,
                            employee.Role
                        );
                    }
                    groupBox1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Không có nhân viên nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int employeeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa nhân viên với ID = {employeeId} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.OK)
                {
                    bool isDeleted = _blDeleteEmployee.DeleteEmployee(employeeId);
                    if (isDeleted)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo");
                    }
                }
            }

            //edit
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int employeeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                // Hiển thị form chỉnh sửa
                using (EditEmployee editForm = new EditEmployee(employeeId))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        Employees updatedEmployee = editForm.NewEmployee;
                        BL_Edit blEdit = new BL_Edit();

                        // Cập nhật dữ liệu trong cơ sở dữ liệu
                        bool isEdited = blEdit.EditEmployee(updatedEmployee);

                        if (isEdited)
                        {
                            // Cập nhật dữ liệu trong DataGridView
                            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                            row.Cells["Id"].Value = updatedEmployee.Id;
                            row.Cells["Name"].Value = updatedEmployee.Name;
                            row.Cells["Salary"].Value = updatedEmployee.Salary;
                            row.Cells["WorkYears"].Value = updatedEmployee.WorkYears;
                            row.Cells["Role"].Value = updatedEmployee.Role;

                            MessageBox.Show("Sửa nhân viên thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Sửa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            using (AddEmployees addForm = new AddEmployees())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    Employees newEmployee = addForm.NewEmployee;
                    BL_Add blEmployees = new BL_Add();
                    bool isAdded = blEmployees.AddEmployee(newEmployee);

                    if (isAdded)
                    {
                        dataGridView1.Rows.Add(
                            newEmployee.Id,
                            newEmployee.Name,
                            newEmployee.Salary,
                            newEmployee.WorkYears,
                            newEmployee.Role
                        );
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
                    }
                }
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn thoát?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Application.Exit(); // Thoát toàn bộ ứng dụng
                }
                else
                {
                    e.Cancel = true; // Hủy đóng form
                }
            }
        }
    }
}
