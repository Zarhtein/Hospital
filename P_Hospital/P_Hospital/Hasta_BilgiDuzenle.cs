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
    public partial class Hasta_BilgiDuzenle : Form
    {
        public Hasta_BilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tcno;

        sqlbaglanti bgl = new sqlbaglanti();
        private void Hasta_BilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskdtc.Text = tcno;
            SqlCommand kmt = new SqlCommand("Select * From Tbl_Hasta where HastaTC=@t1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@t1", mskdtc.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                mskdtel.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                cmbcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("Update Tbl_Hasta set HastaAd=@h1,HastaSoyad=@h2,HastaTel=@h3,HastaSifre=@h4,HastaCnsyt=@h5 where HastaTC=@h6", bgl.baglanti());
            kmt2.Parameters.AddWithValue("@h1", txtad.Text);
            kmt2.Parameters.AddWithValue("@h2", txtsoyad.Text);
            kmt2.Parameters.AddWithValue("@h3", mskdtel.Text);
            kmt2.Parameters.AddWithValue("@h4", txtsifre.Text);
            kmt2.Parameters.AddWithValue("@h5", cmbcinsiyet.Text);
            kmt2.Parameters.AddWithValue("@h6", mskdtc.Text);
            kmt2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            Hasta_Detay fr = new Hasta_Detay();
            fr.Show();
            this.Hide();
        }
    }
}
