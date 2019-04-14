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
    public partial class TaoTaiKhoan : Form
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kt = checkTaoTaiKhoan.check_TaoTaiKhoan(txtTenTK.Text, txtMatKhau.Text, txtXNMatKhau.Text);
          
            if (kt == "Id too short")
                MessageBox.Show("Tên tài khoản quá ngắn");
            else
                if (kt == "Id too long")
                MessageBox.Show("Tên tài khoản quá dài");
                else
                    if (kt == "Pass too short")
                        MessageBox.Show("Mật khẩu quá ngắn");
                    else
                        if (kt == "Pass too long")
                MessageBox.Show("Mật khẩu quá dài");
                        else
                            if (kt == "Pass not same")
                                MessageBox.Show("Password không trùng nhau");
                            else
                            
                                 if (kt == "0")  
                    // cls.ThucThiSQLTheoPKN("insert into tblNhanVien(TAIKHOAN,MATKHAU,QUYENHAN)values('" + txtTenTK.Text + "','" + txtMatKhau.Text + "','user')");
                                      MessageBox.Show("Tạo tài khoản thành công hãy cập nhật thông tin cho tài khoản");
                            else    
                                if (kt == "Existed account")
                                 MessageBox.Show("Đã tồn tại tài khoản"); 
                            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                txtXNMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtXNMatKhau.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
