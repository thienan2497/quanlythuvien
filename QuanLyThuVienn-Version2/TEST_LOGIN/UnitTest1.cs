using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyThuVien;
using System.Windows.Forms;





namespace TEST
{
    [TestClass]
    public class test_login

    {
        [TestMethod]
        public void Test_Nhap_Dung_Tai_Khoan()
        {
            string actual = checkKiemTraDangNhap.ktdangnhap("an", "123");
            string expected = "0";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Nhap_Thieu_ID_and_Pass()
        {
            string actual = checkKiemTraDangNhap.ktdangnhap("", "");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_ID()
        {
            string actual = checkKiemTraDangNhap.ktdangnhap("", "123");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_Pass()
        {
            string actual = checkKiemTraDangNhap.ktdangnhap("an", "");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class test_create_emp
    {
        [TestMethod]
        public void Test_Nhap_Dung_EMP()
        {
            string actual = checkTaoTaiKhoan.check_TaoTaiKhoan("nhanvientest", "123456", "123456");
            string expected = "0";
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Nhap_ma_NV_qua_ngan()
        {
            string actual = checkTaoTaiKhoan.check_TaoTaiKhoan("a", "123456", "123456");
            string expected = "Id too short";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Nhap_ma_NV_qua_ngan_2()
        {
            string actual = checkTaoTaiKhoan.check_TaoTaiKhoan("aaaaa", "123456", "123456");
            string expected = "Id too short";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Nhap_ma_NV_qua_dai()
        {
            string actual = checkTaoTaiKhoan.check_TaoTaiKhoan("aaaaabbbbbaaaaabbbbbaaaaabbbbbaa", "123456", "123456");
            string expected = "Id too long";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Pass_qua_ngan()
        {
            string actual = checkTaoTaiKhoan.check_TaoTaiKhoan("NguyenVanABC", "1", "1");
            string expected = "Pass too short";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Pass_qua_ngan_2()
        {
            string actual = checkTaoTaiKhoan.check_TaoTaiKhoan("NguyenVanABC", "12345", "12345");
            string expected = "Pass too short";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Pass_qua_dai()
        {
            string actual = checkTaoTaiKhoan.check_TaoTaiKhoan("NguyenVanABC", "aaaaabbbbbaaaaabbbbbaaaaabbbbbaa", "aaaaabbbbbaaaaabbbbbaaaaabbbbbaa");
            string expected = "Pass too long";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Pass_khong_trung()
        {
            string actual = checkTaoTaiKhoan.check_TaoTaiKhoan("NguyenVanABC", "123456", "1234567");
            string expected = "Pass not same";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Tao_emp_da_co()
        {
            string actual = checkTaoTaiKhoan.check_TaoTaiKhoan("nguyenvana", "123456", "123456");
            string expected = "Existed account";
            Assert.AreEqual(expected, actual);

        }
    }
    [TestClass]
    public class test_change_password
    {
        [TestMethod]
        public void Test_Nhap_Dung()
        {

            string actual = checkChangePassword.check_changepassword("123456", "abcdef", "abcdef", "123456");
            string expected = "Đổi mật khẩu thành công";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MK_Cu_Khong_Dung()
        {

            string actual = checkChangePassword.check_changepassword("123456", "abcdef", "abcdef", "1234567");
            string expected = "Mật khẩu cũ sai";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MK_Moi_Ngan()
        {

            string actual = checkChangePassword.check_changepassword("123456", "1", "1", "123456");
            string expected = "Mật khẩu mới quá ngắn";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MK_Moi_Dai()
        {

            string actual = checkChangePassword.check_changepassword("123456", "123456789123456789123456789123456789", "123456789123456789123456789123456789", "123456");
            string expected = "Mật khẩu mới quá dài";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MK_Moi_Khong_Trung()
        {

            string actual = checkChangePassword.check_changepassword("123456", "abcdefg", "abcdef", "1234567");
            string expected = "Mật khẩu mới không trùng";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Khong_nhap_lai_MK()
        {

            string actual = checkChangePassword.check_changepassword("123456", "abcdefg", "", "123456");
            string expected = "Mật khẩu mới không trùng";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Khong_Nhap_MK_Moi()
        {

            string actual = checkChangePassword.check_changepassword("123456", "", "abcdefg", "123456");
            string expected = "Mật khẩu mới quá ngắn";
            Assert.AreEqual(expected, actual);
        }



    }
    [TestClass]
    public class test_update_emp
    {
        [TestMethod]
        public void Test_Nhap_Dung_Du_Lieu()
        {
            string actual = check_Update_emp.check_update_employee("Thien An", "88/1 Dao Duy Anh", "0708339999", "thienan@gmail.com", "Trum cuoi", 99);
            string expected = "0";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Nhap_Dung_Du_Lieu_Va_Kiem_Tra_Database()
        {
            string actual = check_Update_emp.check_update_employee("Thien An", "88/1 Dao Duy Anh", "0708339999", "thienan@gmail.com", "Trum cuoi", 12);
            if (actual == "0")
            {

                bool actual2 = check_Update_emp.update_database("Thien An", "88/1 Dao Duy Anh", "0708339999", "thienan@gmail.com", "Trum cuoi", 12);
                bool expected2 = true;
                Assert.AreEqual(actual2, expected2);
            }
            else Assert.Fail();
        }
        [TestMethod]
        public void Test_Nhap_Ten_Dai()
        {
            string actual = check_Update_emp.check_update_employee("Thien An Thien An Thien An Thien An Thien An Thien An", "88/1 Dao Duy Anh", "0708339999", "thienan@gmail.com", "Trum cuoi", 12);
            string expected = "Tên nhân viên quá dài";
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void Test_Nhap_Ten_Ngan()
        {
            string actual = check_Update_emp.check_update_employee("", "88/1 Dao Duy Anh", "0708339999", "thienan@gmail.com", "Trum cuoi", 12);
            string expected = "Tên nhân viên quá ngắn";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_Dia_Chi_Qua_Dai()
        {
            string actual = check_Update_emp.check_update_employee("Thien An", "88/1 Dao Duy Anh 88/1 Dao Duy Anh 88/1 Dao Duy Anh 88/1 Dao Duy Anh 88/1 Dao Duy Anh 88/1 Dao Duy Anh 88/1 Dao Duy Anh 88/1 Dao Duy Anh 88/1 Dao Duy Anh 88/1 Dao Duy Anh 88/1 Dao Duy Anh 88/1 Dao Duy Anh ", "0708339999", "thienan@gmail.com", "Trum cuoi", 12);
            string expected = "Địa chỉ quá dài";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_SDT_Khong_Du_10_So()
        {
            string actual = check_Update_emp.check_update_employee("Thien An", "88/1 Dao Duy Anh", "07083399991", "thienan@gmail.com", "Trum cuoi", 99);
            string expected = "Số điện thoại phải có 10 số";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_SDT_Khong_Du_10_So_2()
        {
            string actual = check_Update_emp.check_update_employee("Thien An", "88/1 Dao Duy Anh", "070833999", "thienan@gmail.com", "Trum cuoi", 99);
            string expected = "Số điện thoại phải có 10 số";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Tuoi_Nho_Hon_7()
        {
            string actual = check_Update_emp.check_update_employee("Thien An", "88/1 Dao Duy Anh", "0708339999", "thienan@gmail.com", "Trum cuoi", 6);
            string expected = "Độ tuổi phải trong khoảng 7 đến 120";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Tuoi_Lon_Hon_120()
        {
            string actual = check_Update_emp.check_update_employee("Thien An", "88/1 Dao Duy Anh", "0708339999", "thienan@gmail.com", "Trum cuoi", 121);
            string expected = "Độ tuổi phải trong khoảng 7 đến 120";
            Assert.AreEqual(expected, actual);
        }




    }

    [TestClass]
    public class test_Finding_Book
    {
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem()
        {
            Search test_search = new Search();
            string cbbox = "MASACH";
            string txtbox = "S02";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblSach where " + cbbox + " like " + "'%" + txtbox + "%'";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem_2()
        {
            Search test_search = new Search();
            string cbbox = "MaLv";
            string txtbox = "LV01";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblSach where " + cbbox + " like " + "'%" + txtbox + "%'";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Bo_Trong_ComboBox_Bo_Trong_Thong_Tin()
        {
            Search test_search = new Search();
            string cbbox = "";
            string txtbox = "";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select * from tblSach";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chon_ComboBox_Bo_Trong_Thong_Tin()
        {
            Search test_search = new Search();
            string cbbox = "MASACH";
            string txtbox = "";
            string actual = test_search.search_1(cbbox, txtbox);
            string expected = "select*from tblSach where MASACH like '%%'";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chon_ComboBox_Bo_Trong_Thong_Tin_2()
        {
            Search test_search = new Search();
            string cbbox = "TENSACH";
            string txtbox = "";
            string actual = test_search.search_1(cbbox, txtbox);
            string expected = "select*from tblSach where TENSACH like '%%'";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chon_ComboBox_Nhap_Thong_Tin_Qua_Dai()
        {
            Search test_search = new Search();
            string cbbox = "MATG";
            string txtbox = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//31 ky tu
            string actual = test_search.search_1(cbbox, txtbox);
            string expected = "Tên tác giả quá dài";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chon_ComboBox_Nhap_Thong_Tin_Qua_Dai_2()
        {
            Search test_search = new Search();
            string cbbox = "MANXB";
            string txtbox = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//31 ky tu
            string actual = test_search.search_1(cbbox, txtbox);
            string expected = "Mã NXB hoặc tên NXB quá dài";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_sai_dinh_dang_nam()
        {
            Search test_search = new Search();
            string cbbox = "NAMXB";
            string txtbox = "aaaa";//31 ky tu

            CheckDate date = new CheckDate();
            string actual1 = date.Check_Year(txtbox);
            string expected1 = "Năm không hợp lệ";
            Assert.AreEqual(expected1, actual1);

            string actual2 = test_search.search_1(cbbox, txtbox);
            string expected2 = "select * from tblSach";
            Assert.AreEqual(expected2, actual2);
        }//1919 2119

        [TestMethod]
        public void Test_Nhap_sai_dinh_dang_ngay()
        {
            Search test_search = new Search();
            string cbbox = "NGAYNHAP";
            string txtbox = "30/02/2019";//31 ky tu

            CheckDate date = new CheckDate();
            string actual1 = date.Check_Date(txtbox);
            string expected1 = "Ngày không hợp lệ";
            Assert.AreEqual(expected1, actual1);

            string actual2 = test_search.search_1(cbbox, txtbox);
            string expected2 = "select * from tblSach";
            Assert.AreEqual(expected2, actual2);
        }//1919 2119
    }

    [TestClass]
    public class test_Finding_KH
    {
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem()
        {
            Search test_search = new Search();
            string cbbox = "MASACH";
            string txtbox = "S02";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblSach where " + cbbox + " like " + "'%" + txtbox + "%'";
            Assert.AreEqual(expected, actual);
        }

    }
}

   
        