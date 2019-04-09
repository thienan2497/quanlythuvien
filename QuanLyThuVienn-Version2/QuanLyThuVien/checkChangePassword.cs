using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public class checkChangePassword
    {
        public static string check_changepassword(string oldpass, string newpass, string confpass)
        {
            
            if (newpass.Length -1 < 5) { return "Mật khẩu mới quá ngắn"; }
            else if (newpass.Length - 1 > 30) { return "Mật khẩu mới quá dài"; }
            else if (newpass != confpass) { return "Mật khẩu mới không trùng"; }
            else if (oldpass != Main.MatKhau) { return "Mật khẩu cũ sai"; }
            return "Đổi mật khẩu thành công";
        }
    }
}
