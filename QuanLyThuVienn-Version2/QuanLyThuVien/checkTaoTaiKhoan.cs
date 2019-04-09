using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyThuVien
{
    public class checkTaoTaiKhoan
    {  
        
       
        public static string check_TaoTaiKhoan(string id, string pass, string confpass)
        {
            if (id.Length - 1 < 5)
                return "Id too short";
            else
               if (id.Length - 1 > 30)
                return "Id too long";
            else
                   if (pass.Length - 1 < 5)
                return "Pass too short";
            else
                       if (pass.Length - 1 > 30)
                return "Pass too long";
            else
                           if (pass != confpass)
                return "Pass not same";
            else
            {
                try
                {
                    Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
                    cls.KetNoi();
                    cls.ThucThiSQLTheoPKN("insert into tblNhanVien(TAIKHOAN,MATKHAU,QUYENHAN)values('" + id + "','" + pass + "','user')");
                    //cls.ThucThiSQLTheoPKN("delete tblNhanVien where id = '" + id+"'");
                    return "0";
                }
                catch { return "Existed account"; }
            }
            
        }

    }
}
