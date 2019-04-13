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
            d = "select * from tblSach";
            if (cbbox == "TENSACH")
            {
                if (txtbox.Length - 1 > 50)
                {
                    return "Tên sách quá dài";
                }
                else
                {
                    d = "select*from tblSach where TENSACH like '%" + txtbox + "%'";
                }

            }
            if (cbbox == "MASACH")
            {
                if (txtbox.Length - 1 > 50)
                {
                    return "Mã sách quá dài";
                }
                else
                {
                    d = "select*from tblSach where MASACH like '%" + txtbox + "%'";
                }

            }
            else if (cbbox == "MATG")
            {
                if (txtbox.Length - 1 > 30)
                {
                    return "Tên tác giả quá dài";
                }
                else
                {
                    d = "select*from tblSach where MATG LIKE '%" + txtbox + "%'";
                }

            }
            else if (cbbox == "MANXB")
            {
                if (txtbox.Length - 1 > 30)
                {
                    return "Mã NXB hoặc tên NXB quá dài";
                }
                else
                {
                    d = "select*from tblSach where MANXB like '%" + txtbox + "%'";
                }
            }
            else if (cbbox == "MaLv")
            {
                if (txtbox.Length - 1 > 10)
                {
                    return "Mã lĩnh vực quá dài";
                }
                else
                {
                    d = "select*from tblSach where MaLv like '%" + txtbox + "%'";
                }
            }
            else if (cbbox == "NAMXB")
            {
                CheckDate date = new CheckDate();
                if (date.Check_Year(txtbox) == "Năm không hợp lệ")
                {
                    MessageBox.Show("Năm không hợp lệ");
                    return "select * from tblSach";
                }
                else
                {
                    d = "select*from tblSach where " + cbbox + " like '%" + date.Check_Year(txtbox) + "%'";
                }
            }

            else if (cbbox == "NGAYNHAP")
            {
                CheckDate date = new CheckDate();
                if (date.Check_Date(txtbox) == "Ngày không hợp lệ")
                {
                    MessageBox.Show("Ngày không hợp lệ");
                    return "select * from tblSach";
                }
                else
                {
                    d = "select*from tblSach where " + cbbox + " like '%" + date.Check_Date(txtbox) + "%'";
                }
            }
            return d;
        }
    }
}
