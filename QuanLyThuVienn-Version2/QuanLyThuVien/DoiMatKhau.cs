using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kt = checkChangePassword.check_changepassword(txtMkCu.Text, txtMkMoi.Text, txtXNhanLaiMk.Text,Main.MatKhau);
            if (kt == "Mật khẩu mới quá ngắn")
                MessageBox.Show(kt);
            else
                if (kt == "Mật khẩu mới quá dài")//kiểm tra mật khẩu mới xem có bé hơn 30 ký tụ ko
                    MessageBox.Show(kt);
                else
                    if (kt == "Mật khẩu mới không trùng")//kiểm tra mật khẩu mới và xác nhận mk co trung nha
                        MessageBox.Show(kt);
                    else
                        if (kt == "Mật khẩu cũ sai")//kiểm tra mật khẩu cũ
                            MessageBox.Show(kt);
                        else
                        {
                            try//thực hiên cau lệnh để thay đổi mật khẩu
                            {
                                string strUpdate = "Update tblNhanVien set MATKHAU='" + txtMkMoi.Text + "'where MATKHAU='" + txtMkCu.Text + "'";
                                cls.ThucThiSQLTheoKetNoi(strUpdate);
                                MessageBox.Show(kt);
                            }
                            catch (Exception E)
                            { MessageBox.Show("" + E.ToString()); }
                        }
        //    string strUpdate = "Update tblNhanVien set MATKHAU='" + textBox2.Text + "'where MATKHAU='" + textBox1.Text + "'";
        //    cls.ThucThiSQLTheoKetNoi(strUpdate);
        //    MessageBox.Show("Đổi mật khẩu thành công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMkCu.PasswordChar = '\0';
                txtMkMoi.PasswordChar = '\0';
                txtXNhanLaiMk.PasswordChar = '\0';
            }
            else
            {
                txtMkCu.PasswordChar = '*';
                txtMkMoi.PasswordChar = '*';
                txtXNhanLaiMk.PasswordChar = '*';
            }
        }

    }
}
