﻿namespace QLThuVien
{
    partial class frmSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btntensach = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttheloaisach = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txttg = new System.Windows.Forms.TextBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtnamxb = new System.Windows.Forms.TextBox();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.txtnxb = new System.Windows.Forms.TextBox();
            this.PICHINH = new System.Windows.Forms.PictureBox();
            this.BTNHINH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntimkiemttv = new System.Windows.Forms.Button();
            this.txttimkiemma = new System.Windows.Forms.TextBox();
            this.dgvttsach = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbltong = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxoasach = new System.Windows.Forms.Button();
            this.btnthemsach = new System.Windows.Forms.Button();
            this.btnsuasach = new System.Windows.Forms.Button();
            this.btnluusach = new System.Windows.Forms.Button();
            this.lblhienthinv = new System.Windows.Forms.Label();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnin1 = new System.Windows.Forms.Button();
            this.lbltieude = new System.Windows.Forms.Label();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.btndau = new System.Windows.Forms.Button();
            this.btnlui = new System.Windows.Forms.Button();
            this.btntoi = new System.Windows.Forms.Button();
            this.btncuoi = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PICHINH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttsach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(17, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thể Loại Sách";
            // 
            // btntensach
            // 
            this.btntensach.AutoSize = true;
            this.btntensach.BackColor = System.Drawing.Color.Transparent;
            this.btntensach.Location = new System.Drawing.Point(17, 301);
            this.btntensach.Name = "btntensach";
            this.btntensach.Size = new System.Drawing.Size(54, 13);
            this.btntensach.TabIndex = 0;
            this.btntensach.Text = "Tên Sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(21, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "NXB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(19, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình Trạng";
            // 
            // txttheloaisach
            // 
            this.txttheloaisach.Location = new System.Drawing.Point(107, 250);
            this.txttheloaisach.Name = "txttheloaisach";
            this.txttheloaisach.Size = new System.Drawing.Size(201, 20);
            this.txttheloaisach.TabIndex = 1;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(107, 301);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(203, 20);
            this.txtTensach.TabIndex = 1;
            // 
            // txttg
            // 
            this.txttg.Location = new System.Drawing.Point(107, 337);
            this.txttg.Name = "txttg";
            this.txttg.Size = new System.Drawing.Size(201, 20);
            this.txttg.TabIndex = 1;
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(110, 30);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(92, 20);
            this.txtMasach.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(19, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm NXB";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(110, 71);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(95, 20);
            this.txtsoluong.TabIndex = 1;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress_1);
            // 
            // txtnamxb
            // 
            this.txtnamxb.Location = new System.Drawing.Point(107, 115);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(95, 20);
            this.txtnamxb.TabIndex = 1;
            this.txtnamxb.TextChanged += new System.EventHandler(this.txtnamxb_TextChanged);
            this.txtnamxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnamxb_KeyPress);
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(107, 204);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(203, 20);
            this.txttinhtrang.TabIndex = 1;
            // 
            // txtnxb
            // 
            this.txtnxb.Location = new System.Drawing.Point(110, 163);
            this.txtnxb.Name = "txtnxb";
            this.txtnxb.Size = new System.Drawing.Size(95, 20);
            this.txtnxb.TabIndex = 1;
            // 
            // PICHINH
            // 
            this.PICHINH.Location = new System.Drawing.Point(222, 19);
            this.PICHINH.Name = "PICHINH";
            this.PICHINH.Size = new System.Drawing.Size(127, 138);
            this.PICHINH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICHINH.TabIndex = 2;
            this.PICHINH.TabStop = false;
            // 
            // BTNHINH
            // 
            this.BTNHINH.Location = new System.Drawing.Point(249, 166);
            this.BTNHINH.Name = "BTNHINH";
            this.BTNHINH.Size = new System.Drawing.Size(75, 23);
            this.BTNHINH.TabIndex = 3;
            this.BTNHINH.Text = "Hình";
            this.BTNHINH.UseVisualStyleBackColor = true;
            this.BTNHINH.Click += new System.EventHandler(this.BTNHINH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.groupBox1.Controls.Add(this.btntimkiemttv);
            this.groupBox1.Controls.Add(this.txttimkiemma);
            this.groupBox1.Controls.Add(this.BTNHINH);
            this.groupBox1.Controls.Add(this.PICHINH);
            this.groupBox1.Controls.Add(this.txtnxb);
            this.groupBox1.Controls.Add(this.txttinhtrang);
            this.groupBox1.Controls.Add(this.txtnamxb);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMasach);
            this.groupBox1.Controls.Add(this.txttg);
            this.groupBox1.Controls.Add(this.txtTensach);
            this.groupBox1.Controls.Add(this.txttheloaisach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btntensach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 405);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // btntimkiemttv
            // 
            this.btntimkiemttv.BackgroundImage = global::QLThuVien.Properties.Resources.application_form_magnify_icon__1_;
            this.btntimkiemttv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntimkiemttv.Location = new System.Drawing.Point(205, 369);
            this.btntimkiemttv.Name = "btntimkiemttv";
            this.btntimkiemttv.Size = new System.Drawing.Size(90, 33);
            this.btntimkiemttv.TabIndex = 4;
            this.btntimkiemttv.Text = "      Tìm Kiếm";
            this.btntimkiemttv.UseVisualStyleBackColor = true;
            this.btntimkiemttv.Click += new System.EventHandler(this.btntimkiemttv_Click);
            // 
            // txttimkiemma
            // 
            this.txttimkiemma.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiemma.Location = new System.Drawing.Point(36, 376);
            this.txttimkiemma.Name = "txttimkiemma";
            this.txttimkiemma.Size = new System.Drawing.Size(163, 20);
            this.txttimkiemma.TabIndex = 5;
            this.txttimkiemma.Text = "Ma can tim";
            // 
            // dgvttsach
            // 
            this.dgvttsach.AllowUserToAddRows = false;
            this.dgvttsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvttsach.Location = new System.Drawing.Point(5, 19);
            this.dgvttsach.Name = "dgvttsach";
            this.dgvttsach.Size = new System.Drawing.Size(731, 295);
            this.dgvttsach.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hiện có:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(74, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sách";
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.BackColor = System.Drawing.Color.Transparent;
            this.lbltong.Location = new System.Drawing.Point(59, 322);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(0, 13);
            this.lbltong.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.groupBox2.Controls.Add(this.lbltong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvttsach);
            this.groupBox2.Location = new System.Drawing.Point(364, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 338);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Thông Tin ";
            // 
            // btnxoasach
            // 
            this.btnxoasach.BackgroundImage = global::QLThuVien.Properties.Resources.application_form_delete_icon__1_;
            this.btnxoasach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnxoasach.Location = new System.Drawing.Point(423, 19);
            this.btnxoasach.Name = "btnxoasach";
            this.btnxoasach.Size = new System.Drawing.Size(86, 25);
            this.btnxoasach.TabIndex = 0;
            this.btnxoasach.Text = "Xóa";
            this.btnxoasach.UseVisualStyleBackColor = true;
            this.btnxoasach.Click += new System.EventHandler(this.btnxoasach_Click);
            // 
            // btnthemsach
            // 
            this.btnthemsach.BackgroundImage = global::QLThuVien.Properties.Resources.Other_Power_Restart_Metro_icon__2_;
            this.btnthemsach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthemsach.Location = new System.Drawing.Point(25, 19);
            this.btnthemsach.Name = "btnthemsach";
            this.btnthemsach.Size = new System.Drawing.Size(86, 25);
            this.btnthemsach.TabIndex = 0;
            this.btnthemsach.Text = "Thêm";
            this.btnthemsach.UseVisualStyleBackColor = true;
            this.btnthemsach.Click += new System.EventHandler(this.btnthemsach_Click);
            // 
            // btnsuasach
            // 
            this.btnsuasach.BackgroundImage = global::QLThuVien.Properties.Resources.application_form_edit_icon__1_;
            this.btnsuasach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsuasach.Location = new System.Drawing.Point(286, 19);
            this.btnsuasach.Name = "btnsuasach";
            this.btnsuasach.Size = new System.Drawing.Size(86, 25);
            this.btnsuasach.TabIndex = 0;
            this.btnsuasach.Text = "Sửa";
            this.btnsuasach.UseVisualStyleBackColor = true;
            this.btnsuasach.Click += new System.EventHandler(this.btnsuasach_Click);
            // 
            // btnluusach
            // 
            this.btnluusach.BackgroundImage = global::QLThuVien.Properties.Resources.application_form_add_icon1;
            this.btnluusach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnluusach.Location = new System.Drawing.Point(156, 19);
            this.btnluusach.Name = "btnluusach";
            this.btnluusach.Size = new System.Drawing.Size(86, 25);
            this.btnluusach.TabIndex = 0;
            this.btnluusach.Text = "Lưu";
            this.btnluusach.UseVisualStyleBackColor = true;
            this.btnluusach.Click += new System.EventHandler(this.btnluusach_Click);
            // 
            // lblhienthinv
            // 
            this.lblhienthinv.AutoSize = true;
            this.lblhienthinv.Location = new System.Drawing.Point(22, -10);
            this.lblhienthinv.Name = "lblhienthinv";
            this.lblhienthinv.Size = new System.Drawing.Size(0, 13);
            this.lblhienthinv.TabIndex = 2;
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Location = new System.Drawing.Point(539, 25);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(0, 13);
            this.lblthongbao.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.groupBox3.Controls.Add(this.btnin1);
            this.groupBox3.Controls.Add(this.lblthongbao);
            this.groupBox3.Controls.Add(this.lblhienthinv);
            this.groupBox3.Controls.Add(this.btnluusach);
            this.groupBox3.Controls.Add(this.btnsuasach);
            this.groupBox3.Controls.Add(this.btnthemsach);
            this.groupBox3.Controls.Add(this.btnxoasach);
            this.groupBox3.Location = new System.Drawing.Point(3, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1055, 64);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử Lý";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnin1
            // 
            this.btnin1.BackgroundImage = global::QLThuVien.Properties.Resources.Printer_icon;
            this.btnin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnin1.ForeColor = System.Drawing.Color.Black;
            this.btnin1.Location = new System.Drawing.Point(949, 13);
            this.btnin1.Name = "btnin1";
            this.btnin1.Size = new System.Drawing.Size(90, 31);
            this.btnin1.TabIndex = 5;
            this.btnin1.Text = "    In";
            this.btnin1.UseVisualStyleBackColor = true;
            this.btnin1.Click += new System.EventHandler(this.btnin1_Click);
            // 
            // lbltieude
            // 
            this.lbltieude.AutoSize = true;
            this.lbltieude.BackColor = System.Drawing.Color.Transparent;
            this.lbltieude.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.Location = new System.Drawing.Point(331, 7);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(334, 25);
            this.lbltieude.TabIndex = 15;
            this.lbltieude.Text = "DANH MỤC THÔNG TIN  SÁCH";
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(291, 30);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(193, 20);
            this.txtpage.TabIndex = 1;
            // 
            // btndau
            // 
            this.btndau.BackgroundImage = global::QLThuVien.Properties.Resources.Actions_green_arrow_left_end_icon;
            this.btndau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndau.Location = new System.Drawing.Point(31, 24);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(88, 28);
            this.btndau.TabIndex = 0;
            this.btndau.UseVisualStyleBackColor = true;
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
            // 
            // btnlui
            // 
            this.btnlui.BackgroundImage = global::QLThuVien.Properties.Resources.back_icon;
            this.btnlui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlui.Location = new System.Drawing.Point(152, 25);
            this.btnlui.Name = "btnlui";
            this.btnlui.Size = new System.Drawing.Size(88, 28);
            this.btnlui.TabIndex = 0;
            this.btnlui.UseVisualStyleBackColor = true;
            this.btnlui.Click += new System.EventHandler(this.btnlui_Click);
            // 
            // btntoi
            // 
            this.btntoi.BackgroundImage = global::QLThuVien.Properties.Resources.next_icon;
            this.btntoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btntoi.Location = new System.Drawing.Point(515, 22);
            this.btntoi.Name = "btntoi";
            this.btntoi.Size = new System.Drawing.Size(88, 28);
            this.btntoi.TabIndex = 0;
            this.btntoi.UseVisualStyleBackColor = true;
            this.btntoi.Click += new System.EventHandler(this.btntoi_Click);
            // 
            // btncuoi
            // 
            this.btncuoi.BackgroundImage = global::QLThuVien.Properties.Resources.Actions_green_arrow_right_end_icon;
            this.btncuoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncuoi.Location = new System.Drawing.Point(636, 19);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(88, 28);
            this.btncuoi.TabIndex = 0;
            this.btncuoi.UseVisualStyleBackColor = true;
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.groupBox4.Controls.Add(this.btncuoi);
            this.groupBox4.Controls.Add(this.btntoi);
            this.groupBox4.Controls.Add(this.btnlui);
            this.groupBox4.Controls.Add(this.btndau);
            this.groupBox4.Controls.Add(this.txtpage);
            this.groupBox4.Location = new System.Drawing.Point(364, 443);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(736, 61);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Điều Khiền";
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1100, 510);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbltieude);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSach";
            this.Text = "regio";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PICHINH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label btntensach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttheloaisach;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txttg;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtnamxb;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.TextBox txtnxb;
        private System.Windows.Forms.PictureBox PICHINH;
        private System.Windows.Forms.Button BTNHINH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvttsach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnxoasach;
        private System.Windows.Forms.Button btnthemsach;
        private System.Windows.Forms.Button btnsuasach;
        private System.Windows.Forms.Button btnluusach;
        private System.Windows.Forms.Label lblhienthinv;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.TextBox txtpage;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.Button btnlui;
        private System.Windows.Forms.Button btntoi;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btntimkiemttv;
        private System.Windows.Forms.TextBox txttimkiemma;
        private System.Windows.Forms.Button btnin1;
    }
}