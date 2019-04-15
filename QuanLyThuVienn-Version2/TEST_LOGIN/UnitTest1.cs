using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyThuVien;
using System.Windows.Forms;
using QuanLyThuVien.Class;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

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
            Search_Book test_search = new Search_Book();
            string cbbox = "MASACH";
            string txtbox = "S02";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblSach where " + cbbox + " like " + "'%" + txtbox + "%'";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem_2()
        {
            Search_Book test_search = new Search_Book();
            string cbbox = "MaLv";
            string txtbox = "LV01";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblSach where " + cbbox + " like " + "'%" + txtbox + "%'";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem_3()
        {
            Search_Book test_search = new Search_Book();
            string cbbox = "MANXB";
            string txtbox = "NXB01";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblSach where MANXB like '%" + txtbox + "%'";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Bo_Trong_ComboBox_Bo_Trong_Thong_Tin()
        {
            Search_Book test_search = new Search_Book();
            string cbbox = "";
            string txtbox = "";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select * from tblSach";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chon_ComboBox_Bo_Trong_Thong_Tin()
        {
            Search_Book test_search = new Search_Book();
            string cbbox = "MASACH";
            string txtbox = "";
            string actual = test_search.search_1(cbbox, txtbox);
            string expected = "select*from tblSach where MASACH like '%%'";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chon_ComboBox_Bo_Trong_Thong_Tin_2()
        {
            Search_Book test_search = new Search_Book();
            string cbbox = "TENSACH";
            string txtbox = "";
            string actual = test_search.search_1(cbbox, txtbox);
            string expected = "select*from tblSach where TENSACH like '%%'";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chon_ComboBox_Nhap_Thong_Tin_Qua_Dai()
        {
            Search_Book test_search = new Search_Book();
            string cbbox = "MATG";
            string txtbox = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//31 ky tu
            string actual = test_search.search_1(cbbox, txtbox);
            string expected = "Tên tác giả quá dài";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chon_ComboBox_Nhap_Thong_Tin_Qua_Dai_2()
        {
            Search_Book test_search = new Search_Book();
            string cbbox = "MANXB";
            string txtbox = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//31 ky tu
            string actual = test_search.search_1(cbbox, txtbox);
            string expected = "Mã NXB hoặc tên NXB quá dài";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chon_ComboBox_Nhap_Thong_Tin_Qua_Dai_3()
        {
            Search_Book test_search = new Search_Book();
            string cbbox = "MaLv";
            string txtbox = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//31 ky tu
            string actual = test_search.search_1(cbbox, txtbox);
            string expected = "Mã lĩnh vực quá dài";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_sai_dinh_dang_nam()
        {
            Search_Book test_search = new Search_Book();
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
            Search_Book test_search = new Search_Book();
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
    public class test_Finding_DG
    {
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem()
        {
            searchDG test_search = new searchDG();
            string cbbox = "MADG";
            string txtbox = "DG01";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblDocGia where MADG like '%" + txtbox + "%'";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem_2()
        {
            searchDG test_search = new searchDG();
            string cbbox = "HOTEN";
            string txtbox = "Doan Van Hau";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblDocGia where HOTEN like '%" + txtbox + "%'";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem_3()
        {
            searchDG test_search = new searchDG();
            string cbbox = "GIOITINH";
            string txtbox = "Nam";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblDocGia where GIOITINH like '%" + txtbox + "%'";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem_4()
        {
            searchDG test_search = new searchDG();
            string cbbox = "LOP";
            string txtbox = "Nam";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "select*from tblDocGia where LOP like '%" + txtbox + "%'";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Tim_Kiem_5()
        {
            searchDG test_search = new searchDG();
            string cbbox = "NGAYSINH";
            string txtbox = "28/02/2019";
            CheckDate date = new CheckDate();

            if (date.Check_Date(txtbox) == "Ngày không hợp lệ")
                Assert.Fail();

            string actual = test_search.search_1(cbbox, txtbox);


            string expected = "select*from tblDocGia where " + cbbox + " like '%" + date.Check_Date(txtbox) + "%'";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Sai_Ngay()
        {
            searchDG test_search = new searchDG();
            string cbbox = "NGAYSINH";
            string txtbox = "29/02/2019";
            CheckDate date = new CheckDate();

            Assert.IsTrue(date.Check_Date(txtbox) == "Ngày không hợp lệ");
        }
        [TestMethod]
        public void Test_Nhap_Sai_Ngay_2()
        {
            searchDG test_search = new searchDG();
            string cbbox = "NGAYSINH";
            string txtbox = "32/12/2019";
            CheckDate date = new CheckDate();

            Assert.IsTrue(date.Check_Date(txtbox) == "Ngày không hợp lệ");
        }
        [TestMethod]
        public void Test_Nhap_MADG_QUA_DAI()
        {
            searchDG test_search = new searchDG();
            string cbbox = "MADG";
            string txtbox = "DG0000001";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "Mã độc giả quá dài";
        }

        [TestMethod]
        public void Test_Nhap_Gioi_Tinh_SAI()
        {
            searchDG test_search = new searchDG();
            string cbbox = "GIOITINH";
            string txtbox = "Namm";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "Giới tính bị sai";
        }
        [TestMethod]
        public void Test_Nhap_Lop_Sai()
        {
            searchDG test_search = new searchDG();
            string cbbox = "LOP";
            string txtbox = "TK0001TK00011";
            string actual = test_search.search_1(cbbox, txtbox);

            string expected = "Lớp quá dài";
        }
        [TestMethod]
        public void Test_Nhap_sai_dinh_dang_ngay()
        {
            searchDG test_search = new searchDG();
            string cbbox = "NGAYNHAP";
            string txtbox = "30/02/2019";//31 ky tu

            CheckDate date = new CheckDate();
            string actual1 = date.Check_Date(txtbox);
            string expected1 = "Ngày không hợp lệ";
            Assert.AreEqual(expected1, actual1);

            string actual2 = test_search.search_1(cbbox, txtbox);
            string expected2 = "select * from tblDocGia";
            Assert.AreEqual(expected2, actual2);
        }
    }

    [TestClass]
    public class test_chinhsua_xoa_nhanvien
    {
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin_Chinh_Sua()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "123456", "user", "111 LVS", "Nhan vien thu ngan", 22, "0123833999");
            string actual = "0";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_De_Trong_Ten_NV()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "", "123456", "user", "111 LVS", "Nhan vien thu ngan", 22, "0123833999");
            string actual = "Không được để trống tên nhân viên";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_De_Trong_Ten_NV_2()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "a", "123456", "user", "111 LVS", "Nhan vien thu ngan", 22, "0123833999");
            string actual = "0";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_De_Trong_MK()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "", "user", "111 LVS", "Nhan vien thu ngan", 22, "0123833999");
            string actual = "Không được để trống mật khẩu";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_De_Trong_MK_2()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "1", "user", "111 LVS", "Nhan vien thu ngan", 22, "0123833999");
            string actual = "Mật khẩu ít nhất phải có 6 kí tự";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Mat_Khau_Ngan()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "12345", "user", "111 LVS", "Nhan vien thu ngan", 22, "0123833999");
            string actual = "Mật khẩu ít nhất phải có 6 kí tự";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Quyen_User_Khong_Duoc_Chinh_Sua()
        {
            string expected = checkThongTinNhanVien.check_update_emp("user", "Le Quyen", "123456", "user", "111 LVS", "Nhan vien thu ngan", 22, "0123833999");
            string actual = "Bạn không có quyền chỉnh sửa và xóa";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_De_Trong_Quyen_Han()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "123456", "", "111 LVS", "Nhan vien thu ngan", 22, "0123833999");
            string actual = "Không được để trống quyền hạn";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_De_Trong_Dia_Chi()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "123456", "user", "", "Nhan vien thu ngan", 22, "0123833999");
            string actual = "Không được để trống địa chỉ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_De_Trong_Chuc_Vu()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "123456", "user", "111 LVS", "", 22, "0123833999");
            string actual = "Không được để trống chức vụ";

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(System.FormatException), "Input string was not in a correct format.")]
        public void Test_Nhap_Ki_Tu_Khong_Phai_So_Cho_Tuoi()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "123456", "user", "111 LVS", "Nhan vien thu ngan", int.Parse("aa"), "0123833999");
        }

        [TestMethod]
        public void Test_Nhap_Tuoi_Sai()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "123456", "user", "111 LVS", "Nhan vien thu ngan", 6, "0123833999");
            string actual = "Độ tuổi phải trong khoảng 7 đến 120";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhap_Tuoi_Sai_2()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "123456", "user", "111 LVS", "Nhan vien thu ngan", 121, "0123833999");
            string actual = "Độ tuổi phải trong khoảng 7 đến 120";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhap_Sai_SDT()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "123456", "user", "111 LVS", "Nhan vien thu ngan", 22, "012383399");
            string actual = "Số điện thoại phải có 10 số";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhap_Sai_SDT_2()
        {
            string expected = checkThongTinNhanVien.check_update_emp("admin", "Le Quyen", "123456", "user", "111 LVS", "Nhan vien thu ngan", 22, "01238339911");
            string actual = "Số điện thoại phải có 10 số";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Quyen_Xoa_Nhan_Vien()
        {
            string expected = checkThongTinNhanVien.check_delete_emp("admin", "an");
            string actual = "0";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Quyen_Xoa_Nhan_Vien_2()
        {
            string expected = checkThongTinNhanVien.check_delete_emp("user", "xuyentb");
            string actual = "Không thể xóa tài khoản admin";

            Assert.AreEqual(expected, actual);
        }




    }

    [TestClass]
    public class test_cap_nhap_thong_tin_sach
    {
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S00006", "Toan cao cap 2", "TG01", "NXB01", "LV01", "2012", "20",30,"03/05/2019"," ",1);                                                                        
            string actual = "0";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhap_MA_SACH_SAI()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S0006", "Toan cao cap 2", "TG01", "NXB01", "LV01", "2012", "20", 30, "03/05/2019", " ", 1);
            string actual = "Mã sách phải gồm 6 kí tự và bắt đầu bằng S";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MA_SACH_SAI_2()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("A00006", "Toan cao cap 2", "TG01", "NXB01", "LV01", "2012", "20", 30, "03/05/2019", " ", 1);
            string actual = "Mã sách phải gồm 6 kí tự và bắt đầu bằng S";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_KHONG_NHAP_TEN_SACH()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S00006", "", "TG01", "NXB01", "LV01", "2012", "20", 30, "03/05/2019", " ", 1);
            string actual = "Bạn phải nhập tên sách";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_NHAP_TEN_SACH_DAI()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S00006", "Toan cao cap Toan cao cap Toan cao cap Toan cao cap", "TG01", "NXB01", "LV01", "2012", "20", 30, "03/05/2019", " ", 1);
            string actual = "Tên sách quá dài";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_KHONG_NHAP_NAM_XUAT_BAN()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S00006", "Toan cao cap 2", "TG01", "NXB01", "LV01", "", "20", 30, "03/05/2019", " ", 1);
            string actual = "Bạn phải nhập năm xuất bản";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_NHAP_NAM_XUAT_BAN_SAI()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S00006", "Toan cao cap 2", "TG01", "NXB01", "LV01", "201", "20", 30, "03/05/2019", " ", 1);
            string actual = "Năm xuất bản không hợp lệ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_NHAP_NAM_XUAT_BAN_SAI_2()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S00006", "Toan cao cap 2", "TG01", "NXB01", "LV01", "20111", "20", 30, "03/05/2019", " ", 1);
            string actual = "Năm xuất bản không hợp lệ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_NHAP_SO_LUONG_HONG_LON_HON_SO_LUONG_NHAP_VAO()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S00006", "Toan cao cap 2", "TG01", "NXB01", "LV01", "2011", "20", 30, "03/05/2019", " ", 31);
            string actual = "Số lượng sách hỏng không được lớn hơn số lượng sách nhập vào";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_KHONG_CHON_LV()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S00006", "Toan cao cap 2", "TG01", "NXB01", "", "2011", "20", 30, "03/05/2019", " ", 3);
            string actual = "Bạn phải chọn lĩnh vực";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_KHONG_CHON_TG()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S00006", "Toan cao cap 2", "", "NXB01", "LV01", "2011", "20", 30, "03/05/2019", " ", 3);
            string actual = "Bạn phải chọn tác giả";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_KHONG_CHON_NXB()
        {
            string expected = checkInsertandUpdateBook.check_insertBook("S00006", "Toan cao cap 2", "TG01", "", "LV01", "2011", "20", 30, "03/05/2019", " ", 3);
            string actual = "Bạn phải chọn nhà xuất bản";

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class test_cap_nhap_thong_tin_muon
    {
        [TestMethod]
        public void Test_Nhap_Dung_Thong_Tin()
        {
            string expected = checkThongTinMuon.check_ThongTinMuon("DG01", "S00001", "PM0001", "03/04/2019", "04/05/2019", "Da Tra", " ", " / /");
            string actual = "0";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Khong_Chon_DG()
        {
            string expected = checkThongTinMuon.check_ThongTinMuon("", "S00001", "PM0001", "03/04/2019", "04/05/2019", "Da Tra", " ", " / /");
            string actual = "Bạn phải chọn độc giả";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Khong_Chon_Sach()
        {
            string expected = checkThongTinMuon.check_ThongTinMuon("DG01", "S00001", "PM0001", "03/04/2019", "04/05/2019", "Da Tra", " ", " / /");
            string actual = "Bạn phải chọn sách";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_NHAP_MA_PHIEU_MUON_SAI()
        {
            string expected = checkThongTinMuon.check_ThongTinMuon("DG01", "S00001", "PM001", "03/04/2019", "04/05/2019", "Da Tra", " ", " / /");
            string actual = "Mã sách phải gồm 6 kí tự và bắt đầu bằng PM";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_NHAP_MA_PHIEU_MUON_SAI_2()
        {
            string expected = checkThongTinMuon.check_ThongTinMuon("DG01", "S00001", "PM00001", "03/04/2019", "04/05/2019", "Da Tra", " ", " / /");
            string actual = "Mã sách phải gồm 6 kí tự và bắt đầu bằng PM";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_KHONG_NHAP_NGAY_NHAP()
        {
            string expected = checkThongTinMuon.check_ThongTinMuon("DG01", "S00001", "PM0001", "", "04/05/2019", "Da Tra", " ", "");
            string actual = "Bạn phải nhập ngày mượn";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_DA_TRA_NHUNG_CHUA_NHAP_NGAY_TRA()
        {
            string expected = checkThongTinMuon.check_ThongTinMuon("DG01", "S00001", "PM0001", "03/04/2019", " ", "Da Tra", " ", " ");
            string actual = "Bạn phải nhập ngày trả";

            Assert.AreEqual(expected, actual);
        }
    }
        ////[ExpectedException(typeof(System.FormatException), "Input string was not in a correct format.")]
        //[TestMethod] 
        //public void Test_NHAP_MA_PHIEU_TRUNG()
        //{
        //   // string expected = checkThongTinMuon.check_ThongTinMuon("DG01", "S00001", "PM0001", "03/04/2019", "05/04/2019", "Da Tra", " ", " ");
        //  //  Assert.IsTrue(expected == "0");
        //    string expected2 = checkThongTinMuon.check_db_ThongTinMuon("DG01", "S00001", "PM0001", "35/98/2019", "35/34/2019", "Da Tra", " ", " ");





        //}


        [TestClass]
        public class UTConnectsql
        {
            private QuanLyThuVien.Class.clsDatabase cn = null;
            [TestInitialize]
            public void Setup()
            {
                cn = new clsDatabase();
            }
            [TestMethod]
            public void Kiemtra_Phuongthucconnect()
            {
                cn.KetNoi();
                string strConnect = @"Data Source=DESKTOP-EB0DIJU\SQLEXPRESS2;Initial Catalog=Library;Integrated Security=True";
                SqlConnection sqlCon = new SqlConnection(strConnect);
                Assert.IsTrue(sqlCon.State == ConnectionState.Closed);
            }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Kiemtra_Phuongthucconnect_Nhapsaichuoiketnoi()
        {
            string cnstr = @"Data Source=DESKTOP-EB0DIJU\SQLEXPRESS2;Initial Catalog=Library;Integrated Security=Truee";
            cn.KetNoi();
            SqlConnection sqlCon = new SqlConnection(cnstr);

        }
        [TestMethod]
        public void Kiemtra_PhuongthucDisconnect()
        {
            cn.KetNoi();
            
            string strConnect = @"Data Source=DESKTOP-EB0DIJU\SQLEXPRESS2;Initial Catalog=Library;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strConnect);
            cn.NgatKetNoi();
            Assert.IsFalse(sqlCon.State == ConnectionState.Open);
        }





    }

}


   
        