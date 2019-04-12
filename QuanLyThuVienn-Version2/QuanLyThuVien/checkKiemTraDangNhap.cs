using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyThuVien
{
    public class checkKiemTraDangNhap
    {
        public static string ktdangnhap(string id, string pass)
        {
            if ((id == "") && (pass == "")) { return ("1"); }
            else
            if (id == "") { return ("2"); }
            else
            if (pass == "") { return ("3"); }

            else return "0";

        }
    }
/*    public static string TenDN1, MatKhau, Quyen;
    SqlCommand sqlCommand1;
    public Object layGiaTri(string sql) //lay gia tri cua  cot dau tien trong bang 
    {
        sqlCommand = new SqlCommand();
        sqlCommand.CommandText = sql;
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Connection = Con;

        //CHi can lay ve gia tri cua mot truong thoi thi dung pt nao ? - ExecuteScalar
        Object obj = sqlCommand.ExecuteScalar(); //neu co loi thi phai xem lai cua lenh SQL o ben kia
        return obj;
        //Ket qua de dau ? - de trong obj
    }

    public class testKiemtraTTNV
    {
        public static string ktThongtinNV(string id, string pass)
        {
            object Q = lay
            return "0";
        }

    }
    */
}
