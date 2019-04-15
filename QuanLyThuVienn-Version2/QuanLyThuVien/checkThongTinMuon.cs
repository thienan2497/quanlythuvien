using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyThuVien
{
    public class checkThongTinMuon
    {public static string check_ThongTinMuon(string madg, string masach, string sophieumuon, string ngaymuon, string ngaytra, string xacnhan, string ghichu, string temp)
        {
            
            if (madg.Length == 0)
            { return ("Bạn phải chọn độc giả"); }
            else if (masach.Length == 0)
            { return ("Bạn phải chọn sách"); }
            else if ((sophieumuon.Length != 6) || (sophieumuon.Substring(0,2) != "PM"))
            { return ("Mã sách phải gồm 6 kí tự và bắt đầu bằng PM"); }
            else if (ngaymuon == temp)
            { return ("Bạn phải nhập ngày mượn"); }
            else if ((xacnhan == "Da Tra") && (ngaytra == temp))
            { return ("Bạn phải nhập ngày trả"); }

            else return "0";
        }

        public static string check_db_ThongTinMuon(string madg, string masach, string sophieumuon, string ngaymuon, string ngaytra, string xacnhan, string ghichu, string temp)
        {
            try
            {
                Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();


                string strInsert = "Insert Into tblMuon(MADG,MASACH,SOPHIEUMUON,NGAYMUON,NGAYTRA,XACNHANTRA,GHICHU) values ('" + madg + "','" + masach + "','" + sophieumuon + "','" + ngaymuon + "','" + ngaytra + "','" + xacnhan + "','" + ghichu + "')";
                
                cls.ThucThiSQLTheoPKN(strInsert);
             
                return "0";
            }
            catch { Exception ex;  return("Trùng mã phiếu mượn"); };
        }





    }
}
