using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace P_Hospital
{
    public partial class Hasta_Giris : Form
    {
        public Hasta_Giris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void linkuye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hasta_Kayit hkayit = new Hasta_Kayit();
            hkayit.Show();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Select * From Tbl_Hasta where HastaTC=@h1 and HastaSifre=@h2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@h1", mskdtc.Text);
            kmt.Parameters.AddWithValue("@h2", txtsifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                Hasta_Detay hdetay = new Hasta_Detay();
                hdetay.tc = mskdtc.Text;
                hdetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre :(", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            AnaForm fr = new AnaForm();
            fr.Show();
            this.Hide();
        }
    }
}
