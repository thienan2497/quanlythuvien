/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{    public partial class timkiem : Form
    {
        public timkiem()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void timkiem_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text + ":";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView1, "select*from tblSach where " + comboBox1.Text + " like'%" + textBox1.Text + "%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView2, "select*from tblSach where MASACH like'%" + textBox2.Text + "%'or TENSACH like'%" + textBox3.Text + "%'or MATG like'%" + textBox4.Text + "%'or MANXB like'%" + textBox5.Text + "%'or MaLV like'%" + textBox7.Text + "%'or NAMXB='" + textBox6.Text + "'or SOLUONG='" + textBox8.Text + "'or NGAYNHAP='" + maskedTextBox1.Text + "'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
*/
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
    public partial class timkiem : Form
    {
        public timkiem()
        {
            InitializeComponent();

        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void timkiem_Load(object sender, EventArgs e)
        {
            cls.KetNoi();

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text + ":";            

            if (comboBox1.SelectedItem.ToString() == "NGAYNHAP")
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
        /*void msDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.MaskFull)
            {
                try
                {
                    DateTime.ParseExact(textBox1.Text, "dd/MM/yyyy", null);
                }
                catch
                {
                    MessageBox.Show("Ngày không hợp lệ");
                    textBox1.ResetText();
                }
            }
        }
        void msDate_KeyUp2(object sender, KeyEventArgs e)
        {
            if (textBox1.MaskFull)
            {
                try
                {
                    DateTime.ParseExact(textBox1.Text, "yyyy", null);
                }
                catch
                {
                    MessageBox.Show("Năm không hợp lệ1");
                    textBox1.ResetText();
                }
            }
        }
        void msDate_KeyUp3(object sender, KeyEventArgs e)
        {
            if (textBox1.MaskFull)
            {
                try
                {
                    textBox1.Text = textBox1.Text;
                }
                catch
                {
                    MessageBox.Show("abc");
                    textBox1.ResetText();
                }
            }
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            Search_Book sea = new Search_Book();
            string cbbox = comboBox1.Text;
            string txtbox = textBox1.Text;
            
            
            cls.LoadData2DataGridView(dataGridView1, sea.search_1(cbbox, txtbox));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView2, "select*from tblSach where MASACH like'%" + textBox2.Text + "%'or TENSACH like'%" + textBox3.Text + "%'or MATG like'%" + textBox4.Text + "%'or MANXB like'%" + textBox5.Text + "%'or MaLV like'%" + textBox7.Text + "%'or NAMXB='" + textBox6.Text + "'or SOLUONG='" + textBox8.Text + "'or NGAYNHAP='" + maskedTextBox1.Text + "'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
