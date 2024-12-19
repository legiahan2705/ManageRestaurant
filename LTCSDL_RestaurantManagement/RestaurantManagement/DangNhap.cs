using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using TO;

namespace RestaurantManagement
{
    public partial class DangNhap : Form
    {
        private BL_CheckUser bL_CheckUser = new BL_CheckUser();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            

            string username = textBox1.Text;
            string password = textBox2.Text;

            string message = bL_CheckUser.Login(username, password);

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Nếu đăng nhập thành công, chuyển sang Dashboard

            if (message.StartsWith("Đăng nhập thành công"))
            {

                Dashboard dashboard = new Dashboard(username);
                dashboard.Show();
                this.Hide(); // Ẩn form đăng nhập
            }


            


        }
    }
}
