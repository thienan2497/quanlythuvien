using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class TimkiemDG : Form
    {
        public TimkiemDG()
        {
            InitializeComponent();
        }
        Class.clsDatabase Cls = new QuanLyThuVien.Class.clsDatabase();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text + ":";
      

            if (comboBox1.SelectedItem.ToString() == "NGAYSINH")
            {
                textBox1.Clear();
                textBox1.Mask = "00/00/0000";
                //textBox1.KeyUp += new KeyEventHandler(msDate_KeyUp);

            }
            else if (comboBox1.SelectedItem.ToString() == "NAMXB")
            {
                textBox1.Clear();
                textBox1.Mask = "0000";
                //textBox1.KeyUp += new KeyEventHandler(msDate_KeyUp2);
            }
            else
            {
                //string sMsk = textBox1.Mask;
                textBox1.Mask = "";
                textBox1.Text = "";
                //textBox1.KeyUp += new KeyEventHandler(msDate_KeyUp3);
                
                // textBox1.Mask = sMsk;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cls.LoadData2DataGridView(dataGridView1, "select*from tblDocGia where " + comboBox1.Text + " like'%" + textBox11.Text + "%'");

            searchDG sea = new searchDG();
            string cbbox = comboBox1.Text;
            string txtbox = textBox1.Text;


            Cls.LoadData2DataGridView(dataGridView1, sea.search_1(cbbox, txtbox));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cls.LoadData2DataGridView(dataGridView2, "select*from tblDocGia where MADG like'%" + textBox2.Text + "%'or HOTEN like'%" + textBox3.Text + "%'or NGAYSINH='" + maskedTextBox1.Text + "'or GIOITINH='" + textBox4.Text + "'or LOP like'%" + textBox5.Text + "%'or DIACHI like'%"+textBox6.Text+"%'");
        }

        private void TimkiemDG_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimkiemDG_Load(object sender, EventArgs e)
        {
            //Cls.KetNoi();
        }
    }
}
