using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DL_Connect
    {
        // Tạo chuỗi kết nối csdl
        protected SqlConnection _connection = new SqlConnection("Data Source=LEGIAHAN\\SQLEXPRESS01;Initial Catalog=RestaurantDB;Integrated Security=True;Trust Server Certificate=True");
    }
}
