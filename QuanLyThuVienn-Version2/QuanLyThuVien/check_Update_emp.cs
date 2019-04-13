using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien; 
namespace QuanLyThuVien
{
    public class check_Update_emp
    { public static string check_update_employee(string ten, string diachi, string sdt, string email, string chucvu, int tuoi)
        {
           if (ten.Length > 50 )
            { return "Tên nhân viên quá dài"; }
           else if (ten.Length <= 0)
            { return "Tên nhân viên quá ngắn"; }
            else if (diachi.Length > 200)
            { return "Địa chỉ quá dài"; }
            else if (diachi.Length <= 0)
            { return "Địa chỉ quá ngắn"; }
            else if (sdt.Length != 10)
            { return "Số điện thoại phải có 10 số"; }
            else if (email.Length > 50)
            { return "Email quá dài"; }
            else if (chucvu.Length > 50)
            { return "Chức vụ quá dài"; }
            else if ((tuoi > 120) || (tuoi <7))
            { return "Độ tuổi phải trong khoảng 7 đến 120"; }
            return "0";

        }
    }
}
