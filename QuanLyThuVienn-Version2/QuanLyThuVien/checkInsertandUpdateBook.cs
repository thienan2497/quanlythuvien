using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyThuVien
{
    public class checkInsertandUpdateBook
    {
        public static string check_insertBook(string masach, string tensach, string matg, string manxb, string malv, string namxb, string sotrang, int soluong, string ngaynhap, string ghichu, int sosachhong)
        {
            if ((masach.Length != 6) || (masach.Substring(0) != "S"))
            { return ("Mã sách phải gồm 6 kí tự và bắt đầu bằng S"); }
            else if (tensach.Length == 0)
            { return ("Bạn phải nhập tên sách"); }
            else if (tensach.Length > 50)
            { return ("Tên sách quá dài"); }
            else if (namxb.Length == 0)
            { return ("Bạn phải nhập năm xuất bản"); }
            else if (namxb.Length > 4)
            { return ("Năm xuất bản không hợp lệ"); }
            else if (sosachhong > soluong)
            { return ("Số lượng sách hỏng không được lớn hơn số lượng sách nhập vào"); }
            else if (malv.Length == 0)
            { return ("Bạn phải chọn lĩnh vực"); }
            else if (matg.Length == 0)
            { return ("Bạn phải chọn tác giả"); }
            else if (manxb.Length == 0)
            { return ("Bạn phải chọn nhà xuất bản"); }
            
            else return ("0");
        }
    }
}
