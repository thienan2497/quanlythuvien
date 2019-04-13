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
    public partial class capnhatnhanvien : Form
    {
        public capnhatnhanvien()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void capnhatnhanvien_Load(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView1,"select * from tblNhanVien where TAIKHOAN='"+Main.TenDN+"'");
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            var tuoi_n = int.Parse(textBox2.Text);
            if (check_Update_emp.check_update_employee(txtNHANVIEN.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text, textBox1.Text, tuoi_n) == "0")
            {              
                    string strUpdate = "update tblNhanVien set TENNV='" + txtNHANVIEN.Text + "',DIACHI='" + txtDiaChi.Text + "',DIENTHOAI='" + txtSoDienThoai.Text + "',EMAIL='" + txtEmail.Text + "',ChucVu='" + textBox1.Text + "',Tuoi='" + textBox2.Text + "' where TAIKHOAN='" + Main.TenDN + "'";
                    cls.ThucThiSQLTheoKetNoi(strUpdate);
               
                cls.LoadData2DataGridView(dataGridView1, "select * from tblNhanVien where TAIKHOAN='" + Main.TenDN + "'");
                MessageBox.Show("Sửa thành công");
            }
            else MessageBox.Show(check_Update_emp.check_update_employee(txtNHANVIEN.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text, textBox1.Text, tuoi_n));



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNHANVIEN.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSoDienThoai.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string strDelete = "delete from tblNhanVien where TAIKHOAN='" + Main.TenDN + "'";
            //cls.ThucThiSQLTheoPKN(strDelete);
            //cls.LoadData2DataGridView(dataGridView1, "select * from tblNhanVien where TAIKHOAN='" + Main.TenDN + "'");
            //MessageBox.Show("Xóa thành công");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
    }
}
