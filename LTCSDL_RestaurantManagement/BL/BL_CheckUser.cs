using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_CheckUser
    {
        private DL_Users _dlUsers = new DL_Users();

        public string Login(string username, string password)
        {
            Users users = _dlUsers.GetUsers(username, password);

            if (users == null)
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }

            return $"Đăng nhập thành công! Vai trò: {users.Role}";
        }
    }
}
