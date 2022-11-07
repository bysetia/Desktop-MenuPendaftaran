
namespace pendaftaranSiswa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_daftar = new System.Windows.Forms.Button();
            this.cb_tahun = new System.Windows.Forms.ComboBox();
            this.cb_bulan = new System.Windows.Forms.ComboBox();
            this.cb_hari = new System.Windows.Forms.ComboBox();
            this.tb_alamatEmail = new System.Windows.Forms.TextBox();
            this.tb_tempatLahir = new System.Windows.Forms.TextBox();
            this.rb_perempuan = new System.Windows.Forms.RadioButton();
            this.rb_laki = new System.Windows.Forms.RadioButton();
            this.lbl_alamatEmail = new System.Windows.Forms.Label();
            this.lbl_tanggalLahir = new System.Windows.Forms.Label();
            this.lb_tempatLahir = new System.Windows.Forms.Label();
            this.lbl_jenisKelamin = new System.Windows.Forms.Label();
            this.lbl_noHp = new System.Windows.Forms.Label();
            this.tb_noHp = new System.Windows.Forms.TextBox();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_noPendaftaran = new System.Windows.Forms.TextBox();
            this.lbl_noPendaftaran = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_tanggalDaftar = new System.Windows.Forms.TextBox();
            this.lbl_tanggalDaftar = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulir Pendaftaran Siswa Baru Tahun 2022";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_daftar);
            this.groupBox1.Controls.Add(this.cb_tahun);
            this.groupBox1.Controls.Add(this.cb_bulan);
            this.groupBox1.Controls.Add(this.cb_hari);
            this.groupBox1.Controls.Add(this.tb_alamatEmail);
            this.groupBox1.Controls.Add(this.tb_tempatLahir);
            this.groupBox1.Controls.Add(this.rb_perempuan);
            this.groupBox1.Controls.Add(this.rb_laki);
            this.groupBox1.Controls.Add(this.lbl_alamatEmail);
            this.groupBox1.Controls.Add(this.lbl_tanggalLahir);
            this.groupBox1.Controls.Add(this.lb_tempatLahir);
            this.groupBox1.Controls.Add(this.lbl_jenisKelamin);
            this.groupBox1.Controls.Add(this.lbl_noHp);
            this.groupBox1.Controls.Add(this.tb_noHp);
            this.groupBox1.Controls.Add(this.tb_alamat);
            this.groupBox1.Controls.Add(this.lbl_alamat);
            this.groupBox1.Controls.Add(this.lbl_nama);
            this.groupBox1.Controls.Add(this.tb_nama);
            this.groupBox1.Controls.Add(this.tb_noPendaftaran);
            this.groupBox1.Controls.Add(this.lbl_noPendaftaran);
            this.groupBox1.Location = new System.Drawing.Point(47, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 511);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(206, 431);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(114, 431);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_daftar
            // 
            this.btn_daftar.Location = new System.Drawing.Point(23, 431);
            this.btn_daftar.Name = "btn_daftar";
            this.btn_daftar.Size = new System.Drawing.Size(75, 23);
            this.btn_daftar.TabIndex = 19;
            this.btn_daftar.Text = "Daftar";
            this.btn_daftar.UseVisualStyleBackColor = true;
            this.btn_daftar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_tahun
            // 
            this.cb_tahun.FormattingEnabled = true;
            this.cb_tahun.Items.AddRange(new object[] {
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cb_tahun.Location = new System.Drawing.Point(238, 343);
            this.cb_tahun.Name = "cb_tahun";
            this.cb_tahun.Size = new System.Drawing.Size(63, 23);
            this.cb_tahun.TabIndex = 18;
            // 
            // cb_bulan
            // 
            this.cb_bulan.FormattingEnabled = true;
            this.cb_bulan.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cb_bulan.Location = new System.Drawing.Point(171, 343);
            this.cb_bulan.Name = "cb_bulan";
            this.cb_bulan.Size = new System.Drawing.Size(63, 23);
            this.cb_bulan.TabIndex = 17;
            // 
            // cb_hari
            // 
            this.cb_hari.FormattingEnabled = true;
            this.cb_hari.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cb_hari.Location = new System.Drawing.Point(119, 343);
            this.cb_hari.Name = "cb_hari";
            this.cb_hari.Size = new System.Drawing.Size(46, 23);
            this.cb_hari.TabIndex = 16;
            this.cb_hari.SelectedIndexChanged += new System.EventHandler(this.cb_hari_SelectedIndexChanged);
            // 
            // tb_alamatEmail
            // 
            this.tb_alamatEmail.Location = new System.Drawing.Point(119, 381);
            this.tb_alamatEmail.Name = "tb_alamatEmail";
            this.tb_alamatEmail.Size = new System.Drawing.Size(133, 23);
            this.tb_alamatEmail.TabIndex = 15;
            // 
            // tb_tempatLahir
            // 
            this.tb_tempatLahir.Location = new System.Drawing.Point(119, 303);
            this.tb_tempatLahir.Name = "tb_tempatLahir";
            this.tb_tempatLahir.Size = new System.Drawing.Size(133, 23);
            this.tb_tempatLahir.TabIndex = 14;
            this.tb_tempatLahir.TextChanged += new System.EventHandler(this.tb_tempatLahir_TextChanged);
            // 
            // rb_perempuan
            // 
            this.rb_perempuan.AutoSize = true;
            this.rb_perempuan.Location = new System.Drawing.Point(195, 264);
            this.rb_perempuan.Name = "rb_perempuan";
            this.rb_perempuan.Size = new System.Drawing.Size(86, 19);
            this.rb_perempuan.TabIndex = 13;
            this.rb_perempuan.Text = "Perempuan";
            this.rb_perempuan.UseVisualStyleBackColor = true;
            this.rb_perempuan.CheckedChanged += new System.EventHandler(this.rb_perempuan_CheckedChanged);
            // 
            // rb_laki
            // 
            this.rb_laki.AutoSize = true;
            this.rb_laki.Location = new System.Drawing.Point(119, 264);
            this.rb_laki.Name = "rb_laki";
            this.rb_laki.Size = new System.Drawing.Size(70, 19);
            this.rb_laki.TabIndex = 2;
            this.rb_laki.Text = "Laki Laki";
            this.rb_laki.UseVisualStyleBackColor = true;
            this.rb_laki.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbl_alamatEmail
            // 
            this.lbl_alamatEmail.AutoSize = true;
            this.lbl_alamatEmail.Location = new System.Drawing.Point(20, 384);
            this.lbl_alamatEmail.Name = "lbl_alamatEmail";
            this.lbl_alamatEmail.Size = new System.Drawing.Size(77, 15);
            this.lbl_alamatEmail.TabIndex = 12;
            this.lbl_alamatEmail.Text = "Alamat Email";
            // 
            // lbl_tanggalLahir
            // 
            this.lbl_tanggalLahir.AutoSize = true;
            this.lbl_tanggalLahir.Location = new System.Drawing.Point(20, 346);
            this.lbl_tanggalLahir.Name = "lbl_tanggalLahir";
            this.lbl_tanggalLahir.Size = new System.Drawing.Size(77, 15);
            this.lbl_tanggalLahir.TabIndex = 11;
            this.lbl_tanggalLahir.Text = "Tanggal Lahir";
            this.lbl_tanggalLahir.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_tempatLahir
            // 
            this.lb_tempatLahir.AutoSize = true;
            this.lb_tempatLahir.Location = new System.Drawing.Point(20, 306);
            this.lb_tempatLahir.Name = "lb_tempatLahir";
            this.lb_tempatLahir.Size = new System.Drawing.Size(75, 15);
            this.lb_tempatLahir.TabIndex = 10;
            this.lb_tempatLahir.Text = "Tempat Lahir";
            // 
            // lbl_jenisKelamin
            // 
            this.lbl_jenisKelamin.AutoSize = true;
            this.lbl_jenisKelamin.Location = new System.Drawing.Point(20, 264);
            this.lbl_jenisKelamin.Name = "lbl_jenisKelamin";
            this.lbl_jenisKelamin.Size = new System.Drawing.Size(78, 15);
            this.lbl_jenisKelamin.TabIndex = 9;
            this.lbl_jenisKelamin.Text = "Jenis Kelamin";
            this.lbl_jenisKelamin.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_noHp
            // 
            this.lbl_noHp.AutoSize = true;
            this.lbl_noHp.Location = new System.Drawing.Point(20, 210);
            this.lbl_noHp.Name = "lbl_noHp";
            this.lbl_noHp.Size = new System.Drawing.Size(69, 15);
            this.lbl_noHp.TabIndex = 8;
            this.lbl_noHp.Text = "No. HP/WA";
            // 
            // tb_noHp
            // 
            this.tb_noHp.Location = new System.Drawing.Point(119, 207);
            this.tb_noHp.Name = "tb_noHp";
            this.tb_noHp.Size = new System.Drawing.Size(133, 23);
            this.tb_noHp.TabIndex = 7;
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(119, 139);
            this.tb_alamat.Multiline = true;
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(133, 48);
            this.tb_alamat.TabIndex = 6;
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.Location = new System.Drawing.Point(20, 142);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(93, 15);
            this.lbl_alamat.TabIndex = 5;
            this.lbl_alamat.Text = "Alamat Lengkap";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(20, 76);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(87, 15);
            this.lbl_nama.TabIndex = 4;
            this.lbl_nama.Text = "Nama Lengkap";
            this.lbl_nama.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(119, 73);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(133, 23);
            this.tb_nama.TabIndex = 3;
            // 
            // tb_noPendaftaran
            // 
            this.tb_noPendaftaran.Location = new System.Drawing.Point(119, 22);
            this.tb_noPendaftaran.Name = "tb_noPendaftaran";
            this.tb_noPendaftaran.Size = new System.Drawing.Size(133, 23);
            this.tb_noPendaftaran.TabIndex = 2;
            this.tb_noPendaftaran.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_noPendaftaran
            // 
            this.lbl_noPendaftaran.AutoSize = true;
            this.lbl_noPendaftaran.Location = new System.Drawing.Point(20, 25);
            this.lbl_noPendaftaran.Name = "lbl_noPendaftaran";
            this.lbl_noPendaftaran.Size = new System.Drawing.Size(93, 15);
            this.lbl_noPendaftaran.TabIndex = 2;
            this.lbl_noPendaftaran.Text = "No. Pendaftaran";
            this.lbl_noPendaftaran.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.tb_tanggalDaftar);
            this.groupBox2.Controls.Add(this.lbl_tanggalDaftar);
            this.groupBox2.Location = new System.Drawing.Point(381, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 272);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(30, 57);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(272, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Hide";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(272, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_tanggalDaftar
            // 
            this.tb_tanggalDaftar.Location = new System.Drawing.Point(119, 19);
            this.tb_tanggalDaftar.Name = "tb_tanggalDaftar";
            this.tb_tanggalDaftar.Size = new System.Drawing.Size(133, 23);
            this.tb_tanggalDaftar.TabIndex = 8;
            this.tb_tanggalDaftar.TextChanged += new System.EventHandler(this.tb_tanggalDaftar_TextChanged);
            // 
            // lbl_tanggalDaftar
            // 
            this.lbl_tanggalDaftar.AutoSize = true;
            this.lbl_tanggalDaftar.Location = new System.Drawing.Point(30, 22);
            this.lbl_tanggalDaftar.Name = "lbl_tanggalDaftar";
            this.lbl_tanggalDaftar.Size = new System.Drawing.Size(83, 15);
            this.lbl_tanggalDaftar.TabIndex = 4;
            this.lbl_tanggalDaftar.Text = "Tanggal Daftar";
            this.lbl_tanggalDaftar.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_output);
            this.groupBox3.Location = new System.Drawing.Point(381, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 340);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Pendaftar";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(18, 37);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(0, 15);
            this.lbl_output.TabIndex = 25;
            this.lbl_output.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_noPendaftaran;
        private System.Windows.Forms.Label lbl_noPendaftaran;
        private System.Windows.Forms.Label lbl_jenisKelamin;
        private System.Windows.Forms.Label lbl_noHp;
        private System.Windows.Forms.TextBox tb_noHp;
        private System.Windows.Forms.TextBox tb_alamat;
        private System.Windows.Forms.Label lbl_alamat;
        private System.Windows.Forms.ComboBox cb_tahun;
        private System.Windows.Forms.ComboBox cb_bulan;
        private System.Windows.Forms.ComboBox cb_hari;
        private System.Windows.Forms.TextBox tb_alamatEmail;
        private System.Windows.Forms.TextBox tb_tempatLahir;
        private System.Windows.Forms.RadioButton rb_perempuan;
        private System.Windows.Forms.RadioButton rb_laki;
        private System.Windows.Forms.Label lbl_alamatEmail;
        private System.Windows.Forms.Label lbl_tanggalLahir;
        private System.Windows.Forms.Label lb_tempatLahir;
        private System.Windows.Forms.Button btn_daftar;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_tanggalDaftar;
        private System.Windows.Forms.Label lbl_tanggalDaftar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_output;
    }
}

