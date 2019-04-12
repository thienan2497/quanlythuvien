using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyThuVien;




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
            
            string actual = checkChangePassword.check_changepassword("123456", "1", "1","123456");
            string expected = "Mật khẩu mới quá ngắn";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MK_Moi_Dai()
        {

            string actual = checkChangePassword.check_changepassword("123456", "123456789123456789123456789123456789", "123456789123456789123456789123456789","123456");
            string expected = "Mật khẩu mới quá dài";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MK_Moi_Khong_Trung()
        {

            string actual = checkChangePassword.check_changepassword("123456", "abcdefg", "abcdef","1234567");
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


    }

    [TestClass]
    public class test_Finding
    {
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem()
        {
            Search test_search = new Search();
            string cbbox = "MASACH";
            string txtbox = "S02";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblSach where "+cbbox+" like " + "'%"+txtbox+"%'";
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




}
