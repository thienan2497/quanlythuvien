using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyThuVien;
using System.Windows;



namespace TEST_LOGIN
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Test_Nhap_Dung_Tai_Khoan()
        {
            string actual = testKiemTraTTNV.ktdangnhap("an", "123");
            string expected = "0";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Nhap_Thieu_ID_and_Pass()
        {
            string actual = testKiemTraTTNV.ktdangnhap("", "");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_ID()
        {
            string actual = testKiemTraTTNV.ktdangnhap("", "123");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_Pass()
        {
            string actual = testKiemTraTTNV.ktdangnhap("an", "");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }
    }
}
