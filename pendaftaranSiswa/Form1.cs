using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pendaftaranSiswa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String check = "";

            if (rb_laki.Checked == true)

                check = rb_laki.Text;

            else if (rb_perempuan.Checked == true)
                check = rb_perempuan.Text;
            else
                check = "";
            
            lbl_output.Text = " No Pendaftaran : " + tb_noPendaftaran.Text + " \n \n Nama Lengkap : " + tb_nama.Text + " \n \n Alamat Lengkap : " + tb_alamat.Text + " \n \n No.Hp : " + tb_noHp.Text + " \n \n Jenis Kelamin : " + check + " \n \n Tempat Lahir : " + tb_tempatLahir.Text + " \n \n Tanggal Lahir : " + cb_hari.Text + " " + cb_bulan.Text + " " + cb_tahun.Text + " \n \n Alamat Email : " + tb_alamatEmail.Text + " \n \n Tanggal Daftar: " + tb_tanggalDaftar.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_noPendaftaran.Text = "";
            tb_nama.Text = "";
            tb_alamat.Text = "";
            tb_noHp.Text = "";
            cb_hari.Text = "";
            cb_bulan.Text = "";
            cb_tahun.Text = "";
            rb_laki.Checked = false;
            rb_perempuan.Checked = false;
            tb_tempatLahir.Text = "";
            tb_alamatEmail.Text = "";
            tb_tanggalDaftar.Text = "";
            lbl_output.Text = "";
        }

        private void cb_hari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_tanggalDaftar.Text = monthCalendar1.SelectionRange.Start.ToString("dd MMMM yyyy");
            monthCalendar1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tb_tanggalDaftar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tb_tempatLahir_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rb_perempuan_CheckedChanged(object sender, EventArgs e)
        {
        
        }
    }
}
