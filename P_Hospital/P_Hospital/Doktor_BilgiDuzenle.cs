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
    public partial class Doktor_BilgiDuzenle : Form
    {
        public Doktor_BilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string tcno;

        private void Doktor_BilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskdtc.Text = tcno;

            SqlCommand kmt = new SqlCommand("Select * From Tbl_Doktor where DoktorTC=@d1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@d1", mskdtc.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                txtsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("Update Tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            kmt2.Parameters.AddWithValue("@p1", txtad.Text);
            kmt2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            kmt2.Parameters.AddWithValue("@p3", cmbbrans.Text);
            kmt2.Parameters.AddWithValue("@p4", txtsifre.Text);
            kmt2.Parameters.AddWithValue("@p5", mskdtc.Text);
            kmt2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
