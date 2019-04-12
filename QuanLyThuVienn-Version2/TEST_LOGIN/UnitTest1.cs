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
        public void Test_Nhap_ma_NV_qua_dai()
        {
            string actual = checkTaoTaiKhoan.check_TaoTaiKhoan("aaaaabbbbbaaaaabbbbbaaaaabbbbbaa", "123456", "123456");
            string expected = "Id too long";
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
        public void Test_Nhap_MK_Cu_Ngan()
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
        public void Test_Nhap_MK_Cu_Khong_Dung()
        {

            string actual = checkChangePassword.check_changepassword("123456", "abcdef", "abcdef", "1234567");
            string expected = "Mật khẩu cũ sai";
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
        


    }




}
