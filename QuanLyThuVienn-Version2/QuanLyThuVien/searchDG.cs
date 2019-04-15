using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
namespace QuanLyThuVien
{
    public class searchDG
    {
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        public string search_1(string cbbox, string txtbox)
        {

            string d;
            d = "select * from tblDocGia";
            if (cbbox == "MADG")
            {
                if (txtbox.Length > 10)
                {
                    return "Mã độc giả quá dài";
                }
                else
                {
                    d = "select*from tblDocGia where MADG like '%" + txtbox + "%'";
                }

            }
            else if (cbbox == "HOTEN")
            {
                if (txtbox.Length > 50)
                {
                    return "Tên độc giả quá dài";
                }
                else
                {
                    d = "select*from tblDocGia where HOTEN like '%" + txtbox + "%'";
                }

            }
            else if (cbbox == "GIOITINH")
            {
                if (txtbox.Length > 3)
                {
                    return "Giới tính bị sai";
                }
                else
                {
                    d = "select*from tblDocGia where GIOITINH like '%" + txtbox + "%'";
                }

            }
            else if (cbbox == "LOP")
            {
                if (txtbox.Length > 10)
                {
                    return "Lớp quá dài";
                }
                else
                {
                    d = "select*from tblDocGia where LOP like '%" + txtbox + "%'";
                }

            }

            else if (cbbox == "DIACHI")
            {
                if (txtbox.Length > 200)
                {
                    return "Địa chỉ quá dài";
                }
                else
                {
                    d = "select*from tblDocGia where DIACHI like '%" + txtbox + "%'";
                }

            }
            else if (cbbox == "NGAYSINH")
            {
                CheckDate date = new CheckDate();
                if (date.Check_Date(txtbox) == "Ngày không hợp lệ")
                {
                    MessageBox.Show("Ngày không hợp lệ");
                    return "select * from tblSach";
                }
                else
                {
                    d = "select*from tblDocGia where " + cbbox + " like '%" + date.Check_Date(txtbox) + "%'";
                }
            }
            return d; 
        }
            


        
    }
}
